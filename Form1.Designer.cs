using FontAwesome.Sharp;

namespace beauty_shop
{
    partial class Form1
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
            btnHome = new PictureBox();
            panel2 = new Panel();
            btnMaximum = new IconButton();
            btnMini = new IconButton();
            btnExit = new IconButton();
            txtCurrentChildForm = new Label();
            iconPictureBox1 = new IconPictureBox();
            panelShadow = new Panel();
            panel3 = new Panel();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelShadow.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(btnBCTK);
            panelMenu.Controls.Add(btnHD);
            panelMenu.Controls.Add(btnNCC);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnSP);
            panelMenu.Controls.Add(btnDMHT);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 730);
            panelMenu.TabIndex = 0;
            // 
            // btnBCTK
            // 
            btnBCTK.Dock = DockStyle.Top;
            btnBCTK.FlatAppearance.BorderSize = 0;
            btnBCTK.FlatStyle = FlatStyle.Flat;
            btnBCTK.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBCTK.ForeColor = Color.Gainsboro;
            btnBCTK.IconChar = IconChar.Tools;
            btnBCTK.IconColor = Color.Gainsboro;
            btnBCTK.IconFont = IconFont.Auto;
            btnBCTK.ImageAlign = ContentAlignment.MiddleLeft;
            btnBCTK.Location = new Point(0, 550);
            btnBCTK.Margin = new Padding(3, 4, 3, 4);
            btnBCTK.Name = "btnBCTK";
            btnBCTK.Size = new Size(251, 75);
            btnBCTK.TabIndex = 7;
            btnBCTK.Text = "Báo cáo thông kê";
            btnBCTK.TextAlign = ContentAlignment.MiddleLeft;
            btnBCTK.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBCTK.UseVisualStyleBackColor = true;
            btnBCTK.Click += btnSetting_Click;
            // 
            // btnHD
            // 
            btnHD.Dock = DockStyle.Top;
            btnHD.FlatAppearance.BorderSize = 0;
            btnHD.FlatStyle = FlatStyle.Flat;
            btnHD.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHD.ForeColor = Color.Gainsboro;
            btnHD.IconChar = IconChar.EnvelopesBulk;
            btnHD.IconColor = Color.Gainsboro;
            btnHD.IconFont = IconFont.Auto;
            btnHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnHD.Location = new Point(0, 475);
            btnHD.Margin = new Padding(3, 4, 3, 4);
            btnHD.Name = "btnHD";
            btnHD.Size = new Size(251, 75);
            btnHD.TabIndex = 6;
            btnHD.Text = "Hóa đơn";
            btnHD.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHD.UseVisualStyleBackColor = true;
            btnHD.Click += btnMarketing_Click;
            // 
            // btnNCC
            // 
            btnNCC.Dock = DockStyle.Top;
            btnNCC.FlatAppearance.BorderSize = 0;
            btnNCC.FlatStyle = FlatStyle.Flat;
            btnNCC.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNCC.ForeColor = Color.Gainsboro;
            btnNCC.IconChar = IconChar.ContactBook;
            btnNCC.IconColor = Color.Gainsboro;
            btnNCC.IconFont = IconFont.Auto;
            btnNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btnNCC.Location = new Point(0, 400);
            btnNCC.Margin = new Padding(3, 4, 3, 4);
            btnNCC.Name = "btnNCC";
            btnNCC.Size = new Size(251, 75);
            btnNCC.TabIndex = 5;
            btnNCC.Text = "Nhà cung cấp";
            btnNCC.TextAlign = ContentAlignment.MiddleLeft;
            btnNCC.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNCC.UseVisualStyleBackColor = true;
            btnNCC.Click += btnCustomers_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.Gainsboro;
            btnUsers.IconChar = IconChar.Tag;
            btnUsers.IconColor = Color.Gainsboro;
            btnUsers.IconFont = IconFont.Auto;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 325);
            btnUsers.Margin = new Padding(3, 4, 3, 4);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(251, 75);
            btnUsers.TabIndex = 4;
            btnUsers.Text = "Nhân sự & Khách Hàng";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnProducts_Click;
            // 
            // btnSP
            // 
            btnSP.Dock = DockStyle.Top;
            btnSP.FlatAppearance.BorderSize = 0;
            btnSP.FlatStyle = FlatStyle.Flat;
            btnSP.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSP.ForeColor = Color.Gainsboro;
            btnSP.IconChar = IconChar.CartShopping;
            btnSP.IconColor = Color.Gainsboro;
            btnSP.IconFont = IconFont.Auto;
            btnSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnSP.Location = new Point(0, 250);
            btnSP.Margin = new Padding(3, 4, 3, 4);
            btnSP.Name = "btnSP";
            btnSP.Size = new Size(251, 75);
            btnSP.TabIndex = 3;
            btnSP.Text = "Quản lý sản phẩm";
            btnSP.TextAlign = ContentAlignment.MiddleLeft;
            btnSP.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSP.UseVisualStyleBackColor = true;
            btnSP.Click += btnOrders_Click;
            // 
            // btnDMHT
            // 
            btnDMHT.Dock = DockStyle.Top;
            btnDMHT.FlatAppearance.BorderSize = 0;
            btnDMHT.FlatStyle = FlatStyle.Flat;
            btnDMHT.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDMHT.ForeColor = Color.Gainsboro;
            btnDMHT.IconChar = IconChar.BarChart;
            btnDMHT.IconColor = Color.Gainsboro;
            btnDMHT.IconFont = IconFont.Auto;
            btnDMHT.ImageAlign = ContentAlignment.MiddleLeft;
            btnDMHT.Location = new Point(0, 175);
            btnDMHT.Margin = new Padding(3, 4, 3, 4);
            btnDMHT.Name = "btnDMHT";
            btnDMHT.Size = new Size(251, 75);
            btnDMHT.TabIndex = 2;
            btnDMHT.Text = "Danh mục hệ thống";
            btnDMHT.TextAlign = ContentAlignment.MiddleLeft;
            btnDMHT.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDMHT.UseVisualStyleBackColor = true;
            btnDMHT.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 175);
            panel1.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.Image = Properties.Resources.logo_background_changed;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(251, 175);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 25, 62);
            panel2.Controls.Add(btnMaximum);
            panel2.Controls.Add(btnMini);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(txtCurrentChildForm);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(251, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 125);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // btnMaximum
            // 
            btnMaximum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximum.FlatAppearance.BorderSize = 0;
            btnMaximum.FlatStyle = FlatStyle.Flat;
            btnMaximum.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaximum.ForeColor = Color.Gainsboro;
            btnMaximum.IconChar = IconChar.WindowMaximize;
            btnMaximum.IconColor = Color.Gainsboro;
            btnMaximum.IconFont = IconFont.Auto;
            btnMaximum.IconSize = 24;
            btnMaximum.Location = new Point(864, 15);
            btnMaximum.Margin = new Padding(3, 4, 3, 4);
            btnMaximum.Name = "btnMaximum";
            btnMaximum.Size = new Size(20, 25);
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
            btnMini.ForeColor = Color.Gainsboro;
            btnMini.IconChar = IconChar.Subtract;
            btnMini.IconColor = Color.Gainsboro;
            btnMini.IconFont = IconFont.Auto;
            btnMini.IconSize = 24;
            btnMini.Location = new Point(838, 15);
            btnMini.Margin = new Padding(3, 4, 3, 4);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(20, 25);
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
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = IconFont.Auto;
            btnExit.IconSize = 24;
            btnExit.Location = new Point(890, 15);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(20, 25);
            btnExit.TabIndex = 3;
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtCurrentChildForm
            // 
            txtCurrentChildForm.AutoSize = true;
            txtCurrentChildForm.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentChildForm.ForeColor = Color.Gainsboro;
            txtCurrentChildForm.Location = new Point(75, 49);
            txtCurrentChildForm.Name = "txtCurrentChildForm";
            txtCurrentChildForm.Size = new Size(54, 20);
            txtCurrentChildForm.TabIndex = 1;
            txtCurrentChildForm.Text = "Home";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(26, 25, 62);
            iconPictureBox1.ForeColor = Color.MediumPurple;
            iconPictureBox1.IconChar = IconChar.House;
            iconPictureBox1.IconColor = Color.MediumPurple;
            iconPictureBox1.IconFont = IconFont.Auto;
            iconPictureBox1.Location = new Point(37, 34);
            iconPictureBox1.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 40);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelShadow.Controls.Add(panel3);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(251, 125);
            panelShadow.Margin = new Padding(3, 4, 3, 4);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(922, 11);
            panelShadow.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 125);
            panel3.TabIndex = 0;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(251, 136);
            panelDesktop.Margin = new Padding(3, 4, 3, 4);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(922, 594);
            panelDesktop.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 730);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "BeautyShop";
            TopMost = true;
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelShadow.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Label txtCurrentChildForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximum;
        private FontAwesome.Sharp.IconButton btnMini;
    }
}

