using System.Windows.Forms.DataVisualization.Charting;
using beauty_shop.DAL;
using beauty_shop.Model;

namespace beauty_shop.Forms
{
    public partial class BaoCaoThongKe : Form
    {
        private BaoCaoThongKeDAL baoCaoThongKeDAL;

        public BaoCaoThongKe()
        {
            InitializeComponent();
            baoCaoThongKeDAL = new BaoCaoThongKeDAL();

        }
        //pull lại


        private void LoadData()
        {
            try
            {
                Console.WriteLine($"LoadData: Attempting to load data for {dtpStartDate.Value:yyyy-MM-dd HH:mm:ss} to {dtpEndDate.Value:yyyy-MM-dd HH:mm:ss}");
                var refreshData = baoCaoThongKeDAL.LoadData(dtpStartDate.Value, dtpEndDate.Value);

                // Cập nhật các label
                lblNumOrders.Text = baoCaoThongKeDAL.NumOrders.ToString();
                lblTotalRevenue.Text = "$" + baoCaoThongKeDAL.TotalRevenue.ToString("N2");
                lblTotalProfit.Text = "$" + baoCaoThongKeDAL.TotalProfit.ToString("N2");
                lblNumCustomers.Text = baoCaoThongKeDAL.NumCustomers.ToString();
                lblNumSuppliers.Text = baoCaoThongKeDAL.NumSuppliers.ToString();
                lblNumProducts.Text = baoCaoThongKeDAL.NumProducts.ToString();

                chartDoanhThu.Series["DoanhThu"].Points.Clear();

                foreach (var doanhThu in baoCaoThongKeDAL.GrossRevenueList)
                {
                    chartDoanhThu.Series["DoanhThu"].Points.AddXY(doanhThu.Date, doanhThu.TotalAmount);
                }

                chartDoanhThu.Series["DoanhThu"].ChartType = SeriesChartType.Column;
                chartDoanhThu.Series["DoanhThu"].IsValueShownAsLabel = true;

                chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
                chartDoanhThu.ChartAreas[0].AxisX.Interval = 1;
                chartDoanhThu.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error in LoadData: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                MessageBox.Show("An error occurred while loading data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            using (var context = new BeautyShopContext())
            {
                var earliestDate = context.HoaDonBan.OrderBy(h => h.NgayBan).Select(h => h.NgayBan).FirstOrDefault();
                var latestDate = context.HoaDonBan.OrderByDescending(h => h.NgayBan).Select(h => h.NgayBan).FirstOrDefault();
                dtpStartDate.Value = earliestDate != default ? earliestDate : DateTime.Today.AddDays(-30);
                dtpEndDate.Value = latestDate != default ? latestDate : DateTime.Now;
                Console.WriteLine($"BaoCaoThongKe_Load: Set date range to {dtpStartDate.Value:yyyy-MM-dd HH:mm:ss} to {dtpEndDate.Value:yyyy-MM-dd HH:mm:ss}");
            }
            LoadData();
            DisableCustomDates();
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start date cannot be later than end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadData();
        }

        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
        }

        private void chartTopProducts_Click(object sender, EventArgs e)
        {
            // Placeholder for future functionality
        }

        private void chartGrossRevenue_Click(object sender, EventArgs e)
        {
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void chartGrossRevenue_Click_1(object sender, EventArgs e)
        {

        }
    }
}