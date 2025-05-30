using System.Drawing.Printing;
using System.Xml.Linq;
using beauty_shop.Model;
using static System.Net.Mime.MediaTypeNames;

namespace beauty_shop.Forms
{
    partial class ThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnThisMonth = new Button();
            btnLast30Days = new Button();
            btnLast7Days = new Button();
            btnToday = new Button();
            btnCustomDate = new Button();
            btnOkCustomDate = new Button();
            panel1 = new Panel();
            label3 = new Label();
            lblNumOrders = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            lblTotalRevenue = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label11 = new Label();
            lblTotalProfit = new Label();
            label5 = new Label();
            panel4 = new Panel();
            lblNumProducts = new Label();
            label9 = new Label();
            lblNumSuppliers = new Label();
            label8 = new Label();
            label7 = new Label();
            lblNumCustomers = new Label();
            label6 = new Label();
            chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 39);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "MMM dd, yyyy";
            dtpStartDate.Enabled = false;
            dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(218, 18);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(122, 23);
            dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "MMM dd, yyyy";
            dtpEndDate.Enabled = false;
            dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(364, 18);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(122, 23);
            dtpEndDate.TabIndex = 2;
            // 
            // btnThisMonth
            // 
            btnThisMonth.Location = new Point(1060, 10);
            btnThisMonth.Margin = new Padding(5);
            btnThisMonth.Name = "btnThisMonth";
            btnThisMonth.Size = new Size(130, 35);
            btnThisMonth.TabIndex = 3;
            btnThisMonth.Text = "This month";
            btnThisMonth.UseVisualStyleBackColor = true;
            btnThisMonth.Click += btnThisMonth_Click;
            // 
            // btnLast30Days
            // 
            btnLast30Days.Location = new Point(929, 10);
            btnLast30Days.Margin = new Padding(5);
            btnLast30Days.Name = "btnLast30Days";
            btnLast30Days.Size = new Size(130, 35);
            btnLast30Days.TabIndex = 4;
            btnLast30Days.Text = "Last 30 days";
            btnLast30Days.UseVisualStyleBackColor = true;
            btnLast30Days.Click += btnLast30Days_Click;
            // 
            // btnLast7Days
            // 
            btnLast7Days.Location = new Point(798, 10);
            btnLast7Days.Margin = new Padding(5);
            btnLast7Days.Name = "btnLast7Days";
            btnLast7Days.Size = new Size(130, 35);
            btnLast7Days.TabIndex = 5;
            btnLast7Days.Text = "Last 7 days";
            btnLast7Days.UseVisualStyleBackColor = true;
            btnLast7Days.Click += btnLast7Days_Click;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(667, 10);
            btnToday.Margin = new Padding(5);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(130, 35);
            btnToday.TabIndex = 6;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
            btnToday.Click += btnToday_Click;
            // 
            // btnCustomDate
            // 
            btnCustomDate.Location = new Point(536, 10);
            btnCustomDate.Margin = new Padding(5);
            btnCustomDate.Name = "btnCustomDate";
            btnCustomDate.Size = new Size(130, 35);
            btnCustomDate.TabIndex = 7;
            btnCustomDate.Text = "Custom";
            btnCustomDate.UseVisualStyleBackColor = true;
            btnCustomDate.Click += btnCustomDate_Click;
            // 
            // btnOkCustomDate
            // 
            btnOkCustomDate.Location = new Point(498, 10);
            btnOkCustomDate.Margin = new Padding(5);
            btnOkCustomDate.Name = "btnOkCustomDate";
            btnOkCustomDate.Size = new Size(35, 35);
            btnOkCustomDate.TabIndex = 8;
            btnOkCustomDate.Text = "Ok";
            btnOkCustomDate.UseVisualStyleBackColor = true;
            btnOkCustomDate.Visible = false;
            btnOkCustomDate.Click += btnOkCustomDate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblNumOrders);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 55);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 73);
            panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(124, 141, 181);
            label3.Location = new Point(225, 27);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 2;
            label3.Text = "+15%";
            // 
            // lblNumOrders
            // 
            lblNumOrders.AutoSize = true;
            lblNumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumOrders.Location = new Point(52, 34);
            lblNumOrders.Name = "lblNumOrders";
            lblNumOrders.Size = new Size(97, 29);
            lblNumOrders.TabIndex = 1;
            lblNumOrders.Text = "100000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(124, 141, 181);
            label2.Location = new Point(21, 14);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 0;
            label2.Text = "Number of Orders";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblTotalRevenue);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(302, 55);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 73);
            panel2.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(124, 141, 181);
            label10.Location = new Point(405, 27);
            label10.Name = "label10";
            label10.Size = new Size(64, 25);
            label10.TabIndex = 3;
            label10.Text = "+21%";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRevenue.Location = new Point(74, 34);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(97, 29);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "100000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(124, 141, 181);
            label4.Location = new Point(75, 14);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 0;
            label4.Text = "Total Revenue";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(lblTotalProfit);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(770, 55);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 73);
            panel3.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(124, 141, 181);
            label11.Location = new Point(367, 27);
            label11.Name = "label11";
            label11.Size = new Size(64, 25);
            label11.TabIndex = 3;
            label11.Text = "+19%";
            // 
            // lblTotalProfit
            // 
            lblTotalProfit.AutoSize = true;
            lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalProfit.Location = new Point(74, 34);
            lblTotalProfit.Name = "lblTotalProfit";
            lblTotalProfit.Size = new Size(97, 29);
            lblTotalProfit.TabIndex = 1;
            lblTotalProfit.Text = "100000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(124, 141, 181);
            label5.Location = new Point(75, 14);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 0;
            label5.Text = "Total Profit";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblNumProducts);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(lblNumSuppliers);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lblNumCustomers);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(14, 405);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(205, 228);
            panel4.TabIndex = 10;
            // 
            // lblNumProducts
            // 
            lblNumProducts.AutoSize = true;
            lblNumProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumProducts.Location = new Point(59, 185);
            lblNumProducts.Name = "lblNumProducts";
            lblNumProducts.Size = new Size(97, 29);
            lblNumProducts.TabIndex = 6;
            lblNumProducts.Text = "100000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(124, 141, 181);
            label9.Location = new Point(60, 165);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 5;
            label9.Text = "Products";
            // 
            // lblNumSuppliers
            // 
            lblNumSuppliers.AutoSize = true;
            lblNumSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumSuppliers.Location = new Point(59, 125);
            lblNumSuppliers.Name = "lblNumSuppliers";
            lblNumSuppliers.Size = new Size(97, 29);
            lblNumSuppliers.TabIndex = 4;
            lblNumSuppliers.Text = "100000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(124, 141, 181);
            label8.Location = new Point(60, 105);
            label8.Name = "label8";
            label8.Size = new Size(94, 25);
            label8.TabIndex = 3;
            label8.Text = "Suppliers";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 10);
            label7.Name = "label7";
            label7.Size = new Size(178, 29);
            label7.TabIndex = 2;
            label7.Text = "Total Counters";
            // 
            // lblNumCustomers
            // 
            lblNumCustomers.AutoSize = true;
            lblNumCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumCustomers.Location = new Point(59, 65);
            lblNumCustomers.Name = "lblNumCustomers";
            lblNumCustomers.Size = new Size(97, 29);
            lblNumCustomers.TabIndex = 1;
            lblNumCustomers.Text = "100000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(124, 141, 181);
            label6.Location = new Point(60, 45);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 0;
            label6.Text = "Customers";
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDoanhThu.Legends.Add(legend1);
            chartDoanhThu.Location = new Point(14, 146);
            chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            chartDoanhThu.Series.Add(series1);
            chartDoanhThu.Size = new Size(1154, 251);
            chartDoanhThu.TabIndex = 15;
            chartDoanhThu.Text = "Doanh thu theo thời gian";
            // 
            // BaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 642);
            Controls.Add(chartDoanhThu);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnOkCustomDate);
            Controls.Add(btnCustomDate);
            Controls.Add(btnToday);
            Controls.Add(btnLast7Days);
            Controls.Add(btnLast30Days);
            Controls.Add(btnThisMonth);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "BaoCaoThongKe";
            Text = "Store statistics";
            Load += BaoCaoThongKe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDoanhThu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnOkCustomDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNumProducts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumSuppliers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
    }
}