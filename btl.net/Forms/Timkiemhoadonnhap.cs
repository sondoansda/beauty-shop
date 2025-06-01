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
    public partial class Timkiemhoadonnhap : Form
    {
        public Timkiemhoadonnhap()
        {
            InitializeComponent();
        }

        private void Timkiemhoadonnhap_Load(object sender, EventArgs e)
        {
            ResetValues();
            Functions.FillCombo("SELECT Sohdn FROM tblhoadonnhap", cboMaHDN, "Sohdn", "Sohdn");
            cboMaHDN.SelectedIndex = -1;
            Functions.FillCombo("SELECT Manhanvien FROM tblnhanvien", cboMaNhanVien, "Manhanvien", "Manhanvien");
            cboMaNhanVien.SelectedIndex = -1;
            Functions.FillCombo("SELECT Mancc FROM tblnhacungcap", cboMaNCC, "Mancc", "Mancc");
            cboMaNCC.SelectedIndex = -1;
            string sql = "SELECT * FROM tblhoadonnhap WHERE 1=1";
            tblHoaDonNhap = Functions.GetDataToTable(sql);
            dgvTimKiemHDN.DataSource = tblHoaDonNhap;
        }
        DataTable tblHoaDonNhap;
        private void Load_DataGridView()
        {
            dgvTimKiemHDN.Columns[0].HeaderText = "Mã hóa đơn nhập";
            dgvTimKiemHDN.Columns[1].HeaderText = "Ngày bán";
            dgvTimKiemHDN.Columns[2].HeaderText = "Mã nhân viên";
            dgvTimKiemHDN.Columns[3].HeaderText = "Mã nhà cung cấp";
            dgvTimKiemHDN.Columns[4].HeaderText = "Tổng tiền";
            dgvTimKiemHDN.Columns[0].Width = 150;
            dgvTimKiemHDN.Columns[1].Width = 150;
            dgvTimKiemHDN.Columns[2].Width = 125;
            dgvTimKiemHDN.Columns[3].Width = 125;
            dgvTimKiemHDN.Columns[4].Width = 125;
            dgvTimKiemHDN.AllowUserToAddRows = false;
            dgvTimKiemHDN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void ResetValues()
        {
            cboMaHDN.Text = "";
            cboMaHDN.Focus();
            cboMaNhanVien.Text = "";
            cboMaNCC.Text = "";
            rdoTheoNgay.Checked = false;
            dtpNgayNhap.Value = DateTimePicker.MinimumDateTime;
            dtpNgayNhap.Checked = false;
            dtpNgayNhap.Enabled = false;
            rdoTheoKhoang.Checked = false;
            grbKhoangNgay.Enabled = false;
            dtpNgayBD.Value = DateTimePicker.MinimumDateTime;
            dtpNgayBD.Checked = false;
            dtpNgayKT.Value = DateTimePicker.MinimumDateTime;
            dtpNgayKT.Checked = false;
            txtTongTien.Text = "";
        }

        private void dgvTimKiemHDN_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết hóa đơn nhập này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string mahoadonnhap = dgvTimKiemHDN.CurrentRow.Cells["Sohdn"].Value.ToString();
                Forms.Chitiethoadonnhap formchitiet = new Forms.Chitiethoadonnhap(mahoadonnhap);
                formchitiet.Show();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboMaHDN.Text == "") && (cboMaNhanVien.Text == "") && (cboMaNCC.Text == "") && (txtTongTien.Text == "") && (!dtpNgayNhap.Checked) && (!dtpNgayBD.Checked) && (!dtpNgayKT.Checked))
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((dtpNgayBD.Checked && !dtpNgayKT.Checked) || (!dtpNgayBD.Checked && dtpNgayKT.Checked))
            {
                MessageBox.Show("Hãy nhập đầy đủ cả ngày bắt đầu và ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblhoadonnhap WHERE 1=1";
            if (cboMaHDN.Text != "")
                sql = sql + " AND Sohdn LIKE N'%" + cboMaHDN.Text + "%'";
            if (cboMaNhanVien.Text != "")
                sql = sql + " AND Manhanvien LIKE N'%" + cboMaNhanVien.Text + "%'";
            if (cboMaNCC.Text != "")
                sql = sql + " AND Mancc LIKE N'%" + cboMaNCC.Text + "%'";
            if (txtTongTien.Text != "")
                sql = sql + " AND Tongtien <=" + txtTongTien.Text;
            if (dtpNgayNhap.Checked)
                sql = sql + " AND CONVERT(date, Ngaynhap) = '" + dtpNgayNhap.Value.ToString("yyyy-MM-dd") + "'";
            if (dtpNgayBD.Checked && dtpNgayKT.Checked)
            {
                if (dtpNgayBD.Value > dtpNgayKT.Value)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                    sql = sql + " AND (CONVERT(date, Ngaynhap) BETWEEN '" + dtpNgayBD.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpNgayKT.Value.ToString("yyyy-MM-dd") + "')";
            }
            tblHoaDonNhap = Functions.GetDataToTable(sql);
            if (tblHoaDonNhap.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn nhập nào thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblHoaDonNhap.Rows.Count + " hóa đơn nhập thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgvTimKiemHDN.DataSource = tblHoaDonNhap;
            Load_DataGridView();
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimKiemHDN.DataSource = null;
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void rdoTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoNgay.Checked == true)
                dtpNgayNhap.Enabled = true;
            else
            {
                dtpNgayNhap.Value = DateTimePicker.MinimumDateTime;
                dtpNgayNhap.Checked = false;
                dtpNgayNhap.Enabled = false;
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

        
