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
    public partial class Hoadonnhap : Form
    {
        public Hoadonnhap()
        {
            InitializeComponent();
        }

        private void Hoadonnhap_Load(object sender, EventArgs e)
        {
            txtmahoadon.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            Functions.FillCombo("SELECT Manhanvien FROM tblnhanvien", cbomanv, "Manhanvien", "Manhanvien");
            cbomanv.SelectedIndex = -1;
            Functions.FillCombo("SELECT Mancc FROM tblnhacungcap", cbomancc, "Mancc", "Mancc");
            cbomancc.SelectedIndex = -1;
            ResetValues();
        }
        DataTable tblhoadonnhap;

        private void ResetValues()
        {
            txtmahoadon.Text = "";
            cbomancc.Text = "";
            txtngaynhap.Text = "";
            txtsdt.Text = "";
            cbomanv.Text = "";
            txttongtien.Text = "0";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txttenncc.Text = "";
            txttennv.Text = "";
            
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT hd.Sohdn, nv.Tennhanvien, ncc.Tenncc, hd.Ngaynhap, hd.Tongtien " +
                   "FROM tblhoadonnhap hd JOIN tblnhanvien nv ON hd.Manhanvien = nv.Manhanvien " +
                   "JOIN tblnhacungcap ncc ON hd.Mancc = ncc.Mancc";
            tblhoadonnhap = Functions.GetDataToTable(sql);
            dgvHD.DataSource = tblhoadonnhap;
            dgvHD.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHD.Columns[1].HeaderText = "Tên nhân viên";
            dgvHD.Columns[2].HeaderText = "Tên nhà cung cấp";
            dgvHD.Columns[3].HeaderText = "Ngày nhập";
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
            if (tblhoadonnhap.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmahoadon.Text = dgvHD.CurrentRow.Cells["Sohdn"].Value.ToString();
            txttennv.Text = dgvHD.CurrentRow.Cells["Tennhanvien"].Value.ToString();
            txttenncc.Text = dgvHD.CurrentRow.Cells["Tenncc"].Value.ToString();
            txtngaynhap.Text = dgvHD.CurrentRow.Cells["Ngaynhap"].Value.ToString();
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

        private void cbomancc_TextChanged(object sender, EventArgs e)
        {
            string str;
            
            str = "Select Tenncc from tblnhacungcap where Mancc =N'" + cbomancc.SelectedValue + "'";
            txttenncc.Text = Functions.GetFieldValues(str);
            str = "Select Diachi from tblnhacungcap where Mancc =N'" + cbomancc.SelectedValue + "'";
            txtdiachi.Text = Functions.GetFieldValues(str);
            str = "Select Dienthoai from tblnhacungcap where Mancc =N'" + cbomancc.SelectedValue + "'";
            txtsdt.Text = Functions.GetFieldValues(str);
        }

        private void txttennv_TextChanged(object sender, EventArgs e)
        {
            string str;
            str = "Select Manhanvien from tblnhanvien where Tennhanvien =N'" + txttennv.Text + "'";
            cbomanv.Text = Functions.GetFieldValues(str);
        }

        private void txttenncc_TextChanged(object sender, EventArgs e)
        {
            string str;
            str = "Select Mancc from tblnhacungcap where Tenncc =N'" + txttenncc.Text + "'";
            cbomancc.Text = Functions.GetFieldValues(str);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblhoadonnhap.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmahoadon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           sql = "UPDATE tblhoadonnhap SET " + "Sohdn = N'" + txtmahoadon.Text.ToString() + "', " + "Manhanvien = N'" + cbomanv.Text.ToString() + "', " + "Tongtien = N'" + txttongtien.Text.ToString() + "', " + "Ngaynhap = N'" + txtngaynhap.Text.ToString() + "', " + "Mancc = N'" + cbomancc.Text.ToString() + "' " + "WHERE Sohdn = N'" + txtmahoadon.Text.ToString() + "'";

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
            if (txtngaynhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thông tin ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtngaynhap.Focus();
                return;
            }
            if (cbomancc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thông tin nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomancc.Focus();
                return;
            }
            if (cbomanv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomanv.Focus();
                return;
            }

            sql = "SELECT Sohdn FROM tblhoadonnhap WHERE Sohdn=N'" + txtmahoadon.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hóa đơn này đã có, bạn phải nhập thông tin khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "INSERT INTO tblhoadonnhap(Sohdn, Manhanvien, Ngaynhap, Mancc, Tongtien) VALUES(N'" + txtmahoadon.Text.Trim() + "', N'" + cbomanv.Text.Trim() + "', N'" + txtngaynhap.Text.Trim() + "',N'" + cbomancc.Text.Trim() + "', N'" + txttongtien.Text.Trim() + "')";

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
            if (tblhoadonnhap.Rows.Count == 0)
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
                sql = "SELECT ct.Sohdn, ct.Mahang, h.Tenhanghoa, ct.Soluong, hd.Tongtien " +
                             "FROM tblchitiethdn ct " +
                             "JOIN tbldmhanghoa h ON ct.Mahang = h.Mahang " +
                             "JOIN tblhoadonnhap hd ON ct.Sohdn = hd.Sohdn " +
                             "WHERE hd.Sohdn = N'" + txtmahoadon.Text + "'";

                DataTable tblhdn = Functions.GetDataToTable(sql);
                foreach (DataRow row in tblhdn.Rows)
                {
                    string mahang = row["Mahang"].ToString();
                    string soluong = row["Soluong"].ToString();

                    // Cập nhật số lượng hàng trong tbldmhanghoa
                    sql = "UPDATE tbldmhanghoa SET Soluong = Soluong - " + soluong + " WHERE Mahang = N'" + mahang + "'";
                    Functions.RunSql(sql);
                }

                // Xóa bản ghi trong tblchitiethdn
                sql = "DELETE FROM tblchitiethdn WHERE Sohdn = N'" + txtmahoadon.Text.Trim() + "'";
                Functions.RunSqlDel(sql);

                // Xóa bản ghi trong tblhoadonnhap
                sql = "DELETE tblhoadonnhap  WHERE Sohdn = N'" + txtmahoadon.Text + "'";

                Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            ResetValues();
            string sql = "SELECT hd.Sohdn, nv.Tennhanvien, ncc.Tenncc, hd.Ngaynhap, hd.Tongtien " +
                         "FROM tblhoadonnhap hd JOIN tblnhanvien nv ON hd.Manhanvien = nv.Manhanvien " +
                         "JOIN tblnhacungcap ncc ON hd.Mancc = ncc.Mancc";
            tblhoadonnhap = Functions.GetDataToTable(sql);
            dgvHD.DataSource = tblhoadonnhap;
        }

        private void dgvHD_DoubleClick(object sender, EventArgs e)
        {
            string mahoadonnhap = dgvHD.CurrentRow.Cells["Sohdn"].Value.ToString();
            Forms.Chitiethoadonnhap formchitiet = new Forms.Chitiethoadonnhap(mahoadonnhap);
            formchitiet.Show();
        }
    }
}
