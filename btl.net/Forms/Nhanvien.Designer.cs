namespace btl.net.Forms
{
    partial class Nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhanvien));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.cboMacv = new System.Windows.Forms.ComboBox();
            this.mskSodt = new System.Windows.Forms.MaskedTextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbotkmacv = new System.Windows.Forms.ComboBox();
            this.chkmacv = new System.Windows.Forms.CheckBox();
            this.txttksdt = new System.Windows.Forms.TextBox();
            this.chksdt = new System.Windows.Forms.CheckBox();
            this.btndatlai = new System.Windows.Forms.Button();
            this.txttktennvien = new System.Windows.Forms.TextBox();
            this.chktennvien = new System.Windows.Forms.CheckBox();
            this.chkmanvien = new System.Windows.Forms.CheckBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cbotkmanvien = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 46);
            this.label1.TabIndex = 34;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtngaysinh);
            this.groupBox1.Controls.Add(this.btnHienthi);
            this.groupBox1.Controls.Add(this.rdoNu);
            this.groupBox1.Controls.Add(this.rdoNam);
            this.groupBox1.Controls.Add(this.cboMacv);
            this.groupBox1.Controls.Add(this.mskSodt);
            this.groupBox1.Controls.Add(this.btnDong);
            this.groupBox1.Controls.Add(this.btnBoqua);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTennv);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.dgvNV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(320, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 571);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(628, 28);
            this.txtngaysinh.Mask = "00/00/0000";
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(228, 22);
            this.txtngaysinh.TabIndex = 83;
            this.txtngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(664, 509);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(92, 48);
            this.btnHienthi.TabIndex = 82;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(222, 140);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(45, 20);
            this.rdoNu.TabIndex = 81;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(149, 140);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(57, 20);
            this.rdoNam.TabIndex = 80;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // cboMacv
            // 
            this.cboMacv.FormattingEnabled = true;
            this.cboMacv.Location = new System.Drawing.Point(628, 134);
            this.cboMacv.Name = "cboMacv";
            this.cboMacv.Size = new System.Drawing.Size(228, 24);
            this.cboMacv.TabIndex = 77;
            // 
            // mskSodt
            // 
            this.mskSodt.Location = new System.Drawing.Point(628, 85);
            this.mskSodt.Mask = "(999) 000-0000";
            this.mskSodt.Name = "mskSodt";
            this.mskSodt.Size = new System.Drawing.Size(229, 22);
            this.mskSodt.TabIndex = 76;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(788, 509);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(92, 48);
            this.btnDong.TabIndex = 75;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(540, 509);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(92, 48);
            this.btnBoqua.TabIndex = 74;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(416, 509);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 48);
            this.btnLuu.TabIndex = 73;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(292, 509);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 48);
            this.btnXoa.TabIndex = 72;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(168, 509);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 48);
            this.btnSua.TabIndex = 71;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(44, 509);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 48);
            this.btnThem.TabIndex = 70;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(142, 188);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(227, 22);
            this.txtDiachi.TabIndex = 69;
            this.txtDiachi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiachi_KeyPress);
            this.txtDiachi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiachi_KeyUp);
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(142, 93);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(227, 22);
            this.txtTennv.TabIndex = 68;
            this.txtTennv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTennv_KeyUp);
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(142, 37);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(227, 22);
            this.txtManv.TabIndex = 67;
            this.txtManv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtManv_KeyUp);
            // 
            // dgvNV
            // 
            this.dgvNV.BackgroundColor = System.Drawing.Color.White;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(50, 249);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(807, 238);
            this.dgvNV.TabIndex = 66;
            this.dgvNV.Click += new System.EventHandler(this.dgvNV_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 65;
            this.label8.Text = "Mã công việc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 63;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mã nhân viên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbotkmanvien);
            this.groupBox2.Controls.Add(this.cbotkmacv);
            this.groupBox2.Controls.Add(this.chkmacv);
            this.groupBox2.Controls.Add(this.txttksdt);
            this.groupBox2.Controls.Add(this.chksdt);
            this.groupBox2.Controls.Add(this.btndatlai);
            this.groupBox2.Controls.Add(this.txttktennvien);
            this.groupBox2.Controls.Add(this.chktennvien);
            this.groupBox2.Controls.Add(this.chkmanvien);
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 571);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm nhân viên";
            // 
            // cbotkmacv
            // 
            this.cbotkmacv.FormattingEnabled = true;
            this.cbotkmacv.Location = new System.Drawing.Point(50, 329);
            this.cbotkmacv.Name = "cbotkmacv";
            this.cbotkmacv.Size = new System.Drawing.Size(230, 24);
            this.cbotkmacv.TabIndex = 83;
            // 
            // chkmacv
            // 
            this.chkmacv.AutoSize = true;
            this.chkmacv.Location = new System.Drawing.Point(23, 293);
            this.chkmacv.Name = "chkmacv";
            this.chkmacv.Size = new System.Drawing.Size(144, 20);
            this.chkmacv.TabIndex = 79;
            this.chkmacv.Text = "Theo mã công việc";
            this.chkmacv.UseVisualStyleBackColor = true;
            this.chkmacv.CheckedChanged += new System.EventHandler(this.chkmacv_CheckedChanged);
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
            this.btndatlai.Location = new System.Drawing.Point(187, 382);
            this.btndatlai.Name = "btndatlai";
            this.btndatlai.Size = new System.Drawing.Size(93, 39);
            this.btndatlai.TabIndex = 76;
            this.btndatlai.Text = "Đặt lại";
            this.btndatlai.UseVisualStyleBackColor = true;
            this.btndatlai.Click += new System.EventHandler(this.btndatlai_Click);
            // 
            // txttktennvien
            // 
            this.txttktennvien.Location = new System.Drawing.Point(50, 165);
            this.txttktennvien.Name = "txttktennvien";
            this.txttktennvien.Size = new System.Drawing.Size(230, 22);
            this.txttktennvien.TabIndex = 75;
            // 
            // chktennvien
            // 
            this.chktennvien.AutoSize = true;
            this.chktennvien.Location = new System.Drawing.Point(23, 124);
            this.chktennvien.Name = "chktennvien";
            this.chktennvien.Size = new System.Drawing.Size(142, 20);
            this.chktennvien.TabIndex = 74;
            this.chktennvien.Text = "Theo tên nhân viên";
            this.chktennvien.UseVisualStyleBackColor = true;
            this.chktennvien.CheckedChanged += new System.EventHandler(this.chktennvien_CheckedChanged);
            // 
            // chkmanvien
            // 
            this.chkmanvien.AutoSize = true;
            this.chkmanvien.Location = new System.Drawing.Point(23, 35);
            this.chkmanvien.Name = "chkmanvien";
            this.chkmanvien.Size = new System.Drawing.Size(143, 20);
            this.chkmanvien.TabIndex = 72;
            this.chkmanvien.Text = "Theo mã nhân viên";
            this.chkmanvien.UseVisualStyleBackColor = true;
            this.chkmanvien.CheckedChanged += new System.EventHandler(this.chkmanvien_CheckedChanged);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(76, 382);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(93, 39);
            this.btnTimkiem.TabIndex = 71;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cbotkmanvien
            // 
            this.cbotkmanvien.FormattingEnabled = true;
            this.cbotkmanvien.Location = new System.Drawing.Point(50, 62);
            this.cbotkmanvien.Name = "cbotkmanvien";
            this.cbotkmanvien.Size = new System.Drawing.Size(230, 24);
            this.cbotkmanvien.TabIndex = 84;
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1222, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.ComboBox cboMacv;
        private System.Windows.Forms.MaskedTextBox mskSodt;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbotkmacv;
        private System.Windows.Forms.CheckBox chkmacv;
        private System.Windows.Forms.TextBox txttksdt;
        private System.Windows.Forms.CheckBox chksdt;
        private System.Windows.Forms.Button btndatlai;
        private System.Windows.Forms.TextBox txttktennvien;
        private System.Windows.Forms.CheckBox chktennvien;
        private System.Windows.Forms.CheckBox chkmanvien;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.MaskedTextBox txtngaysinh;
        private System.Windows.Forms.ComboBox cbotkmanvien;
    }
}