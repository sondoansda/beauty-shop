using beauty_shop.BLL;
using beauty_shop.DTO;
using beauty_shop.Model;

namespace beauty_shop
{
    public partial class HoaDon : Form
    {
        private readonly HoaDonBanBLL _hoaDonBanBLL;
        private List<ChiTietHDBDTO> _chiTietHDBs;

        public HoaDon()
        {
            InitializeComponent();
            _chiTietHDBs = new List<ChiTietHDBDTO>();
            var context = new BeautyShopContext();
            _hoaDonBanBLL = new HoaDonBanBLL(context);
            SetupDataGridViews();
            LoadNhanVien();
            LoadDanhSachHoaDon();
        }

        private void SetupDataGridViews()
        {
            dgvChiTietHDB.Columns.Clear();
            dgvChiTietHDB.Columns.Add("MaHang", "Mã Hàng");
            dgvChiTietHDB.Columns.Add("DonGia", "Đơn Giá");
            dgvChiTietHDB.Columns.Add("SoLuong", "Số Lượng");
            dgvChiTietHDB.Columns.Add("GiamGia", "Giảm Giá");
            dgvChiTietHDB.Columns.Add("ThanhTien", "Thành Tiền");

            dgvDanhSachHDB.Columns.Clear();
            dgvDanhSachHDB.Columns.Add("SoHDB", "Số HĐB");
            dgvDanhSachHDB.Columns.Add("NgayBan", "Ngày Bán");
            dgvDanhSachHDB.Columns.Add("TenNV", "Nhân Viên");
            dgvDanhSachHDB.Columns.Add("TenKhach", "Khách Hàng");
            dgvDanhSachHDB.Columns.Add("TongTien", "Tổng Tiền");
        }

        private void LoadNhanVien()
        {
            var nhanViens = _hoaDonBanBLL.LayDanhSachNhanVien();
            cmbNhanVien.DataSource = nhanViens;
            cmbNhanVien.DisplayMember = "Tennhanvien";
            cmbNhanVien.ValueMember = "Manhanvien";
        }

        private void LoadDanhSachHoaDon()
        {
            var hoaDons = _hoaDonBanBLL.LayDanhSachHoaDon();
            dgvDanhSachHDB.Rows.Clear();
            foreach (var hd in hoaDons)
            {
                dgvDanhSachHDB.Rows.Add(hd.SoHDB, hd.NgayBan.ToString("dd/MM/yyyy"), hd.TenNV, hd.TenKhach, hd.TongTien.ToString("N0"));
            }
        }

        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {
            var tenKhach = txtTenKhach.Text.Trim();
            if (!string.IsNullOrEmpty(tenKhach))
            {
                var khachHang = _hoaDonBanBLL.TimKhachHangTheoTen(tenKhach);
                lblMaKhach.Text = khachHang != null ? $"Mã Khách: {khachHang.MaKhach}" : "Mã Khách: Không tìm thấy";
            }
            else
            {
                lblMaKhach.Text = "Mã Khách: ";
            }
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            var maHang = txtMaHang.Text.Trim();
            if (!string.IsNullOrEmpty(maHang))
            {
                var hangHoa = _hoaDonBanBLL.TimHangHoaTheoMa(maHang);
                txtDonGia.Text = hangHoa != null ? hangHoa.DonGiaBan.ToString("N0") : "";
            }
            else
            {
                txtDonGia.Text = "";
            }
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            var maHang = txtMaHang.Text.Trim();
            if (string.IsNullOrEmpty(maHang))
            {
                MessageBox.Show("Vui lòng nhập mã hàng hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var hangHoa = _hoaDonBanBLL.TimHangHoaTheoMa(maHang);
            if (hangHoa == null)
            {
                MessageBox.Show("Mã hàng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_hoaDonBanBLL.KiemTraTonKho(maHang, (float)nudSoLuong.Value, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var chiTiet = new ChiTietHDBDTO
            {
                MaHang = maHang,
                SoLuong = (int)nudSoLuong.Value,
                DonGia = hangHoa.DonGiaBan,
                GiamGia = 0, // Không giảm giá
                ThanhTien = hangHoa.DonGiaBan * (int)nudSoLuong.Value * (1 - 0)
            };

            _chiTietHDBs.Add(chiTiet);
            dgvChiTietHDB.Rows.Add(chiTiet.MaHang, chiTiet.DonGia.ToString("N0"), chiTiet.SoLuong, chiTiet.GiamGia, chiTiet.ThanhTien.ToString("N0"));

            txtMaHang.Clear();
            txtDonGia.Clear();
            nudSoLuong.Value = 1;
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            var tenKhach = txtTenKhach.Text.Trim();
            var maNhanVien = cmbNhanVien.SelectedValue?.ToString();  // Mã nhân viên
            var tenNhanVien = cmbNhanVien.Text.Trim();              // Tên nhân viên hiển thị

            if (string.IsNullOrEmpty(tenKhach))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_chiTietHDBs.Any())
            {
                MessageBox.Show("Hóa đơn phải có ít nhất một mặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn lưu hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            var hoaDonDTO = new HoaDonBanDTO
            {
                SoHDB = Guid.NewGuid().ToString().Substring(0, 10),
                // Lưu mã nhân viên nếu cần
                TenNV = tenNhanVien,  // Lưu tên nhân viên hiển thị
                TenKhach = tenKhach,
                NgayBan = DateTime.Now,
                TongTien = _chiTietHDBs.Sum(ct => ct.ThanhTien)
            };

            if (_hoaDonBanBLL.LuuHoaDon(hoaDonDTO, _chiTietHDBs, out string errorMessage))
            {
                MessageBox.Show("Lưu hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Clear();
                lblMaKhach.Text = "Mã Khách: ";
                _chiTietHDBs.Clear();
                dgvChiTietHDB.Rows.Clear();
                LoadDanhSachHoaDon();
            }
            else
            {
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}