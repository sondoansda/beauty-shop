namespace btl.net.Forms
{
    partial class Timkiemhoadonnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timkiemhoadonnhap));
            this.grbKhoangNgay = new System.Windows.Forms.GroupBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblTKHoaDonNhap = new System.Windows.Forms.Label();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvTimKiemHDN = new System.Windows.Forms.DataGridView();
            this.lblMaHDN = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.labelChuthich = new System.Windows.Forms.Label();
            this.rdoTheoKhoang = new System.Windows.Forms.RadioButton();
            this.rdoTheoNgay = new System.Windows.Forms.RadioButton();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.cboMaHDN = new System.Windows.Forms.ComboBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.grbKhoangNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // grbKhoangNgay
            // 
            this.grbKhoangNgay.Controls.Add(this.dtpNgayKT);
            this.grbKhoangNgay.Controls.Add(this.lblDenNgay);
            this.grbKhoangNgay.Controls.Add(this.dtpNgayBD);
            this.grbKhoangNgay.Controls.Add(this.lblTuNgay);
            this.grbKhoangNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKhoangNgay.Location = new System.Drawing.Point(600, 160);
            this.grbKhoangNgay.Name = "grbKhoangNgay";
            this.grbKhoangNgay.Size = new System.Drawing.Size(322, 38);
            this.grbKhoangNgay.TabIndex = 156;
            this.grbKhoangNgay.TabStop = false;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(194, 11);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(122, 22);
            this.dtpNgayKT.TabIndex = 135;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenNgay.Location = new System.Drawing.Point(158, 14);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(30, 16);
            this.lblDenNgay.TabIndex = 131;
            this.lblDenNgay.Text = "Đến";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(32, 11);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(120, 22);
            this.dtpNgayBD.TabIndex = 134;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(4, 14);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(23, 16);
            this.lblTuNgay.TabIndex = 131;
            this.lblTuNgay.Text = "Từ";
            // 
            // lblTKHoaDonNhap
            // 
            this.lblTKHoaDonNhap.AutoSize = true;
            this.lblTKHoaDonNhap.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKHoaDonNhap.Location = new System.Drawing.Point(238, 37);
            this.lblTKHoaDonNhap.Name = "lblTKHoaDonNhap";
            this.lblTKHoaDonNhap.Size = new System.Drawing.Size(521, 46);
            this.lblTKHoaDonNhap.TabIndex = 160;
            this.lblTKHoaDonNhap.Text = "TÌM KIẾM HÓA ĐƠN NHẬP";
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(837, 274);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(89, 40);
            this.btnTimLai.TabIndex = 164;
            this.btnTimLai.Text = "Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(732, 274);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(89, 40);
            this.btnTimKiem.TabIndex = 163;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvTimKiemHDN
            // 
            this.dgvTimKiemHDN.AllowUserToOrderColumns = true;
            this.dgvTimKiemHDN.ColumnHeadersHeight = 29;
            this.dgvTimKiemHDN.Location = new System.Drawing.Point(74, 331);
            this.dgvTimKiemHDN.Name = "dgvTimKiemHDN";
            this.dgvTimKiemHDN.RowHeadersWidth = 51;
            this.dgvTimKiemHDN.RowTemplate.Height = 24;
            this.dgvTimKiemHDN.Size = new System.Drawing.Size(852, 272);
            this.dgvTimKiemHDN.TabIndex = 162;
            this.dgvTimKiemHDN.DoubleClick += new System.EventHandler(this.dgvTimKiemHDN_DoubleClick);
            // 
            // lblMaHDN
            // 
            this.lblMaHDN.AutoSize = true;
            this.lblMaHDN.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHDN.Location = new System.Drawing.Point(71, 127);
            this.lblMaHDN.Name = "lblMaHDN";
            this.lblMaHDN.Size = new System.Drawing.Size(113, 16);
            this.lblMaHDN.TabIndex = 148;
            this.lblMaHDN.Text = "Mã hóa đơn nhập:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(849, 644);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(77, 40);
            this.btnDong.TabIndex = 165;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(71, 172);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(87, 16);
            this.lblMaNhanVien.TabIndex = 149;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.Location = new System.Drawing.Point(71, 218);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(111, 16);
            this.lblMaNCC.TabIndex = 150;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(600, 217);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(151, 22);
            this.txtTongTien.TabIndex = 159;
            this.txtTongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongTien_KeyPress);
            // 
            // labelChuthich
            // 
            this.labelChuthich.AutoSize = true;
            this.labelChuthich.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChuthich.ForeColor = System.Drawing.Color.Red;
            this.labelChuthich.Location = new System.Drawing.Point(70, 618);
            this.labelChuthich.Name = "labelChuthich";
            this.labelChuthich.Size = new System.Drawing.Size(156, 20);
            this.labelChuthich.TabIndex = 161;
            this.labelChuthich.Text = "Nhấn 2 lần để xem chi tiết";
            // 
            // rdoTheoKhoang
            // 
            this.rdoTheoKhoang.AutoSize = true;
            this.rdoTheoKhoang.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTheoKhoang.Location = new System.Drawing.Point(487, 172);
            this.rdoTheoKhoang.Name = "rdoTheoKhoang";
            this.rdoTheoKhoang.Size = new System.Drawing.Size(106, 20);
            this.rdoTheoKhoang.TabIndex = 155;
            this.rdoTheoKhoang.TabStop = true;
            this.rdoTheoKhoang.Text = "Theo khoảng:";
            this.rdoTheoKhoang.UseVisualStyleBackColor = true;
            this.rdoTheoKhoang.CheckedChanged += new System.EventHandler(this.rdoTheoKhoang_CheckedChanged);
            // 
            // rdoTheoNgay
            // 
            this.rdoTheoNgay.AutoSize = true;
            this.rdoTheoNgay.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTheoNgay.Location = new System.Drawing.Point(487, 125);
            this.rdoTheoNgay.Name = "rdoTheoNgay";
            this.rdoTheoNgay.Size = new System.Drawing.Size(92, 20);
            this.rdoTheoNgay.TabIndex = 154;
            this.rdoTheoNgay.TabStop = true;
            this.rdoTheoNgay.Text = "Theo ngày:";
            this.rdoTheoNgay.UseVisualStyleBackColor = true;
            this.rdoTheoNgay.CheckedChanged += new System.EventHandler(this.rdoTheoNgay_CheckedChanged);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(600, 125);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(151, 22);
            this.dtpNgayNhap.TabIndex = 158;
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(193, 215);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(159, 24);
            this.cboMaNCC.TabIndex = 153;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(193, 169);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(159, 24);
            this.cboMaNhanVien.TabIndex = 152;
            // 
            // cboMaHDN
            // 
            this.cboMaHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaHDN.FormattingEnabled = true;
            this.cboMaHDN.Location = new System.Drawing.Point(193, 124);
            this.cboMaHDN.Name = "cboMaHDN";
            this.cboMaHDN.Size = new System.Drawing.Size(159, 24);
            this.cboMaHDN.TabIndex = 151;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(505, 218);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(64, 16);
            this.lblTongTien.TabIndex = 157;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // Timkiemhoadonnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1021, 713);
            this.Controls.Add(this.grbKhoangNgay);
            this.Controls.Add(this.lblTKHoaDonNhap);
            this.Controls.Add(this.btnTimLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvTimKiemHDN);
            this.Controls.Add(this.lblMaHDN);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.lblMaNCC);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.labelChuthich);
            this.Controls.Add(this.rdoTheoKhoang);
            this.Controls.Add(this.rdoTheoNgay);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.cboMaNCC);
            this.Controls.Add(this.cboMaNhanVien);
            this.Controls.Add(this.cboMaHDN);
            this.Controls.Add(this.lblTongTien);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Timkiemhoadonnhap";
            this.Text = "Timkiemhoadonnhap";
            this.Load += new System.EventHandler(this.Timkiemhoadonnhap_Load);
            this.grbKhoangNgay.ResumeLayout(false);
            this.grbKhoangNgay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhoangNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblTKHoaDonNhap;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvTimKiemHDN;
        private System.Windows.Forms.Label lblMaHDN;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label labelChuthich;
        private System.Windows.Forms.RadioButton rdoTheoKhoang;
        private System.Windows.Forms.RadioButton rdoTheoNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.ComboBox cboMaHDN;
        private System.Windows.Forms.Label lblTongTien;
    }
}