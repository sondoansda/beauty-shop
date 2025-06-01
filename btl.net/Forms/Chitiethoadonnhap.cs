using btl.net.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace btl.net.Forms
{
    public partial class Chitiethoadonnhap : Form
    {
        private string mahoadonnhap;
        public Chitiethoadonnhap(string mahoadonnhap)
        {
            InitializeComponent();
            this.mahoadonnhap = mahoadonnhap;
        }

        private void Chitiethoadonnhap_Load(object sender, EventArgs e)
        {
            txtmahoadon.Text = mahoadonnhap;

            txtmahang.Enabled = false;
            txtmahang.Text = "";
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtsoluong.Text = "0";
            txtdongianhap.Text = "0";
            txtgiamgia.Text = "0";
            txtthanhtien.Text = "0";
            Load_DataGridView();
            string str;
            str = "Select Tongtien from tblhoadonnhap where Sohdn =N'" + txtmahoadon.Text.Trim() + "'";
            txttongtien.Text = Functions.GetFieldValues(str);
        }
        DataTable tblchitiethoadonnhap, tblhoadonnhap;

        private void ResetValues()
        {
            txtmahang.Text = "";
            txtmahang.Enabled = false;
            txttenhang.Text = "";
            txtdongianhap.Text = "0";
            txtgiamgia.Text = "0";
            txtthanhtien.Text = "0";
            txtsoluong.Text = "0";
            //txttongtien.Text= "0";
            txtmahoadon.Enabled = false;

        }

        

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT hd.Sohdn, hd.Mahang, h.Tenhanghoa, hd.Soluong, hd.Dongia, hd.Giamgia, hd.Thanhtien " + "FROM tblchitiethdn hd JOIN tbldmhanghoa h ON hd.Mahang = h.Mahang " + "WHERE hd.Sohdn = N'" + txtmahoadon.Text + "'";

            tblchitiethoadonnhap = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblchitiethoadonnhap;
            DataGridView.Columns[0].HeaderText = "Mã hóa đơn";
            DataGridView.Columns[1].HeaderText = "Mã hàng";
            DataGridView.Columns[2].HeaderText = "Tên hàng";
            DataGridView.Columns[3].HeaderText = "Số lượng";
            DataGridView.Columns[4].HeaderText = "Đơn giá";
            DataGridView.Columns[5].HeaderText = "Giảm giá";
            DataGridView.Columns[6].HeaderText = "Thành tiền";
            DataGridView.Columns[0].Width = 90;
            DataGridView.Columns[1].Width = 80;
            DataGridView.Columns[2].Width = 160;
            DataGridView.Columns[3].Width = 80;
            DataGridView.Columns[4].Width = 80;
            DataGridView.Columns[5].Width = 90;
            DataGridView.Columns[6].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtmahang.Enabled = true;
            txtmahang.Focus();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtmahang.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahang.Focus();
                return;
            }

            if (txtsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }
            if (txtdongianhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdongianhap.Focus();
                return;
            }
            if (txttenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenhang.Focus();
                return;
            }

            if (int.TryParse(txtsoluong.Text, out int soluong) && float.TryParse(txtdongianhap.Text, out float dongianhap) && float.TryParse(txtgiamgia.Text, out float giamgia))
            {
                float thanhtien1 = soluong * dongianhap;
                float tiengiamgia = thanhtien1 * (giamgia / 100);
                float thanhtien = thanhtien1 - tiengiamgia;
                txtthanhtien.Text = thanhtien.ToString();
                double tong, tongmoi;
                tong = Convert.ToDouble(txttongtien.Text);
                tongmoi = tong + thanhtien;
                txttongtien.Text = tongmoi.ToString();
                sql = "UPDATE tblhoadonnhap SET Tongtien = " + tongmoi.ToString() + " WHERE Sohdn = N'" + txtmahoadon.Text + "'";
                Functions.RunSql(sql);

                // Thêm hoặc cập nhật tblchitiethdn
                sql = "INSERT INTO tblchitiethdn(Sohdn, Mahang, Dongia, Soluong, Giamgia, Thanhtien) " +
                      "VALUES(N'" + txtmahoadon.Text.Trim() + "', N'" + txtmahang.Text.Trim() + "', " + dongianhap + ", " + soluong + ", " + giamgia + ", " + thanhtien + ")";
                Functions.RunSql(sql);

                // Tính đơn giá bán
                float dongiaban = dongianhap * 1.10f;

                // Kiểm tra xem mã hàng đã tồn tại trong tbldmhanghoa chưa
                sql = "SELECT COUNT(*) FROM tbldmhanghoa WHERE Mahang = N'" + txtmahang.Text.Trim() + "'";
                int count = Convert.ToInt32(Functions.GetFieldValues(sql));

                if (count == 0)
                {
                    // Nếu mã hàng chưa tồn tại, thêm mới
                    sql = "INSERT INTO tbldmhanghoa(Mahang, Tenhanghoa, Dongianhap, Soluong, Dongiaban) " +
                          "VALUES(N'" + txtmahang.Text.Trim() + "', N'" + txttenhang.Text.Trim() + "', " + dongianhap + ", " + soluong + ", " + dongiaban + ")";
                }
                else
                {
                    // Nếu mã hàng đã tồn tại, cập nhật thông tin
                    sql = "UPDATE tbldmhanghoa SET Tenhanghoa = N'" + txttenhang.Text.Trim() + "', " +
                          "Dongianhap = " + dongianhap + ", " +
                          "Soluong = Soluong + " + soluong + ", " +
                          "Dongiaban = " + dongiaban + " " +
                          "WHERE Mahang = N'" + txtmahang.Text.Trim() + "'";
                }
                Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnBoqua.Enabled = false;
                btnLuu.Enabled = false;
                txtmahang.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đúng định dạng cho số lượng, đơn giá và giảm giá.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtmahoadon_TextChanged(object sender, EventArgs e)
        {
            string str;
            str = "Select Ngaynhap from tblhoadonnhap where Sohdn =N'" + txtmahoadon.Text + "'";
            txtngaynhap.Text = Functions.GetFieldValues(str);
            str = "Select Manhanvien from tblhoadonnhap where Sohdn =N'" + txtmahoadon.Text + "'";
            txtmanhanvien.Text = Functions.GetFieldValues(str);
            str = "Select Mancc from tblhoadonnhap where Sohdn =N'" + txtmahoadon.Text + "'";
            txtmancc.Text = Functions.GetFieldValues(str);
        }

        private void txtmanhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            str = "Select Tennhanvien from tblnhanvien where Manhanvien =N'" + txtmanhanvien.Text + "'";
            txttennv.Text = Functions.GetFieldValues(str);
        }

        private void txtmancc_TextChanged(object sender, EventArgs e)
        {
            string str;
            str = "Select Tenncc from tblnhacungcap where Mancc =N'" + txtmancc.Text + "'";
            txttenncc.Text = Functions.GetFieldValues(str);
            str = "Select Diachi from tblnhacungcap where Mancc =N'" + txtmancc.Text + "'";
            txtdiachi.Text = Functions.GetFieldValues(str);
            str = "Select Dienthoai from tblnhacungcap where Mancc =N'" + txtmancc.Text + "'";
            txtsdt.Text = Functions.GetFieldValues(str);
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahang.Focus();
                return;
            }
            if (tblchitiethoadonnhap.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmahang.Text = DataGridView.CurrentRow.Cells["Mahang"].Value.ToString();
            txttenhang.Text = DataGridView.CurrentRow.Cells["Tenhanghoa"].Value.ToString();
            txtdongianhap.Text = DataGridView.CurrentRow.Cells["Dongia"].Value.ToString();
            txtsoluong.Text = DataGridView.CurrentRow.Cells["Soluong"].Value.ToString();
            txtgiamgia.Text = DataGridView.CurrentRow.Cells["Giamgia"].Value.ToString();
            txtthanhtien.Text = DataGridView.CurrentRow.Cells["Thanhtien"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
            txtmahang.Enabled = false;
        }

        private void txtmahang_TextChanged(object sender, EventArgs e)
        {
            string str;
            str = "Select Tenhanghoa from tbldmhanghoa where Mahang =N'" + txtmahang.Text + "'";
            txttenhang.Text = Functions.GetFieldValues(str);
            str = "Select Dongianhap from tbldmhanghoa where Mahang =N'" + txtmahang.Text + "'";
            txtdongianhap.Text = Functions.GetFieldValues(str);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            string sql;

            if (txtmahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahang.Focus();
                return;
            }

            if (txtsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }

            if (!int.TryParse(txtsoluong.Text, out int soluongMoi) || !float.TryParse(txtdongianhap.Text, out float dongiaMoi))
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "SELECT Soluong, Dongia FROM tblchitiethdn WHERE Sohdn = N'" + txtmahoadon.Text.Trim() + "' AND Mahang = N'" + txtmahang.Text.Trim() + "'";
            DataTable dt = Functions.GetDataToTable(sql);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int soluongCu = Convert.ToInt32(dt.Rows[0]["Soluong"]);
                float dongiaCu = Convert.ToSingle(dt.Rows[0]["Dongia"]);
                float thanhtienCu = soluongCu * dongiaCu;

                float thanhtienMoi = soluongMoi * dongiaMoi;
                double tong = Convert.ToDouble(txttongtien.Text);
                double tongmoi = tong - thanhtienCu + thanhtienMoi;
                txttongtien.Text = tongmoi.ToString();

                string updatetongtien = "UPDATE tblhoadonnhap SET Tongtien = " + tongmoi.ToString() + " WHERE Sohdn = N'" + txtmahoadon.Text.Trim() + "'";
                Functions.RunSql(updatetongtien);

                string updatesql = "UPDATE tblchitiethdn SET Soluong = " + soluongMoi.ToString() + ", Dongia = " + dongiaMoi.ToString() +
                        " WHERE Sohdn = N'" + txtmahoadon.Text.Trim() + "' AND Mahang = N'" + txtmahang.Text.Trim() + "'";
                Functions.RunSql(updatesql);

                // Cập nhật lại số lượng hàng trong tbldmhanghoa
                sql = "UPDATE tbldmhanghoa SET Soluong = Soluong - " + soluongCu + " + " + soluongMoi + " WHERE Mahang = N'" + txtmahang.Text.Trim() + "'";
                Functions.RunSql(sql);

                // Cập nhật đơn giá (đơn giá bán = đơn giá nhập x 110%)
                float dongiaBan = dongiaMoi * 1.1f;
                sql = "UPDATE tbldmhanghoa SET Dongiaban = " + dongiaBan.ToString() + ", Dongianhap = " + dongiaMoi.ToString() + " WHERE Mahang = N'" + txtmahang.Text.Trim() + "'";
                Functions.RunSql(sql);
                }

                Load_DataGridView();
                ResetValues();
            

        

        }

        private void btnin_Click(object sender, EventArgs e)
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
            
            exRange.Range["A4:F4"].Font.Size = 16;
            exRange.Range["A4:F4"].Font.Name = "Times New Roman";
            exRange.Range["A4:F4"].Font.Bold = true;
            exRange.Range["A4:F4"].Font.Color = Color.Red;
            exRange.Range["A4:F4"].MergeCells = true;
            exRange.Range["A4:F4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A4:F4"].Value = "HÓA ĐƠN NHẬP HÀNG";

            // Biểu diễn thông tin chung của hóa đơn 
            sql = "SELECT hd.Sohdn, nv.Tennhanvien, ncc.Tenncc, hd.Ngaynhap, hd.Tongtien " +
                  "FROM tblhoadonnhap hd JOIN tblnhanvien nv ON hd.Manhanvien = nv.Manhanvien " +
                  "JOIN tblnhacungcap ncc ON hd.Mancc = ncc.Mancc " +
                  "WHERE hd.Sohdn = N'" + txtmahoadon.Text + "'";
            DataTable tblhoadonnhap = Functions.GetDataToTable(sql);

            DateTime ngaynhap = (DateTime)tblhoadonnhap.Rows[0]["Ngaynhap"];
            string ngaynhap1 = ngaynhap.ToString("dd/MM/yyyy");

            exRange.Range["A6:C9"].Font.Size = 12;
            exRange.Range["A6:C9"].Font.Name = "Times New Roman";
            exRange.Range["A6:A9"].Font.Bold = true;
            exRange.Range["A6"].Value = "Mã hóa đơn:";
            exRange.Range["C6"].Value = tblhoadonnhap.Rows[0]["Sohdn"].ToString();
            exRange.Range["A7"].Value = "Tên nhân viên:";
            exRange.Range["C7"].Value = tblhoadonnhap.Rows[0]["Tennhanvien"].ToString();
            exRange.Range["A8"].Value = "Tên nhà cung cấp:";
            exRange.Range["C8"].Value = tblhoadonnhap.Rows[0]["Tenncc"].ToString();
            exRange.Range["A9"].Value = "Ngày nhập:";
            exRange.Range["C9"].Value = ngaynhap1;

            // Lấy thông tin chi tiết hóa đơn nhập
            sql = "SELECT ct.Mahang, hh.Tenhanghoa, ct.Soluong, ct.Dongia, ct.Giamgia, ct.Thanhtien " +
                  "FROM tblchitiethdn ct JOIN tbldmhanghoa hh ON ct.Mahang = hh.Mahang " +
                  "WHERE ct.Sohdn = N'" + txtmahoadon.Text + "'";
            DataTable tblchitiethdn = Functions.GetDataToTable(sql);

            // Tạo dòng tiêu đề bảng
            exRange.Range["A11:G11"].Font.Bold = true;
            exRange.Range["A11:G11"].Font.Size = 12;
            exRange.Range["A11:G11"].Font.Name = "Times New Roman";
            exRange.Range["A11:G11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A11"].ColumnWidth = 5;
            exRange.Range["B11"].ColumnWidth = 11;
            exRange.Range["C11"].ColumnWidth = 30;
            exRange.Range["D11:F11"].ColumnWidth = 11;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Mã hàng";
            exRange.Range["C11:C11"].Value = "Tên hàng";
            exRange.Range["D11:D11"].Value = "Số lượng";
            exRange.Range["E11:E11"].Value = "Đơn giá";
            exRange.Range["F11:F11"].Value = "Giảm giá";
            exRange.Range["G11:G11"].Value = "Thành tiền";

            for (hang = 0; hang <= tblchitiethdn.Rows.Count - 1; hang++)
            {
                // Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[hang + 12, 1] = hang + 1;
                exSheet.Cells[hang + 12, 1].Font.Size = 12;
                exSheet.Cells[hang + 12, 1].Font.Name = "Times New Roman";
                for (cot = 0; cot <= tblchitiethdn.Columns.Count - 1; cot++)
                {
                    // Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[hang + 12, cot + 2] = tblchitiethdn.Rows[hang][cot].ToString();
                    exSheet.Cells[hang + 12, cot + 2].Font.Size = 12;
                    exSheet.Cells[hang + 12, cot + 2].Font.Name = "Times New Roman";
                }
            }

            exRange = exSheet.Cells[hang + 13, 5];
            exRange.Font.Bold = true;
            exRange.Font.Size = 12;
            exRange.Font.Name = "Times New Roman";
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[hang + 13, 6];
            exRange.Font.Bold = true;
            exRange.Font.Size = 12;
            exRange.Font.Name = "Times New Roman";
            exRange.Value2 = tblhoadonnhap.Rows[0]["Tongtien"].ToString();

            //exRange = exSheet.Cells[hang + 14, 1];
            //exRange.Range["A1:F1"].MergeCells = true;
            //exRange.Range["A1:F1"].Font.Italic = true;
            //exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["A1:F1"].Value = "Bằng chữ: " + Functions.ChuyenSoSangChu(tblhoadonnhap.Rows[0]["Tongtien"].ToString());

            exRange = exSheet.Cells[hang + 16, cot + 0];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].Font.Name = "Times New Roman";
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;

            exRange = exSheet.Cells[hang + 17, cot + 0];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].Font.Bold = true;
            exRange.Range["A1:C1"].Font.Name = "Times New Roman";
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "Nhân viên nhập hàng";

            exRange = exSheet.Cells[hang + 22, cot + 0];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Bold = true;
            exRange.Range["A1:C1"].Font.Name = "Times New Roman";
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = tblhoadonnhap.Rows[0]["Tennhanvien"].ToString();

            exSheet.Name = "Hóa đơn nhập hàng";
            exApp.Visible = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblchitiethoadonnhap.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // Lấy các giá trị từ các trường
                int soluong = int.Parse(txtsoluong.Text);
                float dongia = float.Parse(txtdongianhap.Text);
                float giamgia = float.Parse(txtgiamgia.Text);

                // Tính toán lại thành tiền
                float thanhtien1 = soluong * dongia;
                float tiengiamgia = thanhtien1 * (giamgia / 100);
                float thanhtien = thanhtien1 - tiengiamgia;
                txtthanhtien.Text = thanhtien.ToString();

                // Cập nhật tổng tiền trong tblhoadonnhap
                double tong = Convert.ToDouble(txttongtien.Text);
                double tongmoi = tong - thanhtien;
                txttongtien.Text = tongmoi.ToString();
                sql = "UPDATE tblhoadonnhap SET Tongtien = " + tongmoi.ToString() + " WHERE Sohdn = N'" + txtmahoadon.Text + "'";
                Functions.RunSql(sql);

                // Xóa bản ghi trong tblchitiethdn
                sql = "DELETE FROM tblchitiethdn WHERE Sohdn = N'" + txtmahoadon.Text.Trim() + "' AND Mahang = N'" + txtmahang.Text.Trim() + "'";
                Functions.RunSqlDel(sql);

                // Cập nhật lại số lượng hàng trong tbldmhanghoa
                sql = "UPDATE tbldmhanghoa SET Soluong = Soluong - " + soluong + " WHERE Mahang = N'" + txtmahang.Text.Trim() + "'";
                Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            UpdateThanhTien();
        }

        private void txtdongianhap_TextChanged(object sender, EventArgs e)
        {
            UpdateThanhTien();
        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            UpdateThanhTien();
        }

        private void UpdateThanhTien()
        {
            if (int.TryParse(txtsoluong.Text, out int soluong) && float.TryParse(txtdongianhap.Text, out float dongia))
            {
                float giamgia = 0;
                if (txtgiamgia.Text!="0")
                {
                    float.TryParse(txtgiamgia.Text, out giamgia);
                }
                float thanhtien = soluong * dongia - giamgia;
                txtthanhtien.Text = thanhtien.ToString();
            }
        }
    }
}
