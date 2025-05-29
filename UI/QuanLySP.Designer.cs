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
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();

            // dgvHangHoa
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(12, 150);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(760, 300);
            this.dgvHangHoa.TabIndex = 0;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(12, 470);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(100, 470);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(190, 470);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // txtTimKiem
            this.txtTimKiem.Location = new System.Drawing.Point(100, 20);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 23);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            // lblTimKiem
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(12, 23);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Text = "Tìm kiếm:";

            // FrmDMHangHoa
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHangHoa);
            this.Name = "FrmDMHangHoa";
            this.Text = "Danh mục hàng hóa";
        
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
    }
}

//panel1 = new Panel();
//label1 = new Label();
//tabControl1 = new TabControl();
//tabDSSP = new TabPage();
//btnXoa = new FontAwesome.Sharp.IconButton();
//btnThem = new FontAwesome.Sharp.IconButton();
//btnSua = new FontAwesome.Sharp.IconButton();
//btnHuybo = new FontAwesome.Sharp.IconButton();
//dataGridView1 = new DataGridView();
//btnTimKiem = new FontAwesome.Sharp.IconButton();
//txtTimKiem = new TextBox();
//lblTimKiem = new Label();
//tabChiTietSP = new TabPage();
//txtDonGia = new TextBox();
//label4 = new Label();
//txtXuatSu = new TextBox();
//label2 = new Label();
//txtMau = new TextBox();
//lblMau = new Label();
//txtLoai = new TextBox();
//txtMua = new TextBox();
//label8 = new Label();
//txtCongDung = new TextBox();
//lblCongDung = new Label();
//txtChatLieu = new TextBox();
//label5 = new Label();
//txtHangSX = new TextBox();
//label3 = new Label();
//txtTenSP = new TextBox();
//lblLoai = new Label();
//label7 = new Label();
//textBox1 = new TextBox();
//lbMaSP = new Label();
//panel1.SuspendLayout();
//tabControl1.SuspendLayout();
//tabDSSP.SuspendLayout();
//((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
//tabChiTietSP.SuspendLayout();
//SuspendLayout();
//// 
//// panel1
//// 
//panel1.Controls.Add(label1);
//panel1.Dock = DockStyle.Top;
//panel1.Location = new Point(0, 0);
//panel1.Name = "panel1";
//panel1.Size = new Size(800, 66);
//panel1.TabIndex = 0;
//// 
//// label1
//// 
//label1.AutoSize = true;
//label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
//label1.Location = new Point(30, 16);
//label1.Name = "label1";
//label1.Size = new Size(116, 31);
//label1.TabIndex = 0;
//label1.Text = "Sản phẩm";
//// 
//// tabControl1
//// 
//tabControl1.Controls.Add(tabDSSP);
//tabControl1.Controls.Add(tabChiTietSP);
//tabControl1.Dock = DockStyle.Fill;
//tabControl1.Location = new Point(0, 66);
//tabControl1.Name = "tabControl1";
//tabControl1.SelectedIndex = 0;
//tabControl1.Size = new Size(800, 384);
//tabControl1.TabIndex = 1;
//// 
//// tabDSSP
//// 
//tabDSSP.Controls.Add(btnXoa);
//tabDSSP.Controls.Add(btnThem);
//tabDSSP.Controls.Add(btnSua);
//tabDSSP.Controls.Add(btnHuybo);
//tabDSSP.Controls.Add(dataGridView1);
//tabDSSP.Controls.Add(btnTimKiem);
//tabDSSP.Controls.Add(txtTimKiem);
//tabDSSP.Controls.Add(lblTimKiem);
//tabDSSP.Location = new Point(4, 29);
//tabDSSP.Name = "tabDSSP";
//tabDSSP.Padding = new Padding(3);
//tabDSSP.Size = new Size(792, 351);
//tabDSSP.TabIndex = 0;
//tabDSSP.Text = "Danh sách sản phẩm";
//tabDSSP.UseVisualStyleBackColor = true;
//// 
//// btnXoa
//// 
//btnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
//btnXoa.IconColor = Color.Black;
//btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
//btnXoa.Location = new Point(690, 187);
//btnXoa.Name = "btnXoa";
//btnXoa.Size = new Size(94, 29);
//btnXoa.TabIndex = 7;
//btnXoa.Text = "Xóa";
//btnXoa.UseVisualStyleBackColor = true;
//// 
//// btnThem
//// 
//btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
//btnThem.IconColor = Color.Black;
//btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
//btnThem.Location = new Point(690, 86);
//btnThem.Name = "btnThem";
//btnThem.Size = new Size(94, 29);
//btnThem.TabIndex = 6;
//btnThem.Text = "Thêm";
//btnThem.UseVisualStyleBackColor = true;
//// 
//// btnSua
//// 
//btnSua.IconChar = FontAwesome.Sharp.IconChar.None;
//btnSua.IconColor = Color.Black;
//btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
//btnSua.Location = new Point(690, 136);
//btnSua.Name = "btnSua";
//btnSua.Size = new Size(94, 29);
//btnSua.TabIndex = 5;
//btnSua.Text = "Sửa";
//btnSua.UseVisualStyleBackColor = true;
//// 
//// btnHuybo
//// 
//btnHuybo.IconChar = FontAwesome.Sharp.IconChar.None;
//btnHuybo.IconColor = Color.Black;
//btnHuybo.IconFont = FontAwesome.Sharp.IconFont.Auto;
//btnHuybo.Location = new Point(690, 237);
//btnHuybo.Name = "btnHuybo";
//btnHuybo.Size = new Size(94, 29);
//btnHuybo.TabIndex = 4;
//btnHuybo.Text = "Hủy bỏ";
//btnHuybo.UseVisualStyleBackColor = true;
//// 
//// dataGridView1
//// 
//dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//dataGridView1.Location = new Point(12, 86);
//dataGridView1.Name = "dataGridView1";
//dataGridView1.RowHeadersWidth = 51;
//dataGridView1.Size = new Size(661, 259);
//dataGridView1.TabIndex = 3;
//dataGridView1.CellContentClick += dataGridView1_CellContentClick;
//// 
//// btnTimKiem
//// 
//btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.None;
//btnTimKiem.IconColor = Color.Black;
//btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
//btnTimKiem.Location = new Point(579, 42);
//btnTimKiem.Name = "btnTimKiem";
//btnTimKiem.Size = new Size(94, 29);
//btnTimKiem.TabIndex = 2;
//btnTimKiem.Text = "Tìm kiếm";
//btnTimKiem.UseVisualStyleBackColor = true;
//btnTimKiem.Click += btnTimKiem_Click;
//// 
//// txtTimKiem
//// 
//txtTimKiem.Location = new Point(12, 42);
//txtTimKiem.Name = "txtTimKiem";
//txtTimKiem.Size = new Size(546, 27);
//txtTimKiem.TabIndex = 1;
//// 
//// lblTimKiem
//// 
//lblTimKiem.AutoSize = true;
//lblTimKiem.Location = new Point(8, 14);
//lblTimKiem.Name = "lblTimKiem";
//lblTimKiem.Size = new Size(70, 20);
//lblTimKiem.TabIndex = 0;
//lblTimKiem.Text = "Tìm kiếm";
//// 
//// tabChiTietSP
//// 
//tabChiTietSP.Controls.Add(txtDonGia);
//tabChiTietSP.Controls.Add(label4);
//tabChiTietSP.Controls.Add(txtXuatSu);
//tabChiTietSP.Controls.Add(label2);
//tabChiTietSP.Controls.Add(txtMau);
//tabChiTietSP.Controls.Add(lblMau);
//tabChiTietSP.Controls.Add(txtLoai);
//tabChiTietSP.Controls.Add(txtMua);
//tabChiTietSP.Controls.Add(label8);
//tabChiTietSP.Controls.Add(txtCongDung);
//tabChiTietSP.Controls.Add(lblCongDung);
//tabChiTietSP.Controls.Add(txtChatLieu);
//tabChiTietSP.Controls.Add(label5);
//tabChiTietSP.Controls.Add(txtHangSX);
//tabChiTietSP.Controls.Add(label3);
//tabChiTietSP.Controls.Add(txtTenSP);
//tabChiTietSP.Controls.Add(lblLoai);
//tabChiTietSP.Controls.Add(label7);
//tabChiTietSP.Controls.Add(textBox1);
//tabChiTietSP.Controls.Add(lbMaSP);
//tabChiTietSP.Location = new Point(4, 29);
//tabChiTietSP.Name = "tabChiTietSP";
//tabChiTietSP.Padding = new Padding(3);
//tabChiTietSP.Size = new Size(792, 351);
//tabChiTietSP.TabIndex = 1;
//tabChiTietSP.Text = "Chi tiết sản phẩm";
//tabChiTietSP.UseVisualStyleBackColor = true;
//// 
//// txtDonGia
//// 
//txtDonGia.Location = new Point(314, 225);
//txtDonGia.Name = "txtDonGia";
//txtDonGia.Size = new Size(125, 27);
//txtDonGia.TabIndex = 30;
//// 
//// label4
//// 
//label4.AutoSize = true;
//label4.Location = new Point(314, 202);
//label4.Name = "label4";
//label4.Size = new Size(62, 20);
//label4.TabIndex = 29;
//label4.Text = "Đơn giá";
//// 
//// txtXuatSu
//// 
//txtXuatSu.Location = new Point(314, 161);
//txtXuatSu.Name = "txtXuatSu";
//txtXuatSu.Size = new Size(125, 27);
//txtXuatSu.TabIndex = 28;
//// 
//// label2
//// 
//label2.AutoSize = true;
//label2.Location = new Point(314, 138);
//label2.Name = "label2";
//label2.Size = new Size(58, 20);
//label2.TabIndex = 27;
//label2.Text = "Xuất sứ";
//// 
//// txtMau
//// 
//txtMau.Location = new Point(314, 97);
//txtMau.Name = "txtMau";
//txtMau.Size = new Size(125, 27);
//txtMau.TabIndex = 26;
//// 
//// lblMau
//// 
//lblMau.AutoSize = true;
//lblMau.Location = new Point(314, 74);
//lblMau.Name = "lblMau";
//lblMau.Size = new Size(38, 20);
//lblMau.TabIndex = 25;
//lblMau.Text = "Màu";
//// 
//// txtLoai
//// 
//txtLoai.Location = new Point(8, 161);
//txtLoai.Name = "txtLoai";
//txtLoai.Size = new Size(125, 27);
//txtLoai.TabIndex = 24;
//// 
//// txtMua
//// 
//txtMua.Location = new Point(161, 225);
//txtMua.Name = "txtMua";
//txtMua.Size = new Size(125, 27);
//txtMua.TabIndex = 23;
//// 
//// label8
//// 
//label8.AutoSize = true;
//label8.Location = new Point(161, 202);
//label8.Name = "label8";
//label8.Size = new Size(38, 20);
//label8.TabIndex = 22;
//label8.Text = "Mùa";
//// 
//// txtCongDung
//// 
//txtCongDung.Location = new Point(161, 161);
//txtCongDung.Name = "txtCongDung";
//txtCongDung.Size = new Size(125, 27);
//txtCongDung.TabIndex = 21;
//// 
//// lblCongDung
//// 
//lblCongDung.AutoSize = true;
//lblCongDung.Location = new Point(161, 138);
//lblCongDung.Name = "lblCongDung";
//lblCongDung.Size = new Size(82, 20);
//lblCongDung.TabIndex = 20;
//lblCongDung.Text = "Công dụng";
//// 
//// txtChatLieu
//// 
//txtChatLieu.Location = new Point(161, 97);
//txtChatLieu.Name = "txtChatLieu";
//txtChatLieu.Size = new Size(125, 27);
//txtChatLieu.TabIndex = 19;
//// 
//// label5
//// 
//label5.AutoSize = true;
//label5.Location = new Point(161, 74);
//label5.Name = "label5";
//label5.Size = new Size(67, 20);
//label5.TabIndex = 18;
//label5.Text = "Chất liệu";
//// 
//// txtHangSX
//// 
//txtHangSX.Location = new Point(8, 225);
//txtHangSX.Name = "txtHangSX";
//txtHangSX.Size = new Size(125, 27);
//txtHangSX.TabIndex = 15;
//// 
//// label3
//// 
//label3.AutoSize = true;
//label3.Location = new Point(8, 202);
//label3.Name = "label3";
//label3.Size = new Size(103, 20);
//label3.TabIndex = 14;
//label3.Text = "Hãng sản xuất";
//// 
//// txtTenSP
//// 
//txtTenSP.Location = new Point(8, 97);
//txtTenSP.Name = "txtTenSP";
//txtTenSP.Size = new Size(125, 27);
//txtTenSP.TabIndex = 13;
//// 
//// lblLoai
//// 
//lblLoai.AutoSize = true;
//lblLoai.Location = new Point(6, 138);
//lblLoai.Name = "lblLoai";
//lblLoai.Size = new Size(37, 20);
//lblLoai.TabIndex = 2;
//lblLoai.Text = "Loại";
//// 
//// label7
//// 
//label7.AutoSize = true;
//label7.Location = new Point(8, 74);
//label7.Name = "label7";
//label7.Size = new Size(100, 20);
//label7.TabIndex = 12;
//label7.Text = "Tên sản phẩm";
//// 
//// textBox1
//// 
//textBox1.Location = new Point(8, 37);
//textBox1.Name = "textBox1";
//textBox1.Size = new Size(125, 27);
//textBox1.TabIndex = 1;
//// 
//// lbMaSP
//// 
//lbMaSP.AutoSize = true;
//lbMaSP.Location = new Point(8, 14);
//lbMaSP.Name = "lbMaSP";
//lbMaSP.Size = new Size(98, 20);
//lbMaSP.TabIndex = 0;
//lbMaSP.Text = "Mã sản phẩm";
//// 
//// QuanLySP
//// 
//AutoScaleDimensions = new SizeF(8F, 20F);
//AutoScaleMode = AutoScaleMode.Font;
//ClientSize = new Size(800, 450);
//Controls.Add(tabControl1);
//Controls.Add(panel1);
//Name = "QuanLySP";
//Load += QuanLySP_Load;
//panel1.ResumeLayout(false);
//panel1.PerformLayout();
//tabControl1.ResumeLayout(false);
//tabDSSP.ResumeLayout(false);
//tabDSSP.PerformLayout();
//((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
//tabChiTietSP.ResumeLayout(false);
//tabChiTietSP.PerformLayout();
//ResumeLayout(false);
//        }

 

//        private Panel panel1;
//private Label label1;
//private TabControl tabControl1;
//private TabPage tabDSSP;
//private TabPage tabChiTietSP;
//private FontAwesome.Sharp.IconButton btnTimKiem;
//private TextBox txtTimKiem;
//private Label lblTimKiem;
//private DataGridView dataGridView1;
//private FontAwesome.Sharp.IconButton btnXoa;
//private FontAwesome.Sharp.IconButton btnThem;
//private FontAwesome.Sharp.IconButton btnSua;
//private FontAwesome.Sharp.IconButton btnHuybo;
//private Label lbMaSP;
//private TextBox txtMua;
//private Label label8;
//private TextBox txtCongDung;
//private Label lblCongDung;
//private TextBox txtChatLieu;
//private Label label5;
//private TextBox txtHangSX;
//private Label label3;
//private TextBox txtTenSP;
//private Label lblLoai;
//private Label label7;
//private TextBox textBox1;
//private TextBox txtLoai;
//private TextBox txtMau;
//private Label lblMau;
//private TextBox txtDonGia;
//private Label label4;
//private TextBox txtXuatSu;
//private Label label2;
//    }
//}


