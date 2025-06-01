namespace btl.net.Forms
{
    partial class Mua
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txtten = new System.Windows.Forms.TextBox();
            this.lblchatlieu = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.lblmachatlieu = new System.Windows.Forms.Label();
            this.lbltenchatlieu = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.lblchatlieu);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.lblmachatlieu);
            this.panel1.Controls.Add(this.lbltenchatlieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 128);
            this.panel1.TabIndex = 47;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(628, 73);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(69, 39);
            this.btntimkiem.TabIndex = 230;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(429, 83);
            this.txtten.Margin = new System.Windows.Forms.Padding(2);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(182, 20);
            this.txtten.TabIndex = 16;
            // 
            // lblchatlieu
            // 
            this.lblchatlieu.AutoSize = true;
            this.lblchatlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchatlieu.ForeColor = System.Drawing.Color.Black;
            this.lblchatlieu.Location = new System.Drawing.Point(292, 20);
            this.lblchatlieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblchatlieu.Name = "lblchatlieu";
            this.lblchatlieu.Size = new System.Drawing.Size(91, 37);
            this.lblchatlieu.TabIndex = 0;
            this.lblchatlieu.Text = "MÙA";
            this.lblchatlieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(123, 83);
            this.txtma.Margin = new System.Windows.Forms.Padding(2);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(182, 20);
            this.txtma.TabIndex = 15;
            // 
            // lblmachatlieu
            // 
            this.lblmachatlieu.AutoSize = true;
            this.lblmachatlieu.Location = new System.Drawing.Point(74, 85);
            this.lblmachatlieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmachatlieu.Name = "lblmachatlieu";
            this.lblmachatlieu.Size = new System.Drawing.Size(45, 13);
            this.lblmachatlieu.TabIndex = 13;
            this.lblmachatlieu.Text = "Mã mùa";
            // 
            // lbltenchatlieu
            // 
            this.lbltenchatlieu.AutoSize = true;
            this.lbltenchatlieu.Location = new System.Drawing.Point(376, 85);
            this.lbltenchatlieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltenchatlieu.Name = "lbltenchatlieu";
            this.lbltenchatlieu.Size = new System.Drawing.Size(49, 13);
            this.lbltenchatlieu.TabIndex = 14;
            this.lbltenchatlieu.Text = "Tên mùa";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(119, 144);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(470, 177);
            this.DataGridView.TabIndex = 48;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click_1);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(574, 349);
            this.btndong.Margin = new System.Windows.Forms.Padding(2);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(69, 39);
            this.btndong.TabIndex = 229;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(404, 349);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(2);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(69, 39);
            this.btnboqua.TabIndex = 228;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(320, 349);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(69, 39);
            this.btnluu.TabIndex = 227;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(235, 349);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(69, 39);
            this.btnxoa.TabIndex = 226;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(150, 349);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(69, 39);
            this.btnsua.TabIndex = 225;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(65, 349);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(69, 39);
            this.btnthem.TabIndex = 224;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(489, 349);
            this.btnhienthi.Margin = new System.Windows.Forms.Padding(2);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(69, 39);
            this.btnhienthi.TabIndex = 231;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 419);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 81);
            this.panel2.TabIndex = 232;
            // 
            // Mua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(708, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mua";
            this.Text = "Mùa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label lblchatlieu;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label lblmachatlieu;
        private System.Windows.Forms.Label lbltenchatlieu;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Panel panel2;
    }
}