using btl.net.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using COMExcel= Microsoft.Office.Interop.Excel;


namespace btl.net.Forms
{
    public partial class Baocaodoanhthu : Form
    {
        public Baocaodoanhthu()
        {
            InitializeComponent();
        }

        private void Baocaodoanhthu_Load(object sender, EventArgs e)
        {
            ResetValues();
        }
        DataTable tbldoanhthu;
        private void ResetValues()
        {
            txtmahang.Text = "";
            txttenhang.Text = "";
            radtheokhoang.Checked = false;
            radtheongay.Checked = false;
            dtdenngay.Value = DateTimePicker.MinimumDateTime;
            dttheongay.Value = DateTimePicker.MinimumDateTime;
            dttungay.Value = DateTimePicker.MinimumDateTime;
        }
        private static readonly string[] UnitsMap = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
        private static readonly string[] TensMap = { "không", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT hd.Sohdb, hd.Ngayban, ct.Mahang, h.Tenhanghoa, ct.Soluong, ct.Dongia, ct.Giamgia, (ct.Soluong * ct.Dongia - ct.Giamgia) as Thanhtien " +
                                       "FROM tblchitiethdb ct " +
                                       "JOIN tbldmhanghoa h ON ct.Mahang = h.Mahang " +
                                       "JOIN tblhoadonban hd ON ct.Sohdb = hd.Sohdb ";
            tbldoanhthu = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tbldoanhthu;
            DataGridView.Columns[0].HeaderText = "Mã hóa đơn";
            DataGridView.Columns[1].HeaderText = "Ngày bán";
            DataGridView.Columns[2].HeaderText = "Mã hàng";
            DataGridView.Columns[3].HeaderText = "Tên hàng";
            DataGridView.Columns[4].HeaderText = "Số lượng";
            DataGridView.Columns[5].HeaderText = "Đơn giá";
            DataGridView.Columns[6].HeaderText = "Giảm giá";
            DataGridView.Columns[7].HeaderText = "Thành tiền";
            DataGridView.Columns[0].Width = 90;
            DataGridView.Columns[1].Width = 80;
            DataGridView.Columns[2].Width = 80;
            DataGridView.Columns[3].Width = 160;
            DataGridView.Columns[4].Width = 80;
            DataGridView.Columns[5].Width = 80;
            DataGridView.Columns[6].Width = 80;
            DataGridView.Columns[7].Width = 90;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {


            // Tạo truy vấn SQL
            string sql = "SELECT hd.Sohdb, hd.Ngayban, ct.Mahang, h.Tenhanghoa, ct.Soluong, ct.Dongia, ct.Giamgia, (ct.Soluong * ct.Dongia - ct.Giamgia) as Thanhtien " +
                           "FROM tblchitiethdb ct " +
                           "JOIN tbldmhanghoa h ON ct.Mahang = h.Mahang " +
                           "JOIN tblhoadonban hd ON ct.Sohdb = hd.Sohdb " +
                           "WHERE 1=1";



            if (txtmahang.Text != "")
                sql = sql + " AND ct.Mahang LIKE N'%" + txtmahang.Text + "%'";

            if (txttenhang.Text != "")
            {
                sql = sql + " AND h.Tenhanghoa LIKE '%" + txttenhang.Text + "%'";
            }
            DateTime theongay = dttheongay.Value;
            DateTime tungay = dttungay.Value;
            DateTime denngay = dtdenngay.Value;
            if (radtheongay.Checked)
                sql = sql + " AND CONVERT(date, Ngayban) = '" + dttheongay.Value.ToString("yyyy-MM-dd") + "'";


            if (radtheokhoang.Checked)
            {
                if (tungay > denngay)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                    sql = sql + " AND CAST(hd.Ngayban AS DATE) BETWEEN '" + tungay.ToString("yyyy-MM-dd") + "' AND '" + denngay.ToString("yyyy-MM-dd") + "'";

            }

            tbldoanhthu = Class.Functions.GetDataToTable(sql);
            if (tbldoanhthu.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Có " + tbldoanhthu.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataGridView.DataSource = tbldoanhthu;




            // Tính tổng tiền
            decimal tongtien = 0;
            foreach (DataRow row in tbldoanhthu.Rows)
            {
                tongtien += Convert.ToDecimal(row["Thanhtien"]);
            }

            txttongtien.Text = tongtien.ToString("N0");
            lbltt.Text = "Bằng chữ: " + ConvertToWords(Convert.ToDecimal(txttongtien.Text)) + " đồng";

        }
        public string ConvertToWords(decimal number)
        {
            if (number == 0)
                return "không";

            int intPart = (int)number;
            int decimalPart = (int)((number - intPart) * 100);

            string intPartWords = ConvertIntToWords(intPart);
            string decimalPartWords = ConvertIntToWords(decimalPart);

            if (decimalPart == 0)
            {
                return intPartWords;
            }
            else
            {
                return $"{intPartWords} phẩy {decimalPartWords}";
            }
        }

        private string ConvertIntToWords(int number)
        {
            if (number == 0)
                return "không";

            if (number < 0)
                return $"âm {ConvertIntToWords(Math.Abs(number))}";

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += $"{ConvertIntToWords(number / 1000000)} triệu ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += $"{ConvertIntToWords(number / 1000)} nghìn ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += $"{ConvertIntToWords(number / 100)} trăm ";
                number %= 100;
            }

            if (number > 0)
            {
                //if (words != "")
                //    words += "và ";

                if (number < 20)
                    words += UnitsMap[number];
                else
                {
                    words += TensMap[number / 10];
                    if ((number % 10) > 0)
                        words += $" {UnitsMap[number % 10]}";
                }
            }

            return words.Trim();
        }

        private void radtheongay_CheckedChanged(object sender, EventArgs e)
        {
            if (radtheongay.Checked) { dttheongay.Enabled = true; dttheongay.Checked = true; }
            else { dttheongay.Enabled = false; dttheongay.Checked = false; }
        }

        private void radtheokhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (radtheokhoang.Checked)
            {
                dttungay.Enabled = true; dtdenngay.Enabled = true;
                dttungay.Checked = true; dtdenngay.Checked = true;
            }
            else
            {
                dttungay.Enabled = false; dtdenngay.Enabled = false;
                dttungay.Checked = false; dtdenngay.Checked = false;
            }
        }

        private void btninbaocao_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];

            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1"].Font.Size = 16;
            exRange.Range["A1"].Font.Name = "Times New Roman";
            exRange.Range["A1"].Font.Bold = true;
            exRange.Range["A1"].Font.Color = Color.Brown;

            exRange.Range["A1:A2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A1"].Value = "Charm Cosmetics";

            exRange.Range["A4:I4"].Font.Size = 16;
            exRange.Range["A4:I4"].Font.Name = "Times New Roman";
            exRange.Range["A4:I4"].Font.Bold = true;
            exRange.Range["A4:I4"].Font.Color = Color.Red;
            exRange.Range["A4:I4"].MergeCells = true;
            exRange.Range["A4:I4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A4:I4"].Value = "BÁO CÁO DOANH THU";

            // Lấy thông tin chi tiết hóa đơn bán
            sql = "SELECT hd.Sohdb, hd.Ngayban, ct.Mahang, h.Tenhanghoa, ct.Soluong, ct.Dongia, ct.Giamgia, (ct.Soluong * ct.Dongia - ct.Giamgia) as Thanhtien " +
                                       "FROM tblchitiethdb ct " +
                                       "JOIN tbldmhanghoa h ON ct.Mahang = h.Mahang " +
                                       "JOIN tblhoadonban hd ON ct.Sohdb = hd.Sohdb ";
            DataTable tbldoanhthu = Functions.GetDataToTable(sql);
            
            // Tạo dòng tiêu đề bảng
            exRange.Range["A6:I6"].Font.Bold = true;
            exRange.Range["A6:I6"].Font.Size = 12;
            exRange.Range["A6:I6"].Font.Name = "Times New Roman";
            exRange.Range["A6:I6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6"].ColumnWidth = 5;
            exRange.Range["B6"].ColumnWidth = 12;
            exRange.Range["C6"].ColumnWidth = 15;
            exRange.Range["D6"].ColumnWidth = 8;
            exRange.Range["E6"].ColumnWidth = 53;
            exRange.Range["F6:I6"].ColumnWidth = 11;

            exRange.Range["A6:A6"].Value = "STT";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn";
            exRange.Range["C6:C6"].Value = "Ngày bán";
            exRange.Range["D6:D6"].Value = "Mã hàng";
            exRange.Range["E6:E6"].Value = "Tên hàng";
            exRange.Range["F6:F6"].Value = "Số lượng";
            exRange.Range["G6:G6"].Value = "Đơn giá";
            exRange.Range["H6:H6"].Value = "Giảm giá";
            exRange.Range["I6:I6"].Value = "Thành tiền";

            for (hang = 0; hang <= tbldoanhthu.Rows.Count - 1; hang++)
            {
                // Điền số thứ tự vào cột 1 từ dòng 7
                exSheet.Cells[hang + 7, 1] = hang + 1;
                exSheet.Cells[hang + 7, 1].Font.Size = 12;
                exSheet.Cells[hang + 7, 1].Font.Name = "Times New Roman";
                for (cot = 0; cot <= tbldoanhthu.Columns.Count - 1; cot++)
                {
                    if (tbldoanhthu.Columns[cot].ColumnName == "Ngayban")
                    {
                        DateTime ngayban = (DateTime)tbldoanhthu.Rows[hang][cot];
                        exSheet.Cells[hang + 7, cot + 2] = ngayban.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        // Điền thông tin hàng từ cột thứ 2, dòng 7
                        exSheet.Cells[hang + 7, cot + 2] = tbldoanhthu.Rows[hang][cot].ToString();
                    }
                    // Điền thông tin hàng từ cột thứ 2, dòng 7
                    exSheet.Cells[hang + 7, cot + 2].Font.Size = 12;
                    exSheet.Cells[hang + 7, cot + 2].Font.Name = "Times New Roman";
                }
            }

            exRange = exSheet.Cells[hang + 8, 1];
            exRange.Font.Bold = true;
            exRange.Font.Size = 12;
            exRange.Font.Name = "Times New Roman";
            exRange.Value2 = "Tổng tiền:" + txttongtien.Text.ToString();


            exRange = exSheet.Cells[hang + 9, 1];
            exRange.Range["A1"].Font.Italic = true;
            exRange.Range["A1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(txttongtien.Text.ToString());

            exRange = exSheet.Cells[hang + 11, cot - 1];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].Font.Name = "Times New Roman";
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;

            exRange = exSheet.Cells[hang + 12, cot - 1];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].Font.Bold = true;
            exRange.Range["A1:C1"].Font.Name = "Times New Roman";
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "Nhân viên lập báo cáo";


            exSheet.Name = "Báo cáo doanh thu";
            exApp.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
