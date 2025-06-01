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
    public partial class Timkiemhoadonban : Form
    {
        public Timkiemhoadonban()
        {
            InitializeComponent();
        }

        private void Timkiemhoadonnhap_Load(object sender, EventArgs e)
        {
            ResetValues();
            Functions.FillCombo("SELECT Sohdb FROM tblhoadonban", cboMaHDB, "Sohdb", "Sohdb");
            cboMaHDB.SelectedIndex = -1;
            Functions.FillCombo("SELECT Manhanvien, Tennhanvien FROM tblnhanvien", cboMaNhanVien, "Manhanvien", "Manhanvien");
            cboMaNhanVien.SelectedIndex = -1;
            Functions.FillCombo("SELECT Makhach, Tenkhach FROM tblkhachhang", cboMaKhachHang, "Makhach", "Makhach");
            cboMaKhachHang.SelectedIndex = -1;string sql = "SELECT * FROM tblhoadonban WHERE 1=1";
            tblHDB = Functions.GetDataToTable(sql);
            dgvTimKiemHDB.DataSource = tblHDB;
        }
        DataTable tblHDB;

        private void Load_DataGridView()
        {
            dgvTimKiemHDB.Columns[0].HeaderText = "Mã hóa đơn bán";
            dgvTimKiemHDB.Columns[1].HeaderText = "Mã nhân viên";
            dgvTimKiemHDB.Columns[2].HeaderText = "Ngày bán";
            dgvTimKiemHDB.Columns[3].HeaderText = "Mã khách hàng";
            dgvTimKiemHDB.Columns[4].HeaderText = "Tổng tiền";
            dgvTimKiemHDB.Columns[0].Width = 150;
            dgvTimKiemHDB.Columns[1].Width = 150;
            dgvTimKiemHDB.Columns[2].Width = 125;
            dgvTimKiemHDB.Columns[3].Width = 125;
            dgvTimKiemHDB.Columns[4].Width = 125;
            dgvTimKiemHDB.AllowUserToAddRows = false;
            dgvTimKiemHDB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            cboMaHDB.Text = "";
            cboMaHDB.Focus();
            cboMaNhanVien.Text = "";
            cboMaKhachHang.Text = "";
            rdoTheoNgay.Checked = false;
            dtpNgayBan.Value = DateTimePicker.MinimumDateTime;
            dtpNgayBan.Checked = false;
            dtpNgayBan.Enabled = false;
            rdoTheoKhoang.Checked = false;
            grbKhoangNgay.Enabled = false;
            dtpNgayBD.Value = DateTimePicker.MinimumDateTime;
            dtpNgayBD.Checked = false;
            dtpNgayKT.Value = DateTimePicker.MinimumDateTime;
            dtpNgayKT.Checked = false;
            txtTongTien.Text = "";
        }

        private void dgvTimKiemHDB_DoubleClick(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết hóa đơn bán này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string mahoadonban = dgvTimKiemHDB.CurrentRow.Cells["Sohdb"].Value.ToString();
                Forms.Chitiethoadonban formchitiet = new Forms.Chitiethoadonban(mahoadonban);
                formchitiet.Show();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboMaHDB.Text == "") && (cboMaNhanVien.Text == "") && (cboMaKhachHang.Text == "") && (txtTongTien.Text == "") && (!dtpNgayBan.Checked) && (!dtpNgayBD.Checked) && (!dtpNgayKT.Checked))
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((dtpNgayBD.Checked && !dtpNgayKT.Checked) || (!dtpNgayBD.Checked && dtpNgayKT.Checked))
            {
                MessageBox.Show("Hãy nhập đầy đủ cả ngày bắt đầu và ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblhoadonban WHERE 1=1";
            if (cboMaHDB.Text != "")
                sql = sql + " AND Sohdb LIKE N'%" + cboMaHDB.Text + "%'";
            if (cboMaNhanVien.Text != "")
                sql = sql + " AND Manhanvien LIKE N'%" + cboMaNhanVien.Text + "%'";
            if (cboMaKhachHang.Text != "")
                sql = sql + " AND Makhach LIKE N'%" + cboMaKhachHang.Text + "%'";
            if (txtTongTien.Text != "")
                sql = sql + " AND Tongtien <=" + txtTongTien.Text;
            if (dtpNgayBan.Checked)
                sql = sql + " AND CONVERT(date, Ngayban) = '" + dtpNgayBan.Value.ToString("yyyy-MM-dd") + "'";
            if (dtpNgayBD.Checked && dtpNgayKT.Checked)
            {
                if (dtpNgayBD.Value > dtpNgayKT.Value)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                    sql = sql + " AND (CONVERT(date, Ngayban) BETWEEN '" + dtpNgayBD.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpNgayKT.Value.ToString("yyyy-MM-dd") + "')";
            }
            tblHDB = Functions.GetDataToTable(sql);
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn bán nào thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblHDB.Rows.Count + " hóa đơn bán thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvTimKiemHDB.DataSource = tblHDB;
            Load_DataGridView();
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimKiemHDB.DataSource = null;
        }

        private void rdoTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoNgay.Checked == true)
                dtpNgayBan.Enabled = true;
            else
            {
                dtpNgayBan.Value = DateTimePicker.MinimumDateTime;
                dtpNgayBan.Checked = false;
                dtpNgayBan.Enabled = false;
            }
        }

        private void rdoTheoKhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoKhoang.Checked == true)
                grbKhoangNgay.Enabled = true;
            else
            {
                grbKhoangNgay.Enabled = false;
                dtpNgayBD.Value = DateTimePicker.MinimumDateTime;
                dtpNgayBD.Checked = false;
                dtpNgayKT.Value = DateTimePicker.MinimumDateTime;
                dtpNgayKT.Checked = false;
            }
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
