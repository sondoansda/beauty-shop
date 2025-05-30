using System.Globalization;
using beauty_shop.Model;
using Microsoft.EntityFrameworkCore;

namespace beauty_shop.DAL
{
    public class DoanhThuTheoNgay
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class BaoCaoThongKeDAL
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers { get; private set; }
        public int NumSuppliers { get; private set; }
        public int NumProducts { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<DoanhThuTheoNgay> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        public BaoCaoThongKeDAL()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();
            GrossRevenueList = new List<DoanhThuTheoNgay>();
        }

        private void GetNumberItems()
        {
            try
            {
                using (var context = new BeautyShopContext())
                {
                    Console.WriteLine($"GetNumberItems - Database connected: {context.Database.CanConnect()}");
                    Console.WriteLine($"GetNumberItems - Connection String: {context.Database.GetDbConnection().ConnectionString}");
                    NumCustomers = context.KhachHang?.Count() ?? 0;
                    NumSuppliers = context.NhaCungCap?.Count() ?? 0;
                    NumProducts = context.DMHangHoa?.Count() ?? 0;
                    NumOrders = context.HoaDonBan
                        .Count(h => h.NgayBan >= startDate && h.NgayBan <= endDate);

                    Console.WriteLine($"GetNumberItems: Customers={NumCustomers}, Suppliers={NumSuppliers}, Products={NumProducts}, Orders={NumOrders}");
                    var totalOrders = context.HoaDonBan.Count();
                    var earliestOrder = context.HoaDonBan.OrderBy(h => h.NgayBan).Select(h => h.NgayBan).FirstOrDefault();
                    var latestOrder = context.HoaDonBan.OrderByDescending(h => h.NgayBan).Select(h => h.NgayBan).FirstOrDefault();
                    Console.WriteLine($"GetNumberItems: Total Orders in DB={totalOrders}, Earliest Order={(earliestOrder == default ? "None" : earliestOrder.ToString("yyyy-MM-dd HH:mm:ss"))}, Latest Order={(latestOrder == default ? "None" : latestOrder.ToString("yyyy-MM-dd HH:mm:ss"))}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetNumberItems: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            }
        }

        private void GetProductAnalysis()
        {
            try
            {
                using (var context = new BeautyShopContext())
                {
                    var ordersInRange = context.HoaDonBan
                        .Where(h => h.NgayBan >= startDate && h.NgayBan <= endDate)
                        .Select(h => new { h.SoHDB, h.NgayBan })
                        .ToList();
                    Console.WriteLine($"GetProductAnalysis: Orders in range ({startDate:yyyy-MM-dd HH:mm:ss} to {endDate:yyyy-MM-dd HH:mm:ss}): {ordersInRange.Count}");
                    foreach (var order in ordersInRange)
                    {
                        Console.WriteLine($"Order: SoHDB={order.SoHDB}, Date={order.NgayBan:yyyy-MM-dd HH:mm:ss}");
                    }

                    var queryData = context.ChiTietHDB
                        .Include(c => c.HoaDonBan)
                        .Include(c => c.DMHangHoa)
                        .Where(c => c.SoHDB != null && c.HoaDonBan != null && c.DMHangHoa != null && c.HoaDonBan.NgayBan >= startDate && c.HoaDonBan.NgayBan <= endDate)
                        .Select(c => new { c.HoaDonBan.NgayBan, SoLuong = c.SoLuong, TenHangHoa = c.DMHangHoa.TenHangHoa ?? "Unknown Product" })
                        .ToList();
                    Console.WriteLine($"GetProductAnalysis: Query data count={queryData.Count}");
                    foreach (var item in queryData)
                    {
                        Console.WriteLine($"Query Data: Date={item.NgayBan:yyyy-MM-dd HH:mm:ss}, Sold={item.SoLuong}, Product={item.TenHangHoa}");
                    }

                    TopProductsList = context.ChiTietHDB
                        .Include(c => c.HoaDonBan)
                        .Include(c => c.DMHangHoa)
                        .Where(c => c.SoHDB != null && c.HoaDonBan != null && c.DMHangHoa != null && c.HoaDonBan.NgayBan >= startDate && c.HoaDonBan.NgayBan <= endDate)
                        .GroupBy(c => c.DMHangHoa.TenHangHoa)
                        .Select(g => new KeyValuePair<string, int>(
                            g.Key ?? "Unknown Product",
                            g.Sum(x => x.SoLuong)))
                        .OrderByDescending(g => g.Value)
                        .Take(5)
                        .ToList();
                    Console.WriteLine($"GetProductAnalysis: TopProductsList count={TopProductsList.Count}");
                    foreach (var item in TopProductsList)
                    {
                        Console.WriteLine($"Top Product: {item.Key}, Sold: {item.Value}");
                    }

                    var allProducts = context.DMHangHoa
                        .Select(p => new { p.TenHangHoa, p.SoLuong })
                        .ToList();
                    Console.WriteLine($"GetProductAnalysis: Total products in DMHangHoa={allProducts.Count}");
                    foreach (var product in allProducts)
                    {
                        Console.WriteLine($"Product: Name={product.TenHangHoa ?? "Null"}, Stock={product.SoLuong}");
                    }

                    UnderstockList = context.DMHangHoa
                        .Where(p => p.SoLuong <= 6)
                        .Select(p => new KeyValuePair<string, int>(
                            p.TenHangHoa ?? "Unknown Product",
                            p.SoLuong))
                        .ToList();
                    Console.WriteLine($"GetProductAnalysis: UnderstockList count={UnderstockList.Count}");
                    foreach (var item in UnderstockList)
                    {
                        Console.WriteLine($"Understock Product: {item.Key}, Stock: {item.Value}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetProductAnalysis: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                TopProductsList = new List<KeyValuePair<string, int>>();
                UnderstockList = new List<KeyValuePair<string, int>>();
            }
        }

        private void GetOrderAnalysis()
        {
            try
            {
                using (var context = new BeautyShopContext())
                {
                    var resultTable = context.HoaDonBan
                        .Where(h => h.NgayBan >= startDate && h.NgayBan <= endDate)
                        .GroupBy(h => h.NgayBan.Date)
                        .Select(g => new KeyValuePair<DateTime, decimal>(g.Key, g.Sum(h => h.TongTien)))
                        .ToList();
                    Console.WriteLine($"GetOrderAnalysis: ResultTable count={resultTable.Count}");

                    TotalRevenue = resultTable?.Sum(x => x.Value) ?? 0;
                    TotalProfit = TotalRevenue * 0.2m;

                    Console.WriteLine($"GetOrderAnalysis: TotalRevenue={TotalRevenue}, TotalProfit={TotalProfit}, ResultTable count={resultTable.Count}");

                    if (numberDays <= 1)
                    {
                        GrossRevenueList = resultTable
                            .Select(g => new DoanhThuTheoNgay
                            {
                                Date = g.Key.ToString("hh tt", CultureInfo.InvariantCulture),
                                TotalAmount = g.Value
                            })
                            .ToList();
                    }
                    else if (numberDays <= 30)
                    {
                        GrossRevenueList = resultTable
                            .Select(g => new DoanhThuTheoNgay
                            {
                                Date = g.Key.ToString("dd MMM", CultureInfo.InvariantCulture),
                                TotalAmount = g.Value
                            })
                            .ToList();
                    }
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = resultTable
                            .GroupBy(x => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                x.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday))
                            .Select(g => new DoanhThuTheoNgay
                            {
                                Date = "Week " + g.Key.ToString(),
                                TotalAmount = g.Sum(x => x.Value)
                            })
                            .ToList();
                    }
                    else if (numberDays <= 365 * 2)
                    {
                        bool isYear = numberDays <= 365;
                        GrossRevenueList = resultTable
                            .GroupBy(x => new { x.Key.Year, x.Key.Month })
                            .Select(g => new DoanhThuTheoNgay
                            {
                                Date = isYear ? g.Key.Month.ToString("MMM", CultureInfo.InvariantCulture) : $"{g.Key.Month.ToString("MMM", CultureInfo.InvariantCulture)} {g.Key.Year}",
                                TotalAmount = g.Sum(x => x.Value)
                            })
                            .ToList();
                    }
                    else
                    {
                        GrossRevenueList = resultTable
                            .GroupBy(x => x.Key.Year)
                            .Select(g => new DoanhThuTheoNgay
                            {
                                Date = g.Key.ToString(),
                                TotalAmount = g.Sum(x => x.Value)
                            })
                            .ToList();
                    }
                    string message = "Gross Revenue List:\n";

                    foreach (var item in GrossRevenueList)
                    {
                        message += $"Date: {item.Date}, Amount: {item.TotalAmount:C}\n";
                    }

                    MessageBox.Show(message, "Gross Revenue Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetOrderAnalysis: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                GrossRevenueList = new List<DoanhThuTheoNgay>();
            }
        }

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                Console.WriteLine("Error: startDate cannot be later than endDate");
                return false;
            }

            endDate = endDate.Date.AddDays(1).AddTicks(-1);
            Console.WriteLine($"LoadData: Using date range {startDate:yyyy-MM-dd HH:mm:ss} to {endDate:yyyy-MM-dd HH:mm:ss}");

            using (var context = new BeautyShopContext())
            {
                Console.WriteLine($"LoadData - Database connected: {context.Database.CanConnect()}");
                Console.WriteLine($"LoadData - Connection String: {context.Database.GetDbConnection().ConnectionString}");
                var hasData = context.HoaDonBan
                    .Any(h => h.NgayBan >= startDate && h.NgayBan <= endDate);
                Console.WriteLine($"LoadData: Has data in range: {hasData}");

                if (!hasData)
                {
                    Console.WriteLine($"No data found for the period {startDate:yyyy-MM-dd HH:mm:ss} to {endDate:yyyy-MM-dd HH:mm:ss}. Adjusting to the latest available data...");
                    var earliestDate = context.HoaDonBan
                        .OrderBy(h => h.NgayBan)
                        .Select(h => h.NgayBan)
                        .FirstOrDefault();

                    var latestDate = context.HoaDonBan
                        .OrderByDescending(h => h.NgayBan)
                        .Select(h => h.NgayBan)
                        .FirstOrDefault();

                    if (earliestDate != default(DateTime) && latestDate != default(DateTime))
                    {
                        startDate = earliestDate;
                        endDate = latestDate.Date.AddDays(1).AddTicks(-1);
                        Console.WriteLine($"Adjusted period to {startDate:yyyy-MM-dd HH:mm:ss} to {endDate:yyyy-MM-dd HH:mm:ss}");
                    }
                    else
                    {
                        Console.WriteLine("No invoice data available in the database.");
                        return false;
                    }
                }
            }

            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                Console.WriteLine($"Loading data for period: {startDate:yyyy-MM-dd HH:mm:ss} to {endDate:yyyy-MM-dd HH:mm:ss}");
                GetNumberItems();
                GetProductAnalysis();
                GetOrderAnalysis();
                Console.WriteLine($"Refreshed data: {startDate:yyyy-MM-dd HH:mm:ss} to {endDate:yyyy-MM-dd HH:mm:ss}");
                return true;
            }
            else
            {
                Console.WriteLine($"Data not refreshed, same query: {startDate:yyyy-MM-dd HH:mm:ss} to {endDate:yyyy-MM-dd HH:mm:ss}");
                return false;
            }
        }
    }
}