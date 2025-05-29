//using System.Windows.Controls;

using beauty_shop.BLL;
using beauty_shop.DAL;
using beauty_shop.Model;
using Microsoft.EntityFrameworkCore;
namespace beauty_shop.Forms
{
    public partial class QuanLySP : Form
    {
        private readonly SanPhamBLL _bll;
        private string _selectedImagePath;

        public QuanLySP()
        {
            var connectionString = "server=sql3.freesqldatabase.com;port=3306;database=sql3781960;user=sql3781960;password=3deQ7zieYl;";
            InitializeComponent();
            // Initialize DbContext and dependencies
            var optionsBuilder = new DbContextOptionsBuilder<BeautyShopContext>();

            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(10, 4, 32)));
            var context = new BeautyShopContext(optionsBuilder.Options);
            var dal = new SanPhamDAL(context);
            _bll = new SanPhamBLL(dal);

            InitializeDataGridView();
            LoadSanPhamData();
        }

        private void InitializeDataGridView()
        {
            // Configure DataGridView
            dgvHangHoa.AutoGenerateColumns = false;
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.ReadOnly = true;

            // Add columns matching SanPhamDTO properties
            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaHang",
                HeaderText = "Mã Hàng",
                Width = 100
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenHangHoa",
                HeaderText = "Tên Hàng Hóa",
                Width = 150
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenLoai",
                HeaderText = "Loại",
                Width = 100
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenCongDung",
                HeaderText = "Công Dụng",
                Width = 100
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoLuong",
                HeaderText = "Số Lượng",
                Width = 80
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Gianhap",
                HeaderText = "Giá Nhập",
                Width = 100
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Giaban",
                HeaderText = "Giá Bán",
                Width = 100
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MauSac",
                HeaderText = "Màu Sắc",
                Width = 100
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ChatLieu",
                HeaderText = "Chất Liệu",
                Width = 100
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HangSX",
                HeaderText = "Hãng SX",
                Width = 100
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Mua",
                HeaderText = "Mùa",
                Width = 100
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ThoiGianBaoHanh",
                HeaderText = "Bảo Hành",
                Width = 100
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GhiChu",
                HeaderText = "Ghi Chú",
                Width = 150
            });
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHangHoa.Rows[e.RowIndex].DataBoundItem is SanPhamDTO selectedProduct)
            {
                tabControl1.SelectedTab = tabChiTietSP;
                PopulateInputFields(selectedProduct);
            }
        }

        private void PopulateInputFields(SanPhamDTO product)
        {
            txtMaSP.Text = product.MaHang;
            txtTenSP.Text = product.TenHangHoa;
            txtLoai.Text = product.TenLoai;
            txtHangSX.Text = product.HangSX;
            txtChatLieu.Text = product.ChatLieu;
            txtXuatSu.Text = product.XuatXu;
            txtMau.Text = product.MauSac;
            txtCongDung.Text = product.TenCongDung;
            txtMua.Text = product.Mua;
            txtSoLuong.Text = product.SoLuong.ToString();
            txtGiaNhap.Text = product.Gianhap.ToString();
            txtGhichu.Text = product.GhiChu;
            txtThoiGianBaoHanh.Text = product.ThoiGianBaoHanh.ToString();

            _selectedImagePath = product.Anh;
            if (!string.IsNullOrWhiteSpace(product.Anh) && File.Exists(product.Anh))
            {
                pictureBox1.Image = Image.FromFile(product.Anh);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                btnAddImage.Visible = false;
            }
            else
            {
                pictureBox1.Image = null;
                btnAddImage.Visible = true;
            }
        }

        private void btnAddImage_Click_1(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Opening file dialog..."); // Debug message
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                    Title = "Select Product Image",
                    RestoreDirectory = true
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(_selectedImagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    btnAddImage.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
                {
                    MessageBox.Show("Mã sản phẩm và tên sản phẩm không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Copy image to project folder if selected
                string savedImagePath = _selectedImagePath;
                if (!string.IsNullOrWhiteSpace(_selectedImagePath))
                {
                    string imagesFolder = Path.Combine(Application.StartupPath, "Images", "Products");
                    Directory.CreateDirectory(imagesFolder);
                    string fileName = $"{txtMaSP.Text}_{Path.GetFileName(_selectedImagePath)}";
                    savedImagePath = Path.Combine(imagesFolder, fileName);

                    if (_selectedImagePath != savedImagePath && File.Exists(_selectedImagePath))
                    {
                        File.Copy(_selectedImagePath, savedImagePath, true);
                    }
                    savedImagePath = Path.Combine("Images", "Products", fileName); // Relative path
                }

                // Create SanPhamDTO
                var product = new SanPhamDTO
                {
                    MaHang = txtMaSP.Text,
                    TenHangHoa = txtTenSP.Text,
                    TenLoai = txtLoai.Text,
                    TenCongDung = txtCongDung.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    Gianhap = decimal.Parse(txtGiaNhap.Text),
                    Giaban = decimal.Parse(txtGiaNhap.Text) * 1.1m,
                    MauSac = txtMau.Text,
                    ChatLieu = txtChatLieu.Text,
                    HangSX = txtHangSX.Text,
                    Mua = txtMua.Text,
                    XuatXu = txtXuatSu.Text,
                    Anh = savedImagePath,
                    GhiChu = txtGhichu.Text,
                    ThoiGianBaoHanh = int.Parse(txtThoiGianBaoHanh.Text)
                };


                _bll.SaveOrUpdateSanPham(product, savedImagePath);

                MessageBox.Show("Lưu sản phẩm thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear inputs and reload data
                ClearInputs();
                LoadHangHoa();
                tabControl1.SelectedTab = tabControl1.TabPages[0]; // Switch back to main tab
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu sản phẩm: {ex.Message}\nInner Exception: {ex.InnerException?.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuanLySP_Load(object sender, EventArgs e)
        {
            LoadHangHoa();
        }

        private void LoadSanPhamData()
        {
            LoadHangHoa();
        }


        private void LoadHangHoa(string searchTerm = null)
        {
            try
            {
                var list = _bll.GetAllSanPham();
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    list = list.Where(s =>
                        (s.MaHang?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (s.TenHangHoa?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (s.TenLoai?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (s.TenCongDung?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (s.MauSac?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (s.ChatLieu?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (s.HangSX?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (s.Mua?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (s.XuatXu?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (s.GhiChu?.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ?? false))
                        .ToList();
                }
                dgvHangHoa.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}\nInner Exception: {ex.InnerException?.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtLoai.Clear();
            txtHangSX.Clear();
            txtChatLieu.Clear();
            txtXuatSu.Clear();
            txtMau.Clear();
            txtCongDung.Clear();
            txtMua.Clear();
            txtSoLuong.Clear();
            txtGiaNhap.Clear();
            ;
            txtThoiGianBaoHanh.Clear();
            pictureBox1.Image = null;
            btnAddImage.Visible = true;
            _selectedImagePath = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
            tabControl1.SelectedTab = tabChiTietSP;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            ClearInputs();
            tabControl1.SelectedTab = tabDSSP;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
