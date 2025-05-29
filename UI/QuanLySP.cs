using beauty_shop.DAL;

namespace beauty_shop.Forms
{
    public partial class QuanLySP : Form
    {
        private SanPhamDAL service = new SanPhamDAL();
        public QuanLySP()
        {
            InitializeComponent();
            dgvHangHoa.DataSource = service.GetAll();

        }

        //public void LoadData()
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{

        //}

        //private void QuanLySP_Load(object sender, EventArgs e)
        //{

        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}


        private void btnThem_Click(object sender, EventArgs e)
        {
            // Code xử lý thêm hàng hóa mới
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Code xử lý cập nhật hàng hóa
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Code xử lý xóa hàng hóa
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Code xử lý tìm kiếm
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gán dữ liệu lên các textbox để sửa
        }
    }
}
