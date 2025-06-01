namespace btl.net.Forms
{
    partial class Khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.mskSodt = new System.Windows.Forms.MaskedTextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.lblSodt = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTenncc = new System.Windows.Forms.Label();
            this.lblMancc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttksdt = new System.Windows.Forms.TextBox();
            this.chksdt = new System.Windows.Forms.CheckBox();
            this.btndatlai = new System.Windows.Forms.Button();
            this.txttktenkhach = new System.Windows.Forms.TextBox();
            this.chktenkhach = new System.Windows.Forms.CheckBox();
            this.txttkmakhach = new System.Windows.Forms.TextBox();
            this.chkmakhach = new System.Windows.Forms.CheckBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(490, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 46);
            this.label1.TabIndex = 36;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHienthi);
            this.groupBox1.Controls.Add(this.mskSodt);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnBoqua);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTenkhach);
            this.groupBox1.Controls.Add(this.txtMakhach);
            this.groupBox1.Controls.Add(this.dgvKhach);
            this.groupBox1.Controls.Add(this.lblSodt);
            this.groupBox1.Controls.Add(this.lblDiachi);
            this.groupBox1.Controls.Add(this.lblTenncc);
            this.groupBox1.Controls.Add(this.lblMancc);
            this.groupBox1.Location = new System.Drawing.Point(320, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 474);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(699, 392);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(93, 49);
            this.btnHienthi.TabIndex = 70;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // mskSodt
            // 
            this.mskSodt.Location = new System.Drawing.Point(632, 96);
            this.mskSodt.Mask = "(999) 000-0000";
            this.mskSodt.Name = "mskSodt";
            this.mskSodt.Size = new System.Drawing.Size(247, 22);
            this.mskSodt.TabIndex = 68;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(824, 392);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(92, 49);
            this.btnDong.TabIndex = 67;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(574, 392);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(93, 49);
            this.btnBoqua.TabIndex = 66;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(441, 392);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 49);
            this.btnLuu.TabIndex = 65;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(309, 392);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 49);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(173, 392);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 49);
            this.btnSua.TabIndex = 63;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(34, 392);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 49);
            this.btnThem.TabIndex = 62;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(632, 35);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(248, 22);
            this.txtDiachi.TabIndex = 61;
            this.txtDiachi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiachi_KeyUp);
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Location = new System.Drawing.Point(170, 93);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(248, 22);
            this.txtTenkhach.TabIndex = 60;
            this.txtTenkhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenkhach_KeyUp);
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(170, 32);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(248, 22);
            this.txtMakhach.TabIndex = 59;
            this.txtMakhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMakhach_KeyUp);
            // 
            // dgvKhach
            // 
            this.dgvKhach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Location = new System.Drawing.Point(55, 147);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.RowHeadersWidth = 51;
            this.dgvKhach.RowTemplate.Height = 24;
            this.dgvKhach.Size = new System.Drawing.Size(825, 198);
            this.dgvKhach.TabIndex = 58;
            this.dgvKhach.Click += new System.EventHandler(this.dgvKhach_Click);
            // 
            // lblSodt
            // 
            this.lblSodt.AutoSize = true;
            this.lblSodt.Location = new System.Drawing.Point(526, 99);
            this.lblSodt.Name = "lblSodt";
            this.lblSodt.Size = new System.Drawing.Size(85, 16);
            this.lblSodt.TabIndex = 57;
            this.lblSodt.Text = "Số điện thoại";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(526, 41);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(50, 16);
            this.lblDiachi.TabIndex = 56;
            this.lblDiachi.Text = "Địa chỉ:";
            // 
            // lblTenncc
            // 
            this.lblTenncc.AutoSize = true;
            this.lblTenncc.Location = new System.Drawing.Point(52, 96);
            this.lblTenncc.Name = "lblTenncc";
            this.lblTenncc.Size = new System.Drawing.Size(73, 16);
            this.lblTenncc.TabIndex = 55;
            this.lblTenncc.Text = "Tên khách:";
            // 
            // lblMancc
            // 
            this.lblMancc.AutoSize = true;
            this.lblMancc.Location = new System.Drawing.Point(52, 35);
            this.lblMancc.Name = "lblMancc";
            this.lblMancc.Size = new System.Drawing.Size(65, 16);
            this.lblMancc.TabIndex = 54;
            this.lblMancc.Text = "Mã khách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttksdt);
            this.groupBox2.Controls.Add(this.chksdt);
            this.groupBox2.Controls.Add(this.btndatlai);
            this.groupBox2.Controls.Add(this.txttktenkhach);
            this.groupBox2.Controls.Add(this.chktenkhach);
            this.groupBox2.Controls.Add(this.txttkmakhach);
            this.groupBox2.Controls.Add(this.chkmakhach);
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 474);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm khách hàng";
            // 
            // txttksdt
            // 
            this.txttksdt.Location = new System.Drawing.Point(50, 249);
            this.txttksdt.Name = "txttksdt";
            this.txttksdt.Size = new System.Drawing.Size(230, 22);
            this.txttksdt.TabIndex = 78;
            // 
            // chksdt
            // 
            this.chksdt.AutoSize = true;
            this.chksdt.Location = new System.Drawing.Point(23, 209);
            this.chksdt.Name = "chksdt";
            this.chksdt.Size = new System.Drawing.Size(140, 20);
            this.chksdt.TabIndex = 77;
            this.chksdt.Text = "Theo số điện thoại";
            this.chksdt.UseVisualStyleBackColor = true;
            this.chksdt.CheckedChanged += new System.EventHandler(this.chksdt_CheckedChanged);
            // 
            // btndatlai
            // 
            this.btndatlai.Location = new System.Drawing.Point(187, 306);
            this.btndatlai.Name = "btndatlai";
            this.btndatlai.Size = new System.Drawing.Size(93, 39);
            this.btndatlai.TabIndex = 76;
            this.btndatlai.Text = "Đặt lại";
            this.btndatlai.UseVisualStyleBackColor = true;
            this.btndatlai.Click += new System.EventHandler(this.btndatlai_Click);
            // 
            // txttktenkhach
            // 
            this.txttktenkhach.Location = new System.Drawing.Point(50, 165);
            this.txttktenkhach.Name = "txttktenkhach";
            this.txttktenkhach.Size = new System.Drawing.Size(230, 22);
            this.txttktenkhach.TabIndex = 75;
            // 
            // chktenkhach
            // 
            this.chktenkhach.AutoSize = true;
            this.chktenkhach.Location = new System.Drawing.Point(23, 124);
            this.chktenkhach.Name = "chktenkhach";
            this.chktenkhach.Size = new System.Drawing.Size(121, 20);
            this.chktenkhach.TabIndex = 74;
            this.chktenkhach.Text = "Theo tên khách";
            this.chktenkhach.UseVisualStyleBackColor = true;
            this.chktenkhach.CheckedChanged += new System.EventHandler(this.chktenkhach_CheckedChanged);
            // 
            // txttkmakhach
            // 
            this.txttkmakhach.Location = new System.Drawing.Point(50, 76);
            this.txttkmakhach.Name = "txttkmakhach";
            this.txttkmakhach.Size = new System.Drawing.Size(230, 22);
            this.txttkmakhach.TabIndex = 73;
            // 
            // chkmakhach
            // 
            this.chkmakhach.AutoSize = true;
            this.chkmakhach.Location = new System.Drawing.Point(23, 35);
            this.chkmakhach.Name = "chkmakhach";
            this.chkmakhach.Size = new System.Drawing.Size(122, 20);
            this.chkmakhach.TabIndex = 72;
            this.chkmakhach.Text = "Theo mã khách";
            this.chkmakhach.UseVisualStyleBackColor = true;
            this.chkmakhach.CheckedChanged += new System.EventHandler(this.chkmakhach_CheckedChanged);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(76, 306);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(93, 39);
            this.btnTimkiem.TabIndex = 71;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1275, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Khachhang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.Khachhang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.MaskedTextBox mskSodt;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.TextBox txtMakhach;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.Label lblSodt;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTenncc;
        private System.Windows.Forms.Label lblMancc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btndatlai;
        private System.Windows.Forms.TextBox txttktenkhach;
        private System.Windows.Forms.CheckBox chktenkhach;
        private System.Windows.Forms.TextBox txttkmakhach;
        private System.Windows.Forms.CheckBox chkmakhach;
        private System.Windows.Forms.CheckBox chksdt;
        private System.Windows.Forms.TextBox txttksdt;
    }
}