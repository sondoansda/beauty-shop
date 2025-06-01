namespace btl.net.Forms
{
    partial class Timkiemhoadonban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timkiemhoadonban));
            this.grbKhoangNgay = new System.Windows.Forms.GroupBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.cboMaKhachHang = new System.Windows.Forms.ComboBox();
            this.rdoTheoKhoang = new System.Windows.Forms.RadioButton();
            this.btnDong = new System.Windows.Forms.Button();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.rdoTheoNgay = new System.Windows.Forms.RadioButton();
            this.dgvTimKiemHDB = new System.Windows.Forms.DataGridView();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboMaHDB = new System.Windows.Forms.ComboBox();
            this.lblTKHoaDonBan = new System.Windows.Forms.Label();
            this.lblMaHDB = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.labelChuthich = new System.Windows.Forms.Label();
            this.grbKhoangNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // grbKhoangNgay
            // 
            this.grbKhoangNgay.Controls.Add(this.dtpNgayKT);
            this.grbKhoangNgay.Controls.Add(this.lblDenNgay);
            this.grbKhoangNgay.Controls.Add(this.dtpNgayBD);
            this.grbKhoangNgay.Controls.Add(this.lblTuNgay);
            this.grbKhoangNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKhoangNgay.Location = new System.Drawing.Point(623, 150);
            this.grbKhoangNgay.Name = "grbKhoangNgay";
            this.grbKhoangNgay.Size = new System.Drawing.Size(368, 38);
            this.grbKhoangNgay.TabIndex = 171;
            this.grbKhoangNgay.TabStop = false;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(222, 11);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(139, 22);
            this.dtpNgayKT.TabIndex = 151;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(180, 14);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(31, 16);
            this.lblDenNgay.TabIndex = 147;
            this.lblDenNgay.Text = "Đến";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(35, 9);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(137, 22);
            this.dtpNgayBD.TabIndex = 150;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(5, 14);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(23, 16);
            this.lblTuNgay.TabIndex = 147;
            this.lblTuNgay.Text = "Từ";
            // 
            // cboMaKhachHang
            // 
            this.cboMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKhachHang.FormattingEnabled = true;
            this.cboMaKhachHang.Location = new System.Drawing.Point(212, 207);
            this.cboMaKhachHang.Name = "cboMaKhachHang";
            this.cboMaKhachHang.Size = new System.Drawing.Size(175, 24);
            this.cboMaKhachHang.TabIndex = 169;
            // 
            // rdoTheoKhoang
            // 
            this.rdoTheoKhoang.AutoSize = true;
            this.rdoTheoKhoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTheoKhoang.Location = new System.Drawing.Point(494, 162);
            this.rdoTheoKhoang.Name = "rdoTheoKhoang";
            this.rdoTheoKhoang.Size = new System.Drawing.Size(111, 20);
            this.rdoTheoKhoang.TabIndex = 172;
            this.rdoTheoKhoang.TabStop = true;
            this.rdoTheoKhoang.Text = "Theo khoảng:";
            this.rdoTheoKhoang.UseVisualStyleBackColor = true;
            this.rdoTheoKhoang.CheckedChanged += new System.EventHandler(this.rdoTheoKhoang_CheckedChanged);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(936, 613);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(88, 40);
            this.btnDong.TabIndex = 181;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(212, 161);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(175, 24);
            this.cboMaNhanVien.TabIndex = 168;
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(922, 250);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(102, 40);
            this.btnTimLai.TabIndex = 180;
            this.btnTimLai.Text = "Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // rdoTheoNgay
            // 
            this.rdoTheoNgay.AutoSize = true;
            this.rdoTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTheoNgay.Location = new System.Drawing.Point(494, 115);
            this.rdoTheoNgay.Name = "rdoTheoNgay";
            this.rdoTheoNgay.Size = new System.Drawing.Size(96, 20);
            this.rdoTheoNgay.TabIndex = 170;
            this.rdoTheoNgay.TabStop = true;
            this.rdoTheoNgay.Text = "Theo ngày:";
            this.rdoTheoNgay.UseVisualStyleBackColor = true;
            this.rdoTheoNgay.CheckedChanged += new System.EventHandler(this.rdoTheoNgay_CheckedChanged);
            // 
            // dgvTimKiemHDB
            // 
            this.dgvTimKiemHDB.AllowUserToOrderColumns = true;
            this.dgvTimKiemHDB.ColumnHeadersHeight = 29;
            this.dgvTimKiemHDB.Location = new System.Drawing.Point(51, 315);
            this.dgvTimKiemHDB.Name = "dgvTimKiemHDB";
            this.dgvTimKiemHDB.RowHeadersWidth = 51;
            this.dgvTimKiemHDB.RowTemplate.Height = 24;
            this.dgvTimKiemHDB.Size = new System.Drawing.Size(973, 267);
            this.dgvTimKiemHDB.TabIndex = 178;
            this.dgvTimKiemHDB.DoubleClick += new System.EventHandler(this.dgvTimKiemHDB_DoubleClick);
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(623, 115);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(172, 22);
            this.dtpNgayBan.TabIndex = 174;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(800, 250);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(102, 40);
            this.btnTimKiem.TabIndex = 179;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboMaHDB
            // 
            this.cboMaHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHDB.FormattingEnabled = true;
            this.cboMaHDB.Location = new System.Drawing.Point(212, 116);
            this.cboMaHDB.Name = "cboMaHDB";
            this.cboMaHDB.Size = new System.Drawing.Size(175, 24);
            this.cboMaHDB.TabIndex = 167;
            // 
            // lblTKHoaDonBan
            // 
            this.lblTKHoaDonBan.AutoSize = true;
            this.lblTKHoaDonBan.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKHoaDonBan.Location = new System.Drawing.Point(270, 25);
            this.lblTKHoaDonBan.Name = "lblTKHoaDonBan";
            this.lblTKHoaDonBan.Size = new System.Drawing.Size(496, 46);
            this.lblTKHoaDonBan.TabIndex = 176;
            this.lblTKHoaDonBan.Text = "TÌM KIẾM HÓA ĐƠN BÁN";
            // 
            // lblMaHDB
            // 
            this.lblMaHDB.AutoSize = true;
            this.lblMaHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHDB.Location = new System.Drawing.Point(80, 119);
            this.lblMaHDB.Name = "lblMaHDB";
            this.lblMaHDB.Size = new System.Drawing.Size(107, 16);
            this.lblMaHDB.TabIndex = 164;
            this.lblMaHDB.Text = "Mã hóa đơn bán:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(516, 210);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(66, 16);
            this.lblTongTien.TabIndex = 173;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(80, 164);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(89, 16);
            this.lblMaNhanVien.TabIndex = 165;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(623, 207);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(172, 22);
            this.txtTongTien.TabIndex = 175;
            this.txtTongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongTien_KeyPress);
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.Location = new System.Drawing.Point(80, 210);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(101, 16);
            this.lblMaKhachHang.TabIndex = 166;
            this.lblMaKhachHang.Text = "Mã khách hàng:";
            // 
            // labelChuthich
            // 
            this.labelChuthich.AutoSize = true;
            this.labelChuthich.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChuthich.ForeColor = System.Drawing.Color.Red;
            this.labelChuthich.Location = new System.Drawing.Point(47, 595);
            this.labelChuthich.Name = "labelChuthich";
            this.labelChuthich.Size = new System.Drawing.Size(156, 20);
            this.labelChuthich.TabIndex = 162;
            this.labelChuthich.Text = "Nhấn 2 lần để xem chi tiết";
            // 
            // Timkiemhoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1074, 658);
            this.Controls.Add(this.labelChuthich);
            this.Controls.Add(this.grbKhoangNgay);
            this.Controls.Add(this.cboMaKhachHang);
            this.Controls.Add(this.rdoTheoKhoang);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.cboMaNhanVien);
            this.Controls.Add(this.btnTimLai);
            this.Controls.Add(this.rdoTheoNgay);
            this.Controls.Add(this.dgvTimKiemHDB);
            this.Controls.Add(this.dtpNgayBan);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboMaHDB);
            this.Controls.Add(this.lblTKHoaDonBan);
            this.Controls.Add(this.lblMaHDB);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblMaKhachHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Timkiemhoadonban";
            this.Text = "Timkiemhoadonban";
            this.Load += new System.EventHandler(this.Timkiemhoadonnhap_Load);
            this.grbKhoangNgay.ResumeLayout(false);
            this.grbKhoangNgay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhoangNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.ComboBox cboMaKhachHang;
        private System.Windows.Forms.RadioButton rdoTheoKhoang;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.RadioButton rdoTheoNgay;
        private System.Windows.Forms.DataGridView dgvTimKiemHDB;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboMaHDB;
        private System.Windows.Forms.Label lblTKHoaDonBan;
        private System.Windows.Forms.Label lblMaHDB;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label labelChuthich;
    }
}