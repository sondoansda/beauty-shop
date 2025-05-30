namespace beauty_shop
{
    partial class DangNhap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnDangNhap = new Button();
            btnThoat = new Button();
            chkHienMatKhau = new CheckBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(119, 158);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(180, 23);
            txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(119, 188);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(180, 23);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 161);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 191);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(119, 238);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(85, 25);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(214, 238);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(85, 25);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(119, 213);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(104, 19);
            chkHienMatKhau.TabIndex = 6;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(334, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(465, 445);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // DangNhap
            // 
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(chkHienMatKhau);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Name = "DangNhap";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
