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

namespace btl.net.Forms
{
    public partial class Hoadonban : Form
    {
        public Hoadonban()
        {
            InitializeComponent();
        }

        private void Hoadonban_Load(object sender, EventArgs e)
        {
            txtmahoadon.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            Functions.FillCombo("SELECT Manhanvien FROM tblnhanvien", cbomanv, "Manhanvien", "Manhanvien");
            cbomanv.SelectedIndex = -1;
            
            ResetValues();
        }
        DataTable tblhoadonban;

        private void ResetValues()
        {
            txtmahoadon.Text = "";
            txtmakhach.Text = "";
            txtngayban.Text = "";
            txtsdt.Text = "";
            cbomanv.Text = "";
            txttongtien.Text = "0";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txttenkhach.Text = "";
            txttennv.Text = "";

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT hd.Sohdb, nv.Tennhanvien, k.Tenkhach, hd.Ngayban, hd.Tongtien " +
                   "FROM tblhoadonban hd JOIN tblnhanvien nv ON hd.Manhanvien = nv.Manhanvien " +
                   "JOIN tblkhachhang k ON hd.Makhach = k.Makhach";
            tblhoadonban = Functions.GetDataToTable(sql);
            dgvHD.DataSource = tblhoadonban;
            dgvHD.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHD.Columns[1].HeaderText = "Tên nhân viên";
            dgvHD.Columns[2].HeaderText = "Tên khách hàng";
            dgvHD.Columns[3].HeaderText = "Ngày bán";
            dgvHD.Columns[4].HeaderText = "Tổng tiền";
            dgvHD.Columns[0].Width = 100;
            dgvHD.Columns[1].Width = 100;
            dgvHD.Columns[2].Width = 150;
            dgvHD.Columns[3].Width = 100;
            dgvHD.Columns[4].Width = 100;
            dgvHD.AllowUserToAddRows = false;
            dgvHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtmahoadon.Enabled = true;
            txtmahoadon.Focus();
        }

        private void dgvHD_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahoadon.Focus();
                return;
            }
            if (tblhoadonban.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmahoadon.Text = dgvHD.CurrentRow.Cells["Sohdb"].Value.ToString();
            txttennv.Text = dgvHD.CurrentRow.Cells["Tennhanvien"].Value.ToString();
            txttenkhach.Text = dgvHD.CurrentRow.Cells["Tenkhach"].Value.ToString();
            txtngayban.Text = dgvHD.CurrentRow.Cells["Ngayban"].Value.ToString();
            txttongtien.Text = dgvHD.CurrentRow.Cells["Tongtien"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void cbomanv_TextChanged(object sender, EventArgs e)
        {
            string str;

            str = "Select Tennhanvien from tblnhanvien where Manhanvien =N'" + cbomanv.SelectedValue + "'";
            txttennv.Text = Functions.GetFieldValues(str);
        }

        

        private void txttennv_TextChanged(object sender, EventArgs e)
        {
            string str;
            str = "Select Manhanvien from tblnhanvien where Tennhanvien =N'" + txttennv.Text + "'";
            cbomanv.Text = Functions.GetFieldValues(str);
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblhoadonban.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmahoadon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "UPDATE tblhoadonban SET " + "Sohdb = N'" + txtmahoadon.Text.ToString() + "', " + "Manhanvien = N'" + cbomanv.Text.ToString() + "', " + "Tongtien = N'" + txttongtien.Text.ToString() + "', " + "Ngayban = N'" + txtngayban.Text.ToString() + "', " + "Makhahc = N'" + txtmakhach.Text.ToString() + "' " + "WHERE Sohdb = N'" + txtmahoadon.Text.ToString() + "'";

            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmahoadon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahoadon.Focus();
                return;
            }
            if (txtngayban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thông tin ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtngayban.Focus();
                return;
            }
            if (txtmakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakhach.Focus();
                return;
            }
            if (cbomanv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomanv.Focus();
                return;
            }

            sql = "SELECT Sohdb FROM tblhoadonban WHERE Sohdb=N'" + txtmahoadon.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hóa đơn này đã có, bạn phải nhập thông tin khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "INSERT INTO tblhoadonban(Sohdb, Manhanvien, Ngayban, Makhach, Tongtien) VALUES(N'" + txtmahoadon.Text.Trim() + "', N'" + cbomanv.Text.Trim() + "', N'" + txtngayban.Text.Trim() + "',N'" + txtmakhach.Text.Trim() + "', N'" + txttongtien.Text.Trim() + "')";

            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtmahoadon.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn thức sự muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblhoadonban.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmahoadon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "SELECT ct.Sohdb, ct.Mahang, h.Tenhanghoa, ct.Soluong, hd.Tongtien " +
                             "FROM tblchitiethdb ct " +
                             "JOIN tbldmhanghoa h ON ct.Mahang = h.Mahang " +
                             "JOIN tblhoadonban hd ON ct.Sohdb = hd.Sohdb " +
                             "WHERE hd.Sohdb = N'" + txtmahoadon.Text + "'";

                DataTable tblhdb = Functions.GetDataToTable(sql);
                foreach (DataRow row in tblhdb.Rows)
                {
                    string mahang = row["Mahang"].ToString();
                    string soluong = row["Soluong"].ToString();

                    // Cập nhật số lượng hàng trong tbldmhanghoa
                    sql = "UPDATE tbldmhanghoa SET Soluong = Soluong + " + soluong + " WHERE Mahang = N'" + mahang + "'";
                    Functions.RunSql(sql);
                }

                // Xóa bản ghi trong tblchitiethdb
                sql = "DELETE FROM tblchitiethdb WHERE Sohdb = N'" + txtmahoadon.Text.Trim() + "'";
                Functions.RunSqlDel(sql);

                // Xóa bản ghi trong tblhoadonban
                sql = "DELETE tblhoadonban  WHERE Sohdb = N'" + txtmahoadon.Text + "'";

                Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            ResetValues();
            string sql = "SELECT hd.Sohdb, nv.Tennhanvien, k.Tenkhach, hd.Ngayban, hd.Tongtien " +
                   "FROM tblhoadonban hd JOIN tblnhanvien nv ON hd.Manhanvien = nv.Manhanvien " +
                   "JOIN tblkhachhang k ON hd.Makhach = k.Makhach";
            tblhoadonban = Functions.GetDataToTable(sql);
            dgvHD.DataSource = tblhoadonban;
        }

        private void dgvHD_DoubleClick(object sender, EventArgs e)
        {
            string mahoadonban = dgvHD.CurrentRow.Cells["Sohdb"].Value.ToString();
            Forms.Chitiethoadonban formchitiet = new Forms.Chitiethoadonban(mahoadonban);
            formchitiet.Show();
        }

        private void txttenkhach_TextChanged(object sender, EventArgs e)
        {
            string str;
            str = "Select Makhach from tblkhachhang where Tenkhach =N'" + txttenkhach.Text + "'";
            txtmakhach.Text = Functions.GetFieldValues(str);
        }

        private void txtmakhach_Leave(object sender, EventArgs e)
        {
            string str = "SELECT COUNT(*) FROM tblkhachhang WHERE Makhach = N'" + txtmakhach.Text.Trim() + "'";
            int count = Convert.ToInt32(Functions.GetFieldValues(str));

            if (count > 0)
            {
                // Mã khách hàng đã tồn tại
                str = "SELECT Tenkhach FROM tblkhachhang WHERE Makhach = N'" + txtmakhach.Text + "'";
                txttenkhach.Text = Functions.GetFieldValues(str);
                str = "SELECT Diachi FROM tblkhachhang WHERE Makhach = N'" + txtmakhach.Text + "'";
                txtdiachi.Text = Functions.GetFieldValues(str);
                str = "SELECT Dienthoai FROM tblkhachhang WHERE Makhach = N'" + txtmakhach.Text + "'";
                txtsdt.Text = Functions.GetFieldValues(str);
            }
            else
            {
                // Mã khách hàng chưa tồn tại, cho phép nhập thông tin khách hàng mới
                txttenkhach.Text = string.Empty;
                txtdiachi.Text = string.Empty;
                txtsdt.Text = string.Empty;

                DialogResult result=MessageBox.Show("Khách hàng không tồn tại. Bạn có muốn thêm khách hàng mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txttenkhach.Text) || string.IsNullOrWhiteSpace(txtdiachi.Text) || string.IsNullOrWhiteSpace(txtsdt.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    str = "INSERT INTO tblkhachhang (Makhach, Tenkhach, Diachi, Dienthoai) VALUES (N'" + txtmakhach.Text.Trim() + "', N'" + txttenkhach.Text.Trim() + "', N'" + txtdiachi.Text.Trim() + "', N'" + txtsdt.Text.Trim() + "')";
                    Functions.RunSql(str);

                    MessageBox.Show("Đã thêm khách hàng mới thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
