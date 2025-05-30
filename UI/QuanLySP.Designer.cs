namespace beauty_shop.Forms
{
    partial class QuanLySP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabDSSP = new TabPage();
            btnThem = new FontAwesome.Sharp.IconButton();
            dgvHangHoa = new DataGridView();
            btnHuy = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            tabChiTietSP = new TabPage();
            btnAddImage = new FontAwesome.Sharp.IconButton();
            txtGhichu = new Label();
            label6 = new Label();
            btnHuybo = new FontAwesome.Sharp.IconButton();
            btnLuu = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            txtThoiGianBaoHanh = new TextBox();
            txtSoLuong = new TextBox();
            labelSoLuong = new Label();
            txtGiaNhap = new TextBox();
            label4 = new Label();
            txtXuatSu = new TextBox();
            label2 = new Label();
            txtMau = new TextBox();
            lblMau = new Label();
            txtLoai = new TextBox();
            txtMua = new TextBox();
            label8 = new Label();
            txtCongDung = new TextBox();
            lblCongDung = new Label();
            txtChatLieu = new TextBox();
            label5 = new Label();
            txtHangSX = new TextBox();
            label3 = new Label();
            txtTenSP = new TextBox();
            lblLoai = new Label();
            label7 = new Label();
            txtMaSP = new TextBox();
            lbMaSP = new Label();
            btnXoa = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabDSSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            tabChiTietSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new Point(26, 12);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Sản phẩm";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDSSP);
            tabControl1.Controls.Add(tabChiTietSP);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 50);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(820, 376);
            tabControl1.TabIndex = 1;
            // 
            // tabDSSP
            // 
            tabDSSP.Controls.Add(btnXoa);
            tabDSSP.Controls.Add(btnThem);
            tabDSSP.Controls.Add(dgvHangHoa);
            tabDSSP.Controls.Add(btnHuy);
            tabDSSP.Controls.Add(txtTimKiem);
            tabDSSP.Controls.Add(lblTimKiem);
            tabDSSP.Location = new Point(4, 24);
            tabDSSP.Margin = new Padding(3, 2, 3, 2);
            tabDSSP.Name = "tabDSSP";
            tabDSSP.Padding = new Padding(3, 2, 3, 2);
            tabDSSP.Size = new Size(812, 348);
            tabDSSP.TabIndex = 0;
            tabDSSP.Text = "Danh sách sản phẩm";
            tabDSSP.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            btnThem.IconColor = Color.Black;
            btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThem.Location = new Point(534, 40);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Location = new Point(10, 64);
            dgvHangHoa.Margin = new Padding(3, 2, 3, 2);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.Size = new Size(682, 194);
            dgvHangHoa.TabIndex = 3;
            dgvHangHoa.CellContentClick += dgvHangHoa_CellContentClick;
            // 
            // btnHuy
            // 
            btnHuy.IconChar = FontAwesome.Sharp.IconChar.None;
            btnHuy.IconColor = Color.Black;
            btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHuy.Location = new Point(658, 42);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(82, 22);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(10, 32);
            txtTimKiem.Margin = new Padding(3, 2, 3, 2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(421, 23);
            txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(7, 10);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(56, 15);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // tabChiTietSP
            // 
            tabChiTietSP.Controls.Add(btnAddImage);
            tabChiTietSP.Controls.Add(txtGhichu);
            tabChiTietSP.Controls.Add(label6);
            tabChiTietSP.Controls.Add(btnHuybo);
            tabChiTietSP.Controls.Add(btnLuu);
            tabChiTietSP.Controls.Add(pictureBox1);
            tabChiTietSP.Controls.Add(txtThoiGianBaoHanh);
            tabChiTietSP.Controls.Add(txtSoLuong);
            tabChiTietSP.Controls.Add(labelSoLuong);
            tabChiTietSP.Controls.Add(txtGiaNhap);
            tabChiTietSP.Controls.Add(label4);
            tabChiTietSP.Controls.Add(txtXuatSu);
            tabChiTietSP.Controls.Add(label2);
            tabChiTietSP.Controls.Add(txtMau);
            tabChiTietSP.Controls.Add(lblMau);
            tabChiTietSP.Controls.Add(txtLoai);
            tabChiTietSP.Controls.Add(txtMua);
            tabChiTietSP.Controls.Add(label8);
            tabChiTietSP.Controls.Add(txtCongDung);
            tabChiTietSP.Controls.Add(lblCongDung);
            tabChiTietSP.Controls.Add(txtChatLieu);
            tabChiTietSP.Controls.Add(label5);
            tabChiTietSP.Controls.Add(txtHangSX);
            tabChiTietSP.Controls.Add(label3);
            tabChiTietSP.Controls.Add(txtTenSP);
            tabChiTietSP.Controls.Add(lblLoai);
            tabChiTietSP.Controls.Add(label7);
            tabChiTietSP.Controls.Add(txtMaSP);
            tabChiTietSP.Controls.Add(lbMaSP);
            tabChiTietSP.Location = new Point(4, 24);
            tabChiTietSP.Margin = new Padding(3, 2, 3, 2);
            tabChiTietSP.Name = "tabChiTietSP";
            tabChiTietSP.Padding = new Padding(3, 2, 3, 2);
            tabChiTietSP.Size = new Size(812, 348);
            tabChiTietSP.TabIndex = 1;
            tabChiTietSP.Text = "Chi tiết sản phẩm";
            tabChiTietSP.UseVisualStyleBackColor = true;
            // 
            // btnAddImage
            // 
            btnAddImage.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAddImage.IconColor = Color.Black;
            btnAddImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddImage.Location = new Point(635, 88);
            btnAddImage.Margin = new Padding(3, 2, 3, 2);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(82, 22);
            btnAddImage.TabIndex = 42;
            btnAddImage.Text = "Thêm ảnh";
            btnAddImage.TextAlign = ContentAlignment.BottomLeft;
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click_1;
            // 
            // txtGhichu
            // 
            txtGhichu.AutoSize = true;
            txtGhichu.Location = new Point(600, 55);
            txtGhichu.Name = "txtGhichu";
            txtGhichu.Size = new Size(0, 15);
            txtGhichu.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 273);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 39;
            label6.Text = "Bảo hành";
            // 
            // btnHuybo
            // 
            btnHuybo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnHuybo.IconColor = Color.Black;
            btnHuybo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHuybo.Location = new Point(710, 317);
            btnHuybo.Margin = new Padding(3, 2, 3, 2);
            btnHuybo.Name = "btnHuybo";
            btnHuybo.Size = new Size(82, 22);
            btnHuybo.TabIndex = 38;
            btnHuybo.Text = "Hủy bỏ";
            btnHuybo.UseVisualStyleBackColor = true;
            btnHuybo.Click += btnHuybo_Click;
            // 
            // btnLuu
            // 
            btnLuu.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLuu.IconColor = Color.Black;
            btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLuu.Location = new Point(598, 317);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 22);
            btnLuu.TabIndex = 37;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(598, 142);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // txtThoiGianBaoHanh
            // 
            txtThoiGianBaoHanh.Location = new Point(37, 290);
            txtThoiGianBaoHanh.Margin = new Padding(3, 2, 3, 2);
            txtThoiGianBaoHanh.Name = "txtThoiGianBaoHanh";
            txtThoiGianBaoHanh.Size = new Size(190, 23);
            txtThoiGianBaoHanh.TabIndex = 35;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(441, 68);
            txtSoLuong.Margin = new Padding(3, 2, 3, 2);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(139, 23);
            txtSoLuong.TabIndex = 32;
            // 
            // labelSoLuong
            // 
            labelSoLuong.AutoSize = true;
            labelSoLuong.Location = new Point(441, 50);
            labelSoLuong.Name = "labelSoLuong";
            labelSoLuong.Size = new Size(54, 15);
            labelSoLuong.TabIndex = 31;
            labelSoLuong.Text = "Số lượng";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(440, 219);
            txtGiaNhap.Margin = new Padding(3, 2, 3, 2);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(138, 23);
            txtGiaNhap.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 202);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 29;
            label4.Text = "Giá nhập";
            // 
            // txtXuatSu
            // 
            txtXuatSu.Location = new Point(440, 142);
            txtXuatSu.Margin = new Padding(3, 2, 3, 2);
            txtXuatSu.Name = "txtXuatSu";
            txtXuatSu.Size = new Size(138, 23);
            txtXuatSu.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 125);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 27;
            label2.Text = "Xuất sứ";
            // 
            // txtMau
            // 
            txtMau.Location = new Point(262, 290);
            txtMau.Margin = new Padding(3, 2, 3, 2);
            txtMau.Name = "txtMau";
            txtMau.Size = new Size(143, 23);
            txtMau.TabIndex = 26;
            // 
            // lblMau
            // 
            lblMau.AutoSize = true;
            lblMau.Location = new Point(262, 273);
            lblMau.Name = "lblMau";
            lblMau.Size = new Size(31, 15);
            lblMau.TabIndex = 25;
            lblMau.Text = "Màu";
            // 
            // txtLoai
            // 
            txtLoai.Location = new Point(38, 142);
            txtLoai.Margin = new Padding(3, 2, 3, 2);
            txtLoai.Name = "txtLoai";
            txtLoai.Size = new Size(188, 23);
            txtLoai.TabIndex = 24;
            // 
            // txtMua
            // 
            txtMua.Location = new Point(262, 219);
            txtMua.Margin = new Padding(3, 2, 3, 2);
            txtMua.Name = "txtMua";
            txtMua.Size = new Size(143, 23);
            txtMua.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(262, 202);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 22;
            label8.Text = "Mùa";
            // 
            // txtCongDung
            // 
            txtCongDung.Location = new Point(262, 142);
            txtCongDung.Margin = new Padding(3, 2, 3, 2);
            txtCongDung.Name = "txtCongDung";
            txtCongDung.Size = new Size(143, 23);
            txtCongDung.TabIndex = 21;
            // 
            // lblCongDung
            // 
            lblCongDung.AutoSize = true;
            lblCongDung.Location = new Point(262, 125);
            lblCongDung.Name = "lblCongDung";
            lblCongDung.Size = new Size(67, 15);
            lblCongDung.TabIndex = 20;
            lblCongDung.Text = "Công dụng";
            // 
            // txtChatLieu
            // 
            txtChatLieu.Location = new Point(441, 290);
            txtChatLieu.Margin = new Padding(3, 2, 3, 2);
            txtChatLieu.Name = "txtChatLieu";
            txtChatLieu.Size = new Size(138, 23);
            txtChatLieu.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 273);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 18;
            label5.Text = "Chất liệu";
            // 
            // txtHangSX
            // 
            txtHangSX.Location = new Point(38, 219);
            txtHangSX.Margin = new Padding(3, 2, 3, 2);
            txtHangSX.Name = "txtHangSX";
            txtHangSX.Size = new Size(188, 23);
            txtHangSX.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 202);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 14;
            label3.Text = "Hãng sản xuất";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(262, 68);
            txtTenSP.Margin = new Padding(3, 2, 3, 2);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(143, 23);
            txtTenSP.TabIndex = 13;
            // 
            // lblLoai
            // 
            lblLoai.AutoSize = true;
            lblLoai.Location = new Point(37, 125);
            lblLoai.Name = "lblLoai";
            lblLoai.Size = new Size(29, 15);
            lblLoai.TabIndex = 2;
            lblLoai.Text = "Loại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 50);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 12;
            label7.Text = "Tên sản phẩm";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(38, 61);
            txtMaSP.Margin = new Padding(3, 2, 3, 2);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(188, 23);
            txtMaSP.TabIndex = 1;
            // 
            // lbMaSP
            // 
            lbMaSP.AutoSize = true;
            lbMaSP.Location = new Point(40, 40);
            lbMaSP.Name = "lbMaSP";
            lbMaSP.Size = new Size(79, 15);
            lbMaSP.TabIndex = 0;
            lbMaSP.Text = "Mã sản phẩm";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(733, 42);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // QuanLySP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 426);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuanLySP";
            Load += QuanLySP_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabDSSP.ResumeLayout(false);
            tabDSSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            tabChiTietSP.ResumeLayout(false);
            tabChiTietSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSoLuong;
        private Label labelSoLuong;
        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabDSSP;
        private TabPage tabChiTietSP;
        private FontAwesome.Sharp.IconButton btnHuy;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private DataGridView dgvHangHoa;
        private FontAwesome.Sharp.IconButton btnThem;
        private Label lbMaSP;
        private TextBox txtMaSP;
        private TextBox txtMua;
        private Label label8;
        private TextBox txtCongDung;
        private Label lblCongDung;
        private TextBox txtChatLieu;
        private Label label5;
        private TextBox txtHangSX;
        private Label label3;
        private TextBox txtTenSP;
        private Label lblLoai;
        private Label label7;
        private TextBox txtLoai;
        private TextBox txtMau;
        private Label lblMau;
        private TextBox txtGiaNhap;
        private Label label4;
        private TextBox txtXuatSu;
        private Label label2;
        private TextBox txtThoiGianBaoHanh;
        private FontAwesome.Sharp.IconButton btnHuybo;
        private FontAwesome.Sharp.IconButton btnLuu;
        private PictureBox pictureBox1;
        private Label label6;
    
        private Label txtGhichu;
        private FontAwesome.Sharp.IconButton btnAddImage;
        private Button btnXoa;
    }
}