
namespace beauty_shop
{
    partial class HoaDon
    {
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.DataGridView dgvChiTietHDB;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.DataGridView dgvDanhSachHDB;

        private void InitializeComponent()
        {
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblMaKhach = new Label();
            lblNhanVien = new Label();
            cmbNhanVien = new ComboBox();
            lblMaHang = new Label();
            txtMaHang = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblSoLuong = new Label();
            nudSoLuong = new NumericUpDown();
            btnThemHang = new Button();
            dgvChiTietHDB = new DataGridView();
            btnLuuHoaDon = new Button();
            dgvDanhSachHDB = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHDB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHDB).BeginInit();
            SuspendLayout();
            // 
            // lblTenKhach
            // 
            lblTenKhach.Location = new Point(20, 20);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(100, 20);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên Khách Hàng:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(130, 20);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(200, 27);
            txtTenKhach.TabIndex = 1;
            // 
            // lblMaKhach
            // 
            lblMaKhach.Location = new Point(350, 20);
            lblMaKhach.Name = "lblMaKhach";
            lblMaKhach.Size = new Size(100, 20);
            lblMaKhach.TabIndex = 2;
            lblMaKhach.Text = "Mã Khách: ";
            // 
            // lblNhanVien
            // 
            lblNhanVien.Location = new Point(20, 50);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(100, 20);
            lblNhanVien.TabIndex = 3;
            lblNhanVien.Text = "Nhân Viên:";
            // 
            // cmbNhanVien
            // 
            cmbNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNhanVien.Location = new Point(130, 50);
            cmbNhanVien.Name = "cmbNhanVien";
            cmbNhanVien.Size = new Size(200, 28);
            cmbNhanVien.TabIndex = 4;
            //cmbNhanVien.SelectedIndexChanged += cmbNhanVien_SelectedIndexChanged;
            // 
            // lblMaHang
            // 
            lblMaHang.Location = new Point(20, 80);
            lblMaHang.Name = "lblMaHang";
            lblMaHang.Size = new Size(100, 20);
            lblMaHang.TabIndex = 5;
            lblMaHang.Text = "Mã Hàng:";
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(130, 80);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(100, 27);
            txtMaHang.TabIndex = 6;
            //txtMaHang.TextChanged += txtMaHang_TextChanged;
            // 
            // lblDonGia
            // 
            lblDonGia.Location = new Point(250, 80);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(60, 20);
            lblDonGia.TabIndex = 7;
            lblDonGia.Text = "Đơn Giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(320, 80);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(100, 27);
            txtDonGia.TabIndex = 8;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Location = new Point(440, 80);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(60, 20);
            lblSoLuong.TabIndex = 9;
            lblSoLuong.Text = "Số Lượng:";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(510, 80);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(60, 27);
            nudSoLuong.TabIndex = 10;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThemHang
            // 
            btnThemHang.Location = new Point(580, 80);
            btnThemHang.Name = "btnThemHang";
            btnThemHang.Size = new Size(80, 25);
            btnThemHang.TabIndex = 11;
            btnThemHang.Text = "Thêm Hàng";
            btnThemHang.Click += btnThemHang_Click;
            // 
            // dgvChiTietHDB
            // 
            dgvChiTietHDB.ColumnHeadersHeight = 29;
            dgvChiTietHDB.Location = new Point(20, 110);
            dgvChiTietHDB.Name = "dgvChiTietHDB";
            dgvChiTietHDB.RowHeadersWidth = 51;
            dgvChiTietHDB.Size = new Size(640, 150);
            dgvChiTietHDB.TabIndex = 12;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Location = new Point(535, 270);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(125, 25);
            btnLuuHoaDon.TabIndex = 13;
            btnLuuHoaDon.Text = "Lưu Hóa Đơn";
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // dgvDanhSachHDB
            // 
            dgvDanhSachHDB.ColumnHeadersHeight = 29;
            dgvDanhSachHDB.Location = new Point(20, 300);
            dgvDanhSachHDB.Name = "dgvDanhSachHDB";
            dgvDanhSachHDB.RowHeadersWidth = 51;
            dgvDanhSachHDB.Size = new Size(640, 200);
            dgvDanhSachHDB.TabIndex = 14;
            // 
            // HoaDon
            // 
            ClientSize = new Size(682, 503);
            Controls.Add(lblTenKhach);
            Controls.Add(txtTenKhach);
            Controls.Add(lblMaKhach);
            Controls.Add(lblNhanVien);
            Controls.Add(cmbNhanVien);
            Controls.Add(lblMaHang);
            Controls.Add(txtMaHang);
            Controls.Add(lblDonGia);
            Controls.Add(txtDonGia);
            Controls.Add(lblSoLuong);
            Controls.Add(nudSoLuong);
            Controls.Add(btnThemHang);
            Controls.Add(dgvChiTietHDB);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(dgvDanhSachHDB);
            Name = "HoaDon";
            Text = "Tạo Hóa Đơn Bán";
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHDB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHDB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

    }
}