using FontAwesome.Sharp;

namespace beauty_shop
{
    partial class Main
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
            panelMenu = new Panel();
            btnBCTK = new IconButton();
            btnHD = new IconButton();
            btnNCC = new IconButton();
            btnUsers = new IconButton();
            btnSP = new IconButton();
            btnDMHT = new IconButton();
            panel1 = new Panel();
            btnTrangChu = new PictureBox();
            panel2 = new Panel();
            btnMaximum = new IconButton();
            btnMini = new IconButton();
            btnExit = new IconButton();
            txtTieuDeTrang = new Label();
            iPBTrangChu = new IconPictureBox();
            panel3 = new Panel();
            panelDesktop = new Panel();
            picMain = new PictureBox();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnTrangChu).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iPBTrangChu).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMain).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(btnBCTK);
            panelMenu.Controls.Add(btnHD);
            panelMenu.Controls.Add(btnNCC);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnSP);
            panelMenu.Controls.Add(btnDMHT);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(214, 507);
            panelMenu.TabIndex = 0;
            // 
            // btnBCTK
            // 
            btnBCTK.BackColor = Color.White;
            btnBCTK.Dock = DockStyle.Top;
            btnBCTK.FlatAppearance.BorderSize = 0;
            btnBCTK.FlatStyle = FlatStyle.Flat;
            btnBCTK.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBCTK.ForeColor = Color.LightCoral;
            btnBCTK.IconChar = IconChar.Tools;
            btnBCTK.IconColor = Color.LightCoral;
            btnBCTK.IconFont = IconFont.Auto;
            btnBCTK.ImageAlign = ContentAlignment.MiddleLeft;
            btnBCTK.Location = new Point(0, 411);
            btnBCTK.Name = "btnBCTK";
            btnBCTK.Size = new Size(214, 56);
            btnBCTK.TabIndex = 7;
            btnBCTK.Text = "Thống Kê";
            btnBCTK.TextAlign = ContentAlignment.MiddleLeft;
            btnBCTK.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBCTK.UseVisualStyleBackColor = false;
            btnBCTK.Click += btnBaoCaoThongKe_Click;
            // 
            // btnHD
            // 
            btnHD.BackColor = Color.White;
            btnHD.Dock = DockStyle.Top;
            btnHD.FlatAppearance.BorderSize = 0;
            btnHD.FlatStyle = FlatStyle.Flat;
            btnHD.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHD.ForeColor = Color.LightCoral;
            btnHD.IconChar = IconChar.EnvelopesBulk;
            btnHD.IconColor = Color.LightCoral;
            btnHD.IconFont = IconFont.Auto;
            btnHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnHD.Location = new Point(0, 355);
            btnHD.Name = "btnHD";
            btnHD.Size = new Size(214, 56);
            btnHD.TabIndex = 6;
            btnHD.Text = "Hóa Đơn";
            btnHD.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHD.UseVisualStyleBackColor = false;
            btnHD.Click += btnHD_Click;
            // 
            // btnNCC
            // 
            btnNCC.BackColor = Color.White;
            btnNCC.Dock = DockStyle.Top;
            btnNCC.FlatAppearance.BorderSize = 0;
            btnNCC.FlatStyle = FlatStyle.Flat;
            btnNCC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNCC.ForeColor = Color.LightCoral;
            btnNCC.IconChar = IconChar.ContactBook;
            btnNCC.IconColor = Color.LightCoral;
            btnNCC.IconFont = IconFont.Auto;
            btnNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btnNCC.Location = new Point(0, 299);
            btnNCC.Name = "btnNCC";
            btnNCC.Size = new Size(214, 56);
            btnNCC.TabIndex = 5;
            btnNCC.Text = "Nhà Cung Cấp";
            btnNCC.TextAlign = ContentAlignment.MiddleLeft;
            btnNCC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNCC.UseVisualStyleBackColor = false;
            btnNCC.Click += btnNCC_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.White;
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.LightCoral;
            btnUsers.IconChar = IconChar.Tag;
            btnUsers.IconColor = Color.LightCoral;
            btnUsers.IconFont = IconFont.Auto;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 243);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(214, 56);
            btnUsers.TabIndex = 4;
            btnUsers.Text = "Nhân Viên";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnNhanSu_KH_Click;
            // 
            // btnSP
            // 
            btnSP.BackColor = Color.White;
            btnSP.Dock = DockStyle.Top;
            btnSP.FlatAppearance.BorderSize = 0;
            btnSP.FlatStyle = FlatStyle.Flat;
            btnSP.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSP.ForeColor = Color.LightCoral;
            btnSP.IconChar = IconChar.CartShopping;
            btnSP.IconColor = Color.LightCoral;
            btnSP.IconFont = IconFont.Auto;
            btnSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnSP.Location = new Point(0, 187);
            btnSP.Name = "btnSP";
            btnSP.Size = new Size(214, 56);
            btnSP.TabIndex = 3;
            btnSP.Text = "Quản Lý Sản Phẩm";
            btnSP.TextAlign = ContentAlignment.MiddleLeft;
            btnSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSP.UseVisualStyleBackColor = false;
            btnSP.Click += btnSP_Click;
            // 
            // btnDMHT
            // 
            btnDMHT.BackColor = Color.White;
            btnDMHT.Dock = DockStyle.Top;
            btnDMHT.FlatAppearance.BorderSize = 0;
            btnDMHT.FlatStyle = FlatStyle.Flat;
            btnDMHT.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDMHT.ForeColor = Color.LightCoral;
            btnDMHT.IconChar = IconChar.BarChart;
            btnDMHT.IconColor = Color.LightCoral;
            btnDMHT.IconFont = IconFont.Auto;
            btnDMHT.ImageAlign = ContentAlignment.MiddleLeft;
            btnDMHT.Location = new Point(0, 131);
            btnDMHT.Name = "btnDMHT";
            btnDMHT.Size = new Size(214, 56);
            btnDMHT.TabIndex = 2;
            btnDMHT.Text = "Kho";
            btnDMHT.TextAlign = ContentAlignment.MiddleLeft;
            btnDMHT.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDMHT.UseVisualStyleBackColor = false;
            btnDMHT.Click += btnDMHT_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTrangChu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 131);
            panel1.TabIndex = 1;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.White;
            btnTrangChu.Dock = DockStyle.Fill;
            btnTrangChu.Image = Properties.Resources.logo;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(214, 131);
            btnTrangChu.SizeMode = PictureBoxSizeMode.Zoom;
            btnTrangChu.TabIndex = 0;
            btnTrangChu.TabStop = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnMaximum);
            panel2.Controls.Add(btnMini);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(txtTieuDeTrang);
            panel2.Controls.Add(iPBTrangChu);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(214, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 96);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // btnMaximum
            // 
            btnMaximum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximum.FlatAppearance.BorderSize = 0;
            btnMaximum.FlatStyle = FlatStyle.Flat;
            btnMaximum.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaximum.ForeColor = Color.LightCoral;
            btnMaximum.IconChar = IconChar.WindowMaximize;
            btnMaximum.IconColor = Color.LightCoral;
            btnMaximum.IconFont = IconFont.Auto;
            btnMaximum.IconSize = 24;
            btnMaximum.Location = new Point(649, 11);
            btnMaximum.Name = "btnMaximum";
            btnMaximum.Size = new Size(18, 19);
            btnMaximum.TabIndex = 5;
            btnMaximum.TextAlign = ContentAlignment.MiddleLeft;
            btnMaximum.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMaximum.UseVisualStyleBackColor = true;
            btnMaximum.Click += btnMaximum_Click;
            // 
            // btnMini
            // 
            btnMini.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMini.FlatAppearance.BorderSize = 0;
            btnMini.FlatStyle = FlatStyle.Flat;
            btnMini.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMini.ForeColor = Color.LightCoral;
            btnMini.IconChar = IconChar.Subtract;
            btnMini.IconColor = Color.LightCoral;
            btnMini.IconFont = IconFont.Auto;
            btnMini.IconSize = 24;
            btnMini.Location = new Point(626, 11);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(18, 19);
            btnMini.TabIndex = 4;
            btnMini.TextAlign = ContentAlignment.MiddleLeft;
            btnMini.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMini.UseVisualStyleBackColor = true;
            btnMini.Click += btnMini_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = IconChar.Close;
            btnExit.IconColor = Color.LightCoral;
            btnExit.IconFont = IconFont.Auto;
            btnExit.IconSize = 24;
            btnExit.Location = new Point(672, 11);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(18, 19);
            btnExit.TabIndex = 3;
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtTieuDeTrang
            // 
            txtTieuDeTrang.AutoSize = true;
            txtTieuDeTrang.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTieuDeTrang.ForeColor = Color.LightCoral;
            txtTieuDeTrang.ImageAlign = ContentAlignment.BottomRight;
            txtTieuDeTrang.Location = new Point(49, 36);
            txtTieuDeTrang.Name = "txtTieuDeTrang";
            txtTieuDeTrang.Size = new Size(79, 19);
            txtTieuDeTrang.TabIndex = 1;
            txtTieuDeTrang.Text = "Trang Chủ";
            // 
            // iPBTrangChu
            // 
            iPBTrangChu.BackColor = Color.White;
            iPBTrangChu.ForeColor = Color.LightCoral;
            iPBTrangChu.IconChar = IconChar.House;
            iPBTrangChu.IconColor = Color.LightCoral;
            iPBTrangChu.IconFont = IconFont.Auto;
            iPBTrangChu.IconSize = 28;
            iPBTrangChu.Location = new Point(15, 27);
            iPBTrangChu.Name = "iPBTrangChu";
            iPBTrangChu.Size = new Size(28, 28);
            iPBTrangChu.TabIndex = 0;
            iPBTrangChu.TabStop = false;
            iPBTrangChu.Click += iPBTrangChu_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 94);
            panel3.TabIndex = 0;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Controls.Add(picMain);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(214, 96);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(700, 411);
            panelDesktop.TabIndex = 3;
            // 
            // picMain
            // 
            picMain.Image = Properties.Resources.String;
            picMain.Location = new Point(0, 0);
            picMain.Name = "picMain";
            picMain.Size = new Size(700, 424);
            picMain.TabIndex = 0;
            picMain.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 507);
            Controls.Add(panelDesktop);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Name = "Main";
            Text = "BeautyShop";
            TopMost = true;
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnTrangChu).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iPBTrangChu).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDMHT;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBCTK;
        private FontAwesome.Sharp.IconButton btnHD;
        private FontAwesome.Sharp.IconButton btnNCC;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnSP;
        private System.Windows.Forms.PictureBox btnTrangChu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iPBTrangChu;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Label txtTieuDeTrang;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximum;
        private FontAwesome.Sharp.IconButton btnMini;
        private PictureBox picMain;
    }
}

