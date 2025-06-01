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
    public partial class frmBaocaohdn : System.Windows.Forms.Form
    {
        public frmBaocaohdn()
        {
            InitializeComponent();
            //Functions.Connect();
        }

        private void Baocaohdn_Load(object sender, EventArgs e)
        {
            ResetValues();
            dataGridViewHoadon.DataSource = null;
            dataGridViewSanpham.DataSource = null;
            Class.Functions.FillCombo("select Mancc, Tenncc from tblnhacungcap", comboMaNCC, "Mancc", "Tenncc");
            comboMaNCC.SelectedIndex = -1;
            Class.Functions.FillCombo("select Manhanvien, Tennhanvien from tblnhanvien", comboMaNV, "Manhanvien", "Tennhanvien");
            comboMaNV.SelectedIndex = -1;
            Class.Functions.FillCombo("select Mahang, Tenhanghoa from tbldmhanghoa", comboMaSP, "Mahang", "Tenhanghoa");
            comboMaSP.SelectedIndex = -1;
            Class.Functions.FillCombo("select Sohdn from tblhoadonnhap", comboMaHD, "Sohdn", "Sohdn");
            comboMaHD.SelectedIndex = -1;
            string sql = "SELECT a.Sohdn, c.Tenhanghoa, c.Mahang, b.Soluong, b.Dongia, b.Giamgia, b.Thanhtien, a.Ngaynhap, d.Tenncc, e.Tennhanvien " +
                 "FROM tblhoadonnhap AS a " +
                 "JOIN tblchitiethdn AS b ON a.Sohdn = b.Sohdn " +
                 "JOIN tbldmhanghoa AS c ON b.Mahang = c.Mahang " +
                 "JOIN tblnhacungcap AS d ON a.Mancc = d.Mancc " +
                 "JOIN tblnhanvien AS e ON a.Manhanvien = e.Manhanvien  " +
                 "WHERE 1=1";
            tblDSHD = Functions.GetDataToTable(sql);
            dataGridViewHoadon.DataSource = tblDSHD;
        }

        private void ResetValues()
        {
            comboMaHD.Text = "";
            comboMaSP.Text = "";
            comboMaNCC.Text = "";
            comboMaNV.Text = "";
            textDongianhap.Text = "";
            maskNgay.Text = "  /  /";
            maskedNgaybd.Text = "  /  /";
            maskedNgaykt.Text = "  /  /";
        }

        DataTable tblDSHD;
        DataTable tblSP;

        private void Load_DataGridViewHDN()
        {
            dataGridViewHoadon.Columns[0].HeaderText = "Mã hóa đơn nhập";
            dataGridViewHoadon.Columns[1].HeaderText = "Tên hàng hóa";
            dataGridViewHoadon.Columns[2].HeaderText = "Mã hàng";
            dataGridViewHoadon.Columns[3].HeaderText = "Số lượng";
            dataGridViewHoadon.Columns[4].HeaderText = "Đơn giá nhập";
            dataGridViewHoadon.Columns[5].HeaderText = "Giảm giá";
            dataGridViewHoadon.Columns[6].HeaderText = "Thành tiền";
            dataGridViewHoadon.Columns[7].HeaderText = "Ngày nhập";
            dataGridViewHoadon.Columns[8].HeaderText = "Tên nhà cung cấp";
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

            if (comboMaHD.SelectedValue == null && comboMaSP.SelectedValue == null && maskNgay.Text == "  /  /" && comboMaNCC.SelectedValue == null && comboMaNV.SelectedValue == null && maskedNgaybd.Text == "  /  /" && maskedNgaykt.Text == "  /  /" && textDongianhap.Text == "")
            {
                MessageBox.Show("Hãy nhập ít nhất 1 dữ liệu để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((maskedNgaybd.Text != "  /  /" && maskedNgaykt.Text == "  /  /") || (maskedNgaybd.Text == "  /  /" && maskedNgaykt.Text != "  /  /"))
            {
                MessageBox.Show("Bạn phải nhập đủ cả ngày bắt đầu và ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sql = "SELECT a.Sohdn, c.Tenhanghoa, c.Mahang, b.Soluong, b.Dongia, b.Giamgia, b.Thanhtien, a.Ngaynhap, d.Tenncc, e.Tennhanvien " +
                  "FROM tblhoadonnhap AS a " +
                  "JOIN tblchitiethdn AS b ON a.Sohdn = b.Sohdn " +
                  "JOIN tbldmhanghoa AS c ON b.Mahang = c.Mahang " +
                  "JOIN tblnhacungcap AS d ON a.Mancc = d.Mancc " +
                  "JOIN tblnhanvien AS e ON a.Manhanvien = e.Manhanvien  " +
                  "WHERE 1=1";
            if (comboMaHD.SelectedValue != null)
            {
                sql = sql + " AND a.SOhdn LIKE N'%" + comboMaHD.Text + "%' ";
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
                sql = sql + " AND CONVERT(date, a.Ngaynhap) ='" + Class.Functions.ConvertDateTime(maskNgay.Text) + "'";
            }
            if (maskedNgaybd.Text != "  /  /")
            {
                if (maskedNgaybd.Text == "  /  /")
                {
                    MessageBox.Show("Hãy nhập ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskedNgaybd.Focus();
                    return;
                }
            }
            if (maskedNgaykt.Text != "  /  /")
            {
                if (maskedNgaykt.Text == "  /  /")
                {
                    MessageBox.Show("Hãy nhập ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskedNgaykt.Focus();
                    return;
                }
            }
            if (maskedNgaybd.Text != "  /  /" && maskedNgaybd.Text != "  /  /")
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
                sql = sql + " AND (CONVERT(date, a.Ngaynhap) BETWEEN '" + Class.Functions.ConvertDateTime(maskedNgaybd.Text) + "' AND '" + Class.Functions.ConvertDateTime(maskedNgaykt.Text) + "')";
            }
            if (comboMaNCC.SelectedValue != null)
            {
                sql = sql + " AND d.Tenncc LIKE N'%" + comboMaNCC.Text + "%'";
            }
            if (comboMaNV.SelectedValue != null)
            {
                sql = sql + " AND e.Tennhanvien LIKE N'%" + comboMaNV.Text + "%'";
            }
            if (textDongianhap.Text != "")
                sql = sql + " AND b.Dongianhap LIKE N'%" + textDongianhap.Text + "%'";
            tblDSHD = Class.Functions.GetDataToTable(sql);
            var countHDN = tblDSHD.AsEnumerable().Select(row => row.Field<string>("Sohdn")).Distinct().Count();
            if (countHDN == 0)
            {
                MessageBox.Show("Không có hóa đơn nhập nào thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
            {
                MessageBox.Show("Có " + countHDN + " hóa đơn nhập thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridViewHoadon.DataSource = tblDSHD;
            Load_DataGridViewHDN();
            //sql1 = "SELECT * FROM tblSanPham";

            tblSP = new DataTable();
            tblSP.Columns.Add("Tenhang");
            tblSP.Columns.Add("Tongsoluong");

            var query = from row in tblDSHD.AsEnumerable()
                        group row by row.Field<string>("Tenhanghoa") into g
                        select new
                        {
                            TenSP = g.Key,
                            Tongsoluong = g.Sum(r => Convert.ToDouble(r["Soluong"]))
                        };

            double tongSLSanPham = 0;

            foreach (var item in query)
            {
                DataRow newRow = tblSP.NewRow();
                newRow["Tenhang"] = item.TenSP;
                newRow["TongSoLuong"] = item.Tongsoluong;
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

            int hang = 0, cot = 0;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];

            exRange.Range["A2:P2"].Font.Size = 28;
            exRange.Range["A2:P2"].Font.Name = "Times new roman";
            exRange.Range["A2:P2"].Font.Bold = true;
            exRange.Range["A2:P2"].Font.ColorIndex = 3;
            exRange.Range["A2:P2"].MergeCells = true;
            exRange.Range["A2:P2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:P2"].Value = "DANH SÁCH NHẬP HÀNG";

            exRange.Range["A4:K4"].Font.Bold = true;
            exRange.Range["A4:K4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B4:C4,I4:K4"].ColumnWidth = 18;
            exRange.Range["D4:H4"].ColumnWidth = 12;
            exRange.Range["A4:A4"].Value = "STT";
            exRange.Range["B4:B4"].Value = "Mã hoá đơn nhập";
            exRange.Range["C4:C4"].Value = "Tên hàng hóa";
            exRange.Range["D4:D4"].Value = "Mã hàng";
            exRange.Range["E4:E4"].Value = "Số lượng nhập";
            exRange.Range["F4:F4"].Value = "Đơn giá nhập";
            exRange.Range["G4:G4"].Value = "Giảm giá";
            exRange.Range["H4:H4"].Value = "Thành tiền";
            exRange.Range["I4:I4"].Value = "Ngày nhập";
            exRange.Range["J4:J4"].Value = "Tên nhà cung cấp";
            exRange.Range["K4:K4"].Value = "Tên nhân viên nhập";

            int totalQuantity = 0;

            for (int row = 0; row < tblDSHD.Rows.Count; row++)
            {
                exSheet.Cells[row + 5, 1] = row + 1; // STT
                for (int col = 0; col < tblDSHD.Columns.Count; col++)
                {
                    if (tblDSHD.Columns[col].ColumnName == "Ngaynhap")
                    {
                        DateTime ngayNhap;
                        if (DateTime.TryParse(tblDSHD.Rows[row]["Ngaynhap"].ToString(), out ngayNhap))
                        {
                            exSheet.Cells[row + 5, col + 2] = ngayNhap.ToShortDateString();
                        }
                        else
                        {
                            exSheet.Cells[row + 5, col + 2] = "Invalid Date";
                        }
                    }
                    else
                    {
                        exSheet.Cells[row + 5, col + 2] = tblDSHD.Rows[row][col].ToString();
                    }
                }
                totalQuantity += Convert.ToInt32(tblDSHD.Rows[row]["Soluong"]);
            }

            exRange = exSheet.Cells[tblDSHD.Rows.Count + 14, tblDSHD.Columns.Count - 1];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng số lượng:";
            exRange = exSheet.Cells[tblDSHD.Rows.Count + 14, tblDSHD.Columns.Count];
            exRange.Font.Bold = true;
            exRange.Value2 = totalQuantity.ToString();

            exRange = exSheet.Cells[tblDSHD.Rows.Count + 16, 1];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;

            exRange = exSheet.Cells[tblDSHD.Rows.Count + 18, 1];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "Nhân viên nhập hàng";

            exRange = exSheet.Cells[tblDSHD.Rows.Count + 22, 1];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = tblDSHD.Rows[0]["TenNhanVien"].ToString(); // Ensure column name is correct

            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;

            exRange.Range["O4:P4"].Font.Bold = true;
            exRange.Range["O4:P4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["O4:P4"].ColumnWidth = 15;
            exRange.Range["O4:O4"].Value = "Tên sản phẩm";
            exRange.Range["P4:P4"].Value = "Số lượng nhập";

            for (hang = 0; hang < tblSP.Rows.Count; hang++)
            {
                exSheet.Cells[hang + 5, 1] = hang + 1;
                for (cot = 0; cot < tblSP.Columns.Count; cot++)
                {
                    exSheet.Cells[hang + 5, cot + 15] = tblSP.Rows[hang][cot].ToString();
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
    }
}
