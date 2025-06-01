namespace btl.net.Forms
{
    partial class Baocaodoanhthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baocaodoanhthu));
            this.lbltt = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btninbaocao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbtimkiem = new System.Windows.Forms.GroupBox();
            this.dtdenngay = new System.Windows.Forms.DateTimePicker();
            this.dttungay = new System.Windows.Forms.DateTimePicker();
            this.dttheongay = new System.Windows.Forms.DateTimePicker();
            this.radtheokhoang = new System.Windows.Forms.RadioButton();
            this.radtheongay = new System.Windows.Forms.RadioButton();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.lbltenkhachhang = new System.Windows.Forms.Label();
            this.lblmakhachhang = new System.Windows.Forms.Label();
            this.lbldoanhthu = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grbtimkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltt
            // 
            this.lbltt.AutoSize = true;
            this.lbltt.ForeColor = System.Drawing.Color.Red;
            this.lbltt.Location = new System.Drawing.Point(53, 585);
            this.lbltt.Name = "lbltt";
            this.lbltt.Size = new System.Drawing.Size(66, 16);
            this.lbltt.TabIndex = 66;
            this.lbltt.Text = "Bằng chữ:";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(136, 554);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(139, 22);
            this.txttongtien.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tổng tiền:";
            // 
            // btninbaocao
            // 
            this.btninbaocao.Location = new System.Drawing.Point(911, 597);
            this.btninbaocao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btninbaocao.Name = "btninbaocao";
            this.btninbaocao.Size = new System.Drawing.Size(107, 34);
            this.btninbaocao.TabIndex = 64;
            this.btninbaocao.Text = "In báo cáo";
            this.btninbaocao.UseVisualStyleBackColor = true;
            this.btninbaocao.Click += new System.EventHandler(this.btninbaocao_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbtimkiem);
            this.panel1.Controls.Add(this.lbldoanhthu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 270);
            this.panel1.TabIndex = 62;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grbtimkiem
            // 
            this.grbtimkiem.Controls.Add(this.dtdenngay);
            this.grbtimkiem.Controls.Add(this.dttungay);
            this.grbtimkiem.Controls.Add(this.dttheongay);
            this.grbtimkiem.Controls.Add(this.radtheokhoang);
            this.grbtimkiem.Controls.Add(this.radtheongay);
            this.grbtimkiem.Controls.Add(this.btntimkiem);
            this.grbtimkiem.Controls.Add(this.label1);
            this.grbtimkiem.Controls.Add(this.txttenhang);
            this.grbtimkiem.Controls.Add(this.txtmahang);
            this.grbtimkiem.Controls.Add(this.lbltenkhachhang);
            this.grbtimkiem.Controls.Add(this.lblmakhachhang);
            this.grbtimkiem.Location = new System.Drawing.Point(56, 79);
            this.grbtimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbtimkiem.Name = "grbtimkiem";
            this.grbtimkiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbtimkiem.Size = new System.Drawing.Size(1031, 161);
            this.grbtimkiem.TabIndex = 1;
            this.grbtimkiem.TabStop = false;
            this.grbtimkiem.Text = "Tìm kiếm thông tin";
            // 
            // dtdenngay
            // 
            this.dtdenngay.CustomFormat = "dd/MM/yyyy";
            this.dtdenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtdenngay.Location = new System.Drawing.Point(836, 84);
            this.dtdenngay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtdenngay.Name = "dtdenngay";
            this.dtdenngay.Size = new System.Drawing.Size(136, 22);
            this.dtdenngay.TabIndex = 177;
            // 
            // dttungay
            // 
            this.dttungay.CustomFormat = "dd/MM/yyyy";
            this.dttungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttungay.Location = new System.Drawing.Point(659, 84);
            this.dttungay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dttungay.Name = "dttungay";
            this.dttungay.Size = new System.Drawing.Size(136, 22);
            this.dttungay.TabIndex = 176;
            // 
            // dttheongay
            // 
            this.dttheongay.CustomFormat = "dd/MM/yyyy";
            this.dttheongay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttheongay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttheongay.Location = new System.Drawing.Point(685, 47);
            this.dttheongay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dttheongay.Name = "dttheongay";
            this.dttheongay.Size = new System.Drawing.Size(144, 22);
            this.dttheongay.TabIndex = 175;
            // 
            // radtheokhoang
            // 
            this.radtheokhoang.AutoSize = true;
            this.radtheokhoang.Location = new System.Drawing.Point(563, 86);
            this.radtheokhoang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radtheokhoang.Name = "radtheokhoang";
            this.radtheokhoang.Size = new System.Drawing.Size(77, 20);
            this.radtheokhoang.TabIndex = 16;
            this.radtheokhoang.TabStop = true;
            this.radtheokhoang.Text = "Từ ngày";
            this.radtheokhoang.UseVisualStyleBackColor = true;
            // 
            // radtheongay
            // 
            this.radtheongay.AutoSize = true;
            this.radtheongay.Location = new System.Drawing.Point(563, 47);
            this.radtheongay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radtheongay.Name = "radtheongay";
            this.radtheongay.Size = new System.Drawing.Size(93, 20);
            this.radtheongay.TabIndex = 15;
            this.radtheongay.TabStop = true;
            this.radtheongay.Text = "Theo ngày";
            this.radtheongay.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(855, 130);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(93, 23);
            this.btntimkiem.TabIndex = 14;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(800, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "đến";
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(211, 82);
            this.txttenhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(241, 22);
            this.txttenhang.TabIndex = 9;
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(211, 46);
            this.txtmahang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(241, 22);
            this.txtmahang.TabIndex = 8;
            // 
            // lbltenkhachhang
            // 
            this.lbltenkhachhang.AutoSize = true;
            this.lbltenkhachhang.Location = new System.Drawing.Point(76, 86);
            this.lbltenkhachhang.Name = "lbltenkhachhang";
            this.lbltenkhachhang.Size = new System.Drawing.Size(93, 16);
            this.lbltenkhachhang.TabIndex = 7;
            this.lbltenkhachhang.Text = "Theo tên hàng";
            // 
            // lblmakhachhang
            // 
            this.lblmakhachhang.AutoSize = true;
            this.lblmakhachhang.Location = new System.Drawing.Point(76, 52);
            this.lblmakhachhang.Name = "lblmakhachhang";
            this.lblmakhachhang.Size = new System.Drawing.Size(94, 16);
            this.lblmakhachhang.TabIndex = 0;
            this.lblmakhachhang.Text = "Theo mã hàng";
            // 
            // lbldoanhthu
            // 
            this.lbldoanhthu.AutoSize = true;
            this.lbldoanhthu.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldoanhthu.ForeColor = System.Drawing.Color.Black;
            this.lbldoanhthu.Location = new System.Drawing.Point(337, 31);
            this.lbldoanhthu.Name = "lbldoanhthu";
            this.lbldoanhthu.Size = new System.Drawing.Size(458, 46);
            this.lbldoanhthu.TabIndex = 0;
            this.lbldoanhthu.Text = "BÁO CÁO DOANH THU";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(56, 288);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(983, 244);
            this.DataGridView.TabIndex = 63;
            // 
            // Baocaodoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1125, 654);
            this.Controls.Add(this.lbltt);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btninbaocao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Baocaodoanhthu";
            this.Text = "Baocaodoanhthu";
            this.Load += new System.EventHandler(this.Baocaodoanhthu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbtimkiem.ResumeLayout(false);
            this.grbtimkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltt;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btninbaocao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbtimkiem;
        private System.Windows.Forms.RadioButton radtheokhoang;
        private System.Windows.Forms.RadioButton radtheongay;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.Label lbltenkhachhang;
        private System.Windows.Forms.Label lblmakhachhang;
        private System.Windows.Forms.Label lbldoanhthu;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DateTimePicker dtdenngay;
        private System.Windows.Forms.DateTimePicker dttungay;
        private System.Windows.Forms.DateTimePicker dttheongay;
    }
}