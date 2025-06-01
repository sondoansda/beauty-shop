namespace btl.net.Forms
{
    partial class frmHanghoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHanghoa));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.cboMaCongDung = new System.Windows.Forms.ComboBox();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.lblMaCongDung = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.btnMo = new System.Windows.Forms.Button();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.btnHienThiDS = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGiaNhap = new System.Windows.Forms.Label();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.lblDMSanPham = new System.Windows.Forms.Label();
            this.gbxSanPham = new System.Windows.Forms.GroupBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.gbxSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(482, 561);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(66, 32);
            this.btnTimKiem.TabIndex = 82;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(402, 561);
            this.btnBoQua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(66, 32);
            this.btnBoQua.TabIndex = 81;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(320, 561);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 32);
            this.btnLuu.TabIndex = 80;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(647, 561);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(66, 32);
            this.btnDong.TabIndex = 84;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cboMaCongDung
            // 
            this.cboMaCongDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaCongDung.FormattingEnabled = true;
            this.cboMaCongDung.Location = new System.Drawing.Point(134, 219);
            this.cboMaCongDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaCongDung.Name = "cboMaCongDung";
            this.cboMaCongDung.Size = new System.Drawing.Size(183, 21);
            this.cboMaCongDung.TabIndex = 52;
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSanPham.Location = new System.Drawing.Point(42, 28);
            this.lblMaSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(59, 15);
            this.lblMaSanPham.TabIndex = 38;
            this.lblMaSanPham.Text = "Mã hàng ";
            // 
            // lblMaCongDung
            // 
            this.lblMaCongDung.AutoSize = true;
            this.lblMaCongDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCongDung.Location = new System.Drawing.Point(42, 221);
            this.lblMaCongDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaCongDung.Name = "lblMaCongDung";
            this.lblMaCongDung.Size = new System.Drawing.Size(70, 15);
            this.lblMaCongDung.TabIndex = 44;
            this.lblMaCongDung.Text = "Công dụng:";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSanPham.Location = new System.Drawing.Point(42, 59);
            this.lblTenSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(86, 15);
            this.lblTenSanPham.TabIndex = 39;
            this.lblTenSanPham.Text = "Tên hàng hóa ";
            // 
            // btnMo
            // 
            this.btnMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMo.Location = new System.Drawing.Point(659, 214);
            this.btnMo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(43, 28);
            this.btnMo.TabIndex = 54;
            this.btnMo.Text = "Mở";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSanPham.Location = new System.Drawing.Point(134, 25);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(183, 19);
            this.txtMaSanPham.TabIndex = 46;
            // 
            // btnHienThiDS
            // 
            this.btnHienThiDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiDS.Location = new System.Drawing.Point(562, 561);
            this.btnHienThiDS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHienThiDS.Name = "btnHienThiDS";
            this.btnHienThiDS.Size = new System.Drawing.Size(71, 32);
            this.btnHienThiDS.TabIndex = 83;
            this.btnHienThiDS.Text = "Hiển thị";
            this.btnHienThiDS.UseVisualStyleBackColor = true;
            this.btnHienThiDS.Click += new System.EventHandler(this.btnHienThiDS_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(154, 561);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(66, 32);
            this.btnSua.TabIndex = 78;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(237, 561);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 32);
            this.btnXoa.TabIndex = 79;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtAnh
            // 
            this.txtAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnh.Location = new System.Drawing.Point(476, 221);
            this.txtAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(167, 19);
            this.txtAnh.TabIndex = 53;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Location = new System.Drawing.Point(134, 57);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(183, 19);
            this.txtTenSanPham.TabIndex = 47;
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnh.Location = new System.Drawing.Point(421, 224);
            this.lblAnh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(31, 15);
            this.lblAnh.TabIndex = 45;
            this.lblAnh.Text = "Ảnh:";
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoai.Location = new System.Drawing.Point(42, 93);
            this.lblMaLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(34, 15);
            this.lblMaLoai.TabIndex = 40;
            this.lblMaLoai.Text = "Loại:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(42, 190);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(59, 15);
            this.lblSoLuong.TabIndex = 43;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGiaNhap
            // 
            this.lblDonGiaNhap.AutoSize = true;
            this.lblDonGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGiaNhap.Location = new System.Drawing.Point(42, 125);
            this.lblDonGiaNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonGiaNhap.Name = "lblDonGiaNhap";
            this.lblDonGiaNhap.Size = new System.Drawing.Size(84, 15);
            this.lblDonGiaNhap.TabIndex = 41;
            this.lblDonGiaNhap.Text = "Đơn giá nhập:";
            // 
            // lblDonGiaBan
            // 
            this.lblDonGiaBan.AutoSize = true;
            this.lblDonGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGiaBan.Location = new System.Drawing.Point(42, 157);
            this.lblDonGiaBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(77, 15);
            this.lblDonGiaBan.TabIndex = 42;
            this.lblDonGiaBan.Text = "Đơn giá bán:";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaBan.Location = new System.Drawing.Point(134, 154);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.ReadOnly = true;
            this.txtDonGiaBan.Size = new System.Drawing.Size(183, 19);
            this.txtDonGiaBan.TabIndex = 50;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(134, 188);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(183, 19);
            this.txtSoLuong.TabIndex = 51;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaNhap.Location = new System.Drawing.Point(134, 123);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(183, 19);
            this.txtDonGiaNhap.TabIndex = 49;
            this.txtDonGiaNhap.TextChanged += new System.EventHandler(this.txtDonGiaNhap_TextChanged);
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(134, 90);
            this.cboMaLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(183, 21);
            this.cboMaLoai.TabIndex = 48;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(73, 561);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(66, 32);
            this.btnThem.TabIndex = 77;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToOrderColumns = true;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(59, 330);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(675, 195);
            this.dgvSanPham.TabIndex = 76;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // lblDMSanPham
            // 
            this.lblDMSanPham.AutoSize = true;
            this.lblDMSanPham.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMSanPham.Location = new System.Drawing.Point(231, 16);
            this.lblDMSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDMSanPham.Name = "lblDMSanPham";
            this.lblDMSanPham.Size = new System.Drawing.Size(375, 37);
            this.lblDMSanPham.TabIndex = 74;
            this.lblDMSanPham.Text = "DANH MỤC HÀNG HÓA ";
            // 
            // gbxSanPham
            // 
            this.gbxSanPham.Controls.Add(this.picAnh);
            this.gbxSanPham.Controls.Add(this.cboMaCongDung);
            this.gbxSanPham.Controls.Add(this.lblMaSanPham);
            this.gbxSanPham.Controls.Add(this.lblMaCongDung);
            this.gbxSanPham.Controls.Add(this.lblTenSanPham);
            this.gbxSanPham.Controls.Add(this.btnMo);
            this.gbxSanPham.Controls.Add(this.txtMaSanPham);
            this.gbxSanPham.Controls.Add(this.txtAnh);
            this.gbxSanPham.Controls.Add(this.txtTenSanPham);
            this.gbxSanPham.Controls.Add(this.lblAnh);
            this.gbxSanPham.Controls.Add(this.lblMaLoai);
            this.gbxSanPham.Controls.Add(this.lblSoLuong);
            this.gbxSanPham.Controls.Add(this.lblDonGiaNhap);
            this.gbxSanPham.Controls.Add(this.lblDonGiaBan);
            this.gbxSanPham.Controls.Add(this.txtDonGiaBan);
            this.gbxSanPham.Controls.Add(this.txtSoLuong);
            this.gbxSanPham.Controls.Add(this.txtDonGiaNhap);
            this.gbxSanPham.Controls.Add(this.cboMaLoai);
            this.gbxSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSanPham.Location = new System.Drawing.Point(32, 67);
            this.gbxSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSanPham.Name = "gbxSanPham";
            this.gbxSanPham.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSanPham.Size = new System.Drawing.Size(735, 249);
            this.gbxSanPham.TabIndex = 75;
            this.gbxSanPham.TabStop = false;
            this.gbxSanPham.Text = "Thông tin chi tiết";
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(485, 24);
            this.picAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(178, 171);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 83;
            this.picAnh.TabStop = false;
            // 
            // frmHanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHienThiDS);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.lblDMSanPham);
            this.Controls.Add(this.gbxSanPham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHanghoa";
            this.Text = "Hanghoa";
            this.Load += new System.EventHandler(this.frmHanghoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.gbxSanPham.ResumeLayout(false);
            this.gbxSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.ComboBox cboMaCongDung;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.Label lblMaCongDung;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Button btnHienThiDS;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGiaNhap;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.ComboBox cboMaLoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Label lblDMSanPham;
        private System.Windows.Forms.GroupBox gbxSanPham;
    }
}