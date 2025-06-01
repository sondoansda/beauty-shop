namespace btl.net.Forms
{
    partial class Hoadonban
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoadonban));
            this.txtngayban = new System.Windows.Forms.MaskedTextBox();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.MaskedTextBox();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.labelMaHD = new System.Windows.Forms.Label();
            this.labelNgaynhap = new System.Windows.Forms.Label();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.labelTenNV = new System.Windows.Forms.Label();
            this.labelMaNCC = new System.Windows.Forms.Label();
            this.labelTenNCC = new System.Windows.Forms.Label();
            this.labelDiachi = new System.Windows.Forms.Label();
            this.labelDienthoai = new System.Windows.Forms.Label();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.cbomanv = new System.Windows.Forms.ComboBox();
            this.gbxThongTinChung = new System.Windows.Forms.GroupBox();
            this.labelChuthich = new System.Windows.Forms.Label();
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.labelHDN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.gbxThongTinChung.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtngayban
            // 
            this.txtngayban.Location = new System.Drawing.Point(173, 94);
            this.txtngayban.Mask = "00/00/0000";
            this.txtngayban.Name = "txtngayban";
            this.txtngayban.Size = new System.Drawing.Size(196, 22);
            this.txtngayban.TabIndex = 229;
            this.txtngayban.ValidatingType = typeof(System.DateTime);
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongtien.Location = new System.Drawing.Point(32, 240);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(63, 16);
            this.lbltongtien.TabIndex = 227;
            this.lbltongtien.Text = "Tổng tiền";
            // 
            // txttongtien
            // 
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.Location = new System.Drawing.Point(173, 237);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(196, 22);
            this.txttongtien.TabIndex = 228;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(586, 188);
            this.txtsdt.Mask = "(999) 000-0000";
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(196, 22);
            this.txtsdt.TabIndex = 224;
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(597, 538);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(92, 48);
            this.btnHienthi.TabIndex = 223;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(713, 538);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(92, 48);
            this.btnDong.TabIndex = 222;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(481, 538);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(92, 48);
            this.btnBoqua.TabIndex = 221;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(365, 538);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 48);
            this.btnLuu.TabIndex = 220;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(249, 538);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 48);
            this.btnXoa.TabIndex = 219;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(133, 538);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 48);
            this.btnSua.TabIndex = 218;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 538);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 48);
            this.btnThem.TabIndex = 217;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHD.Location = new System.Drawing.Point(35, 295);
            this.dgvHD.Name = "dgvHD";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.Size = new System.Drawing.Size(747, 198);
            this.dgvHD.TabIndex = 216;
            this.dgvHD.Click += new System.EventHandler(this.dgvHD_Click);
            this.dgvHD.DoubleClick += new System.EventHandler(this.dgvHD_DoubleClick);
            // 
            // labelMaHD
            // 
            this.labelMaHD.AutoSize = true;
            this.labelMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaHD.Location = new System.Drawing.Point(32, 56);
            this.labelMaHD.Name = "labelMaHD";
            this.labelMaHD.Size = new System.Drawing.Size(104, 16);
            this.labelMaHD.TabIndex = 200;
            this.labelMaHD.Text = "Mã hóa đơn bán";
            // 
            // labelNgaynhap
            // 
            this.labelNgaynhap.AutoSize = true;
            this.labelNgaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaynhap.Location = new System.Drawing.Point(32, 99);
            this.labelNgaynhap.Name = "labelNgaynhap";
            this.labelNgaynhap.Size = new System.Drawing.Size(66, 16);
            this.labelNgaynhap.TabIndex = 201;
            this.labelNgaynhap.Text = "Ngày bán";
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNV.Location = new System.Drawing.Point(32, 145);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(86, 16);
            this.labelMaNV.TabIndex = 202;
            this.labelMaNV.Text = "Mã nhân viên";
            // 
            // labelTenNV
            // 
            this.labelTenNV.AutoSize = true;
            this.labelTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNV.Location = new System.Drawing.Point(32, 191);
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Size = new System.Drawing.Size(91, 16);
            this.labelTenNV.TabIndex = 203;
            this.labelTenNV.Text = "Tên nhân viên";
            // 
            // labelMaNCC
            // 
            this.labelMaNCC.AutoSize = true;
            this.labelMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNCC.Location = new System.Drawing.Point(445, 54);
            this.labelMaNCC.Name = "labelMaNCC";
            this.labelMaNCC.Size = new System.Drawing.Size(98, 16);
            this.labelMaNCC.TabIndex = 204;
            this.labelMaNCC.Text = "Mã khách hàng";
            // 
            // labelTenNCC
            // 
            this.labelTenNCC.AutoSize = true;
            this.labelTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNCC.Location = new System.Drawing.Point(445, 97);
            this.labelTenNCC.Name = "labelTenNCC";
            this.labelTenNCC.Size = new System.Drawing.Size(103, 16);
            this.labelTenNCC.TabIndex = 205;
            this.labelTenNCC.Text = "Tên khách hàng";
            // 
            // labelDiachi
            // 
            this.labelDiachi.AutoSize = true;
            this.labelDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiachi.Location = new System.Drawing.Point(445, 143);
            this.labelDiachi.Name = "labelDiachi";
            this.labelDiachi.Size = new System.Drawing.Size(47, 16);
            this.labelDiachi.TabIndex = 206;
            this.labelDiachi.Text = "Địa chỉ";
            // 
            // labelDienthoai
            // 
            this.labelDienthoai.AutoSize = true;
            this.labelDienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDienthoai.Location = new System.Drawing.Point(445, 189);
            this.labelDienthoai.Name = "labelDienthoai";
            this.labelDienthoai.Size = new System.Drawing.Size(66, 16);
            this.labelDienthoai.TabIndex = 207;
            this.labelDienthoai.Text = "Điện thoại";
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahoadon.Location = new System.Drawing.Point(173, 53);
            this.txtmahoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(196, 22);
            this.txtmahoadon.TabIndex = 208;
            // 
            // txttennv
            // 
            this.txttennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennv.Location = new System.Drawing.Point(173, 186);
            this.txttennv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttennv.Name = "txttennv";
            this.txttennv.ReadOnly = true;
            this.txttennv.Size = new System.Drawing.Size(196, 22);
            this.txttennv.TabIndex = 211;
            this.txttennv.TextChanged += new System.EventHandler(this.txttennv_TextChanged);
            // 
            // txttenkhach
            // 
            this.txttenkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkhach.Location = new System.Drawing.Point(586, 95);
            this.txttenkhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(196, 22);
            this.txttenkhach.TabIndex = 213;
            this.txttenkhach.TextChanged += new System.EventHandler(this.txttenkhach_TextChanged);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(586, 140);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(196, 22);
            this.txtdiachi.TabIndex = 214;
            // 
            // cbomanv
            // 
            this.cbomanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomanv.FormattingEnabled = true;
            this.cbomanv.Location = new System.Drawing.Point(173, 140);
            this.cbomanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbomanv.Name = "cbomanv";
            this.cbomanv.Size = new System.Drawing.Size(196, 24);
            this.cbomanv.TabIndex = 210;
            this.cbomanv.TextChanged += new System.EventHandler(this.cbomanv_TextChanged);
            // 
            // gbxThongTinChung
            // 
            this.gbxThongTinChung.Controls.Add(this.labelChuthich);
            this.gbxThongTinChung.Controls.Add(this.txtmakhach);
            this.gbxThongTinChung.Controls.Add(this.txtngayban);
            this.gbxThongTinChung.Controls.Add(this.lbltongtien);
            this.gbxThongTinChung.Controls.Add(this.txttongtien);
            this.gbxThongTinChung.Controls.Add(this.txtsdt);
            this.gbxThongTinChung.Controls.Add(this.btnHienthi);
            this.gbxThongTinChung.Controls.Add(this.btnDong);
            this.gbxThongTinChung.Controls.Add(this.btnBoqua);
            this.gbxThongTinChung.Controls.Add(this.btnLuu);
            this.gbxThongTinChung.Controls.Add(this.btnXoa);
            this.gbxThongTinChung.Controls.Add(this.btnSua);
            this.gbxThongTinChung.Controls.Add(this.btnThem);
            this.gbxThongTinChung.Controls.Add(this.dgvHD);
            this.gbxThongTinChung.Controls.Add(this.labelMaHD);
            this.gbxThongTinChung.Controls.Add(this.labelNgaynhap);
            this.gbxThongTinChung.Controls.Add(this.labelMaNV);
            this.gbxThongTinChung.Controls.Add(this.labelTenNV);
            this.gbxThongTinChung.Controls.Add(this.labelMaNCC);
            this.gbxThongTinChung.Controls.Add(this.labelTenNCC);
            this.gbxThongTinChung.Controls.Add(this.labelDiachi);
            this.gbxThongTinChung.Controls.Add(this.labelDienthoai);
            this.gbxThongTinChung.Controls.Add(this.txtmahoadon);
            this.gbxThongTinChung.Controls.Add(this.txttennv);
            this.gbxThongTinChung.Controls.Add(this.txttenkhach);
            this.gbxThongTinChung.Controls.Add(this.txtdiachi);
            this.gbxThongTinChung.Controls.Add(this.cbomanv);
            this.gbxThongTinChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxThongTinChung.Location = new System.Drawing.Point(21, 91);
            this.gbxThongTinChung.Name = "gbxThongTinChung";
            this.gbxThongTinChung.Size = new System.Drawing.Size(817, 597);
            this.gbxThongTinChung.TabIndex = 259;
            this.gbxThongTinChung.TabStop = false;
            this.gbxThongTinChung.Text = "Thông tin hóa đơn";
            // 
            // labelChuthich
            // 
            this.labelChuthich.AutoSize = true;
            this.labelChuthich.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChuthich.ForeColor = System.Drawing.Color.Red;
            this.labelChuthich.Location = new System.Drawing.Point(31, 496);
            this.labelChuthich.Name = "labelChuthich";
            this.labelChuthich.Size = new System.Drawing.Size(156, 20);
            this.labelChuthich.TabIndex = 260;
            this.labelChuthich.Text = "Nhấn 2 lần để xem chi tiết";
            // 
            // txtmakhach
            // 
            this.txtmakhach.Location = new System.Drawing.Point(586, 53);
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(196, 22);
            this.txtmakhach.TabIndex = 230;
            this.txtmakhach.Leave += new System.EventHandler(this.txtmakhach_Leave);
            // 
            // labelHDN
            // 
            this.labelHDN.AutoSize = true;
            this.labelHDN.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHDN.Location = new System.Drawing.Point(206, 27);
            this.labelHDN.Name = "labelHDN";
            this.labelHDN.Size = new System.Drawing.Size(436, 46);
            this.labelHDN.TabIndex = 258;
            this.labelHDN.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // Hoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(859, 700);
            this.Controls.Add(this.gbxThongTinChung);
            this.Controls.Add(this.labelHDN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hoadonban";
            this.Text = "Hoadonban";
            this.Load += new System.EventHandler(this.Hoadonban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.gbxThongTinChung.ResumeLayout(false);
            this.gbxThongTinChung.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtngayban;
        private System.Windows.Forms.Label lbltongtien;
        public System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.MaskedTextBox txtsdt;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Label labelMaHD;
        private System.Windows.Forms.Label labelNgaynhap;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label labelTenNV;
        private System.Windows.Forms.Label labelMaNCC;
        private System.Windows.Forms.Label labelTenNCC;
        private System.Windows.Forms.Label labelDiachi;
        private System.Windows.Forms.Label labelDienthoai;
        public System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.ComboBox cbomanv;
        private System.Windows.Forms.GroupBox gbxThongTinChung;
        private System.Windows.Forms.Label labelHDN;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.Label labelChuthich;
    }
}