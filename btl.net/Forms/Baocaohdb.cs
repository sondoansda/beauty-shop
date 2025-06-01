//using Microsoft.Office.Interop.Access;
using btl.net.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace btl.net.Forms
{
    public partial class frmBaocaohdb : System.Windows.Forms.Form
    {
        public frmBaocaohdb()
        {
            InitializeComponent();
            //Functions.Connect();
        }

        private void Baocaohdb_Load(object sender, EventArgs e)
        {
            ResetValues();
            dataGridViewHoadon.DataSource = null;
            dataGridViewSanpham.DataSource = null;
            Class.Functions.FillCombo("select Makhach, Tenkhach from tblkhachhang", comboMaKH, "Makhach", "Makhach");
            comboMaKH.SelectedIndex = -1;
            Class.Functions.FillCombo("select Manhanvien, Tennhanvien from tblnhanvien", comboMaNV, "Manhanvien", "Manhanvien");
            comboMaNV.SelectedIndex = -1;
            Class.Functions.FillCombo("select Mahang, Tenhanghoa from tbldmhanghoa", comboMaSP, "Mahang", "Mahanghoa");
            comboMaSP.SelectedIndex = -1;
            Class.Functions.FillCombo("select Sohdb from tblhoadonban", comboMaHD, "Sohdb", "Sohdb");
            comboMaHD.SelectedIndex = -1;
            string sql = "SELECT a.Sohdb, c.Tenhanghoa, c.Mahang, b.Soluong, c.Dongiaban, b.Giamgia, b.Thanhtien, a.Ngayban, d.Tenkhach, e.Tennhanvien " +
               "FROM tblhoadonban AS a " +
               "JOIN tblchitiethdb AS b ON a.Sohdb = b.Sohdb " +
               "JOIN tbldmhanghoa AS c ON b.Mahang = c.Mahang " +
               "JOIN tblkhachhang AS d ON a.Makhach = d.Makhach " +
               "JOIN tblnhanvien AS e ON a.Manhanvien = e.Manhanvien " +
               "WHERE 1=1";
            tblDSHD = Functions.GetDataToTable(sql);
            dataGridViewHoadon.DataSource = tblDSHD;
        }

        private void ResetValues()
        {
            comboMaHD.Text = "";
            comboMaSP.Text = "";
            comboMaKH.Text = "";
            comboMaNV.Text = "";
            txtTennv.Text = "";
            maskNgay.Text = "  /  /";
            maskedNgaybd.Text = "  /  /";
            maskedNgaykt.Text = "  /  /";
        }

        DataTable tblDSHD;
        DataTable tblSP;

        private void Load_DataGridViewHDB()
        {
            dataGridViewHoadon.Columns[0].HeaderText = "Mã hóa đơn bán";
            dataGridViewHoadon.Columns[1].HeaderText = "Tên hàng hóa";
            dataGridViewHoadon.Columns[2].HeaderText = "Mã hàng";
            dataGridViewHoadon.Columns[3].HeaderText = "Số lượng";
            dataGridViewHoadon.Columns[4].HeaderText = "Đơn giá bán";
            dataGridViewHoadon.Columns[5].HeaderText = "Giảm giá";
            dataGridViewHoadon.Columns[6].HeaderText = "Thành tiền";
            dataGridViewHoadon.Columns[7].HeaderText = "Ngày bán";
            dataGridViewHoadon.Columns[8].HeaderText = "Tên khách hàng";
            dataGridViewHoadon.Columns[9].HeaderText = "Tên nhân viên";

            dataGridViewHoadon.Columns[0].Width = 150;
            dataGridViewHoadon.Columns[1].Width = 150;
            dataGridViewHoadon.Columns[2].Width = 100;
            dataGridViewHoadon.Columns[3].Width = 100;
            dataGridViewHoadon.Columns[4].Width = 100;
            dataGridViewHoadon.Columns[5].Width = 100;
            dataGridViewHoadon.Columns[6].Width = 100;
            dataGridViewHoadon.Columns[7].Width = 150;
            dataGridViewHoadon.Columns[8].Width = 150;
            dataGridViewHoadon.Columns[9].Width = 150;
         
            dataGridViewHoadon.AllowUserToAddRows = false;
            dataGridViewHoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Load_DataGridViewSanpham()
        {
            dataGridViewSanpham.Columns[0].HeaderText = "Tên hàng hóa";
            dataGridViewSanpham.Columns[1].HeaderText = "Số lượng";

            dataGridViewSanpham.Columns[0].Width = 150;
            dataGridViewSanpham.Columns[1].Width = 120;

            dataGridViewSanpham.AllowUserToAddRows = false;
            dataGridViewSanpham.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void buttonTimkiem_Click(object sender, EventArgs e)
        {
            string sql;

            if (comboMaHD.SelectedValue == null && comboMaSP.SelectedValue == null && maskNgay.Text == "  /  /" && comboMaKH.SelectedValue == null && comboMaNV.SelectedValue == null && maskedNgaybd.Text == "  /  /" && maskedNgaykt.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập ít nhất 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((maskedNgaybd.Text != "  /  /" && maskedNgaykt.Text == "  /  /") || (maskedNgaybd.Text == "  /  /" && maskedNgaykt.Text != "  /  /"))
            {
                MessageBox.Show("Bạn phải nhập đủ cả ngày bắt đầu và ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sql = "SELECT a.Sohdb, c.Tenhanghoa, c.Mahang, b.Soluong, c.Dongiaban, b.Giamgia, b.Thanhtien, a.Ngayban, d.Tenkhach, e.Tennhanvien " +
                  "FROM tblhoadonban AS a " +
                  "JOIN tblchitiethdb AS b ON a.Sohdb = b.Sohdb " +
                  "JOIN tbldmhanghoa AS c ON b.Mahang = c.Mahang " +
                  "JOIN tblkhachhang AS d ON a.Makhach = d.Makhach " +
                  "JOIN tblnhanvien AS e ON a.Manhanvien = e.Manhanvien " +
                  "WHERE 1=1";
            if (comboMaHD.SelectedValue != null)
            {
                sql = sql + " AND a.Sohdb LIKE N'%" + comboMaHD.Text + "%' ";
            }
            if (comboMaSP.SelectedValue != null)
            {
                sql = sql + " AND c.Tenhanghoa LIKE N'%" + comboMaSP.Text + "%'";
            }
            if (maskNgay.Text != "  /  /")
            {
                if (!Class.Functions.IsDate(maskNgay.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskNgay.Focus();
                    maskNgay.Text = "";
                    return;
                }
                sql = sql + " AND CONVERT(date, a.Ngayban)='" + Class.Functions.ConvertDateTime(maskNgay.Text) + "'";
            }

            if (maskedNgaybd.Text != "  /  /" && maskedNgaykt.Text != "  /  /")
            {
                if (!Class.Functions.IsDate(maskedNgaykt.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskedNgaykt.Focus();
                    maskedNgaykt.Text = "";
                    return;
                }
                if (!Class.Functions.IsDate(maskedNgaybd.Text))
                {
                    MessageBox.Show("Hãy nhập lại ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskedNgaybd.Focus();
                    maskedNgaybd.Text = "";
                    return;
                }
                if (DateTime.ParseExact(maskedNgaybd.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(maskedNgaykt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskedNgaybd.Text = "";
                    maskedNgaykt.Text = "";
                    return;
                }
                sql = sql + " AND (CONVERT(date, a.Ngayban) BETWEEN '" + Class.Functions.ConvertDateTime(maskedNgaybd.Text) + "' AND '" + Class.Functions.ConvertDateTime(maskedNgaykt.Text) + "')";
            }

            if (comboMaKH.SelectedValue != null)
            {
                sql = sql + " AND d.Tenkhach LIKE N'%" + comboMaKH.Text + "%'";
            }
            if (comboMaNV.SelectedValue != null)
            {
                sql = sql + " AND e.Tennhanvien LIKE N'%" + comboMaNV.Text + "%'";
            }

            tblDSHD = Class.Functions.GetDataToTable(sql);
            var countHDB = tblDSHD.AsEnumerable().Select(row => row.Field<string>("Sohdb")).Distinct().Count();
            if (countHDB == 0)
            {
                MessageBox.Show("Không có hóa đơn bán nào thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
            {
                MessageBox.Show("Có " + countHDB + " hóa đơn bán thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridViewHoadon.DataSource = tblDSHD;
            Load_DataGridViewHDB();
            //sql1 = "SELECT * FROM tblSanPham";

            tblSP = new DataTable();
            tblSP.Columns.Add("Tenhanghoa");
            tblSP.Columns.Add("Tongsoluong");

            var query = from row in tblDSHD.AsEnumerable()
                        group row by row.Field<string>("Tenhanghoa") into g
                        select new
                        {
                            Tenhanghoa = g.Key,
                            Tongsoluong = g.Sum(r => Convert.ToDouble(r["Soluong"]))
                        };

            double tongSLSanPham = 0;

            foreach (var item in query)
            {
                DataRow newRow = tblSP.NewRow();
                newRow["Tenhanghoa"] = item.Tenhanghoa;
                newRow["Tongsoluong"] = item.Tongsoluong;
                tblSP.Rows.Add(newRow);

                tongSLSanPham += item.Tongsoluong;
            }

            dataGridViewSanpham.DataSource = tblSP;
            Load_DataGridViewSanpham();
        }

        private void buttonTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dataGridViewHoadon.DataSource = null;
            dataGridViewSanpham.DataSource = null;
        }

        private void buttonInBC_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            //string sql;
            int hang = 0, cot = 0;
            //DataTable tbldanhsach;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];

            exRange.Range["A2:P2"].Font.Size = 28;
            exRange.Range["A2:P2"].Font.Name = "Times new roman";
            exRange.Range["A2:P2"].Font.Bold = true;
            exRange.Range["A2:P2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["A2:P2"].MergeCells = true;
            exRange.Range["A2:P2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:P2"].Value = "DANH SÁCH BÁN HÀNG";

            exRange.Range["A4:K4"].Font.Bold = true;
            exRange.Range["A4:K4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B4:C4,I4:K4"].ColumnWidth = 18;
            exRange.Range["D4:H4"].ColumnWidth = 12;
            exRange.Range["A4:A4"].Value = "STT";
            exRange.Range["B4:B4"].Value = "Mã hoá đơn";
            exRange.Range["C4:C4"].Value = "Tên hàng";
            exRange.Range["D4:D4"].Value = "Mã hàng";
            exRange.Range["E4:E4"].Value = "Số lượng bán";
            exRange.Range["F4:F4"].Value = "Đơn giá bán";
            exRange.Range["G4:G4"].Value = "Giảm giá";
            exRange.Range["H4:H4"].Value = "Thành tiền";
            exRange.Range["I4:I4"].Value = "Ngày bán";
            exRange.Range["J4:J4"].Value = "Tên khách hàng";
            exRange.Range["K4:K4"].Value = "Tên nhân viên bán";
            for (int row = 0; row < tblDSHD.Rows.Count; row++)
            {
                exSheet.Cells[1][row + 5] = row + 1;
                for (int col = 0; col < tblDSHD.Columns.Count; col++)
                {
                    if (tblDSHD.Columns[col].ColumnName == "Ngayban")
                    {

                        DateTime ngayBan = Convert.ToDateTime(tblDSHD.Rows[row]["Ngayban"]);
                        exSheet.Cells[col + 2][row + 5] = ngayBan.ToShortDateString();
                    }
                    else
                    {

                        exSheet.Cells[col + 2][row + 5] = tblDSHD.Rows[row][col].ToString();
                    }
                }
            }

            for (hang = 0; hang < tblDSHD.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 5] = hang + 1;
                for (cot = 0; cot < tblDSHD.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 5] = tblDSHD.Rows[hang][cot].ToString();
                }
            }

            exRange.Range["O4:P4"].Font.Bold = true;
            exRange.Range["O4:P4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["O4:P4"].ColumnWidth = 15;
            exRange.Range["O4:O4"].Value = "Tên sản Phẩm";
            exRange.Range["P4:P4"].Value = "Số lượng bán";
            for (hang = 0; hang < tblSP.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 5] = hang + 1;
                for (cot = 0; cot < tblSP.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 15][hang + 5] = tblSP.Rows[hang][cot].ToString();
                }
            }

            exApp.Visible = true;
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn thức sự muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboMaNV_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (comboMaNV.Text == "")
                txtTennv.Text = "";
            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            str = "Select Tennhanvien from tblnhanvien where Manhanvien =N'" + comboMaNV.SelectedValue + "'";
            txtTennv.Text = Functions.GetFieldValues(str);

        }
    }
}
