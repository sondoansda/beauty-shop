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
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            txtMakhach.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            chkmakhach.Checked = false;
            chktenkhach.Checked = false;
            chksdt.Checked = false;
            txttksdt.Enabled = false;
            txttktenkhach.Enabled = false;
            txttkmakhach.Enabled = false;
            Load_DataGridView();
        }
        DataTable tblKH;

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Makhach, Tenkhach, Diachi, Dienthoai FROM tblkhachhang";
            tblKH = Class.Functions.GetDataToTable(sql);
            dgvKhach.DataSource = tblKH;
            dgvKhach.Columns[0].HeaderText = "Mã khách";
            dgvKhach.Columns[1].HeaderText = "Tên khách";
            dgvKhach.Columns[2].HeaderText = "Địa chỉ";
            dgvKhach.Columns[3].HeaderText = "Điện thoại";
            dgvKhach.Columns[0].Width = 100;
            dgvKhach.Columns[1].Width = 150;
            dgvKhach.Columns[2].Width = 150;
            dgvKhach.Columns[3].Width = 150;
            dgvKhach.AllowUserToAddRows = false;
            dgvKhach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
                        
        private void ResetValues()
        {
            txtMakhach.Text = "";
            txtTenkhach.Text = "";
            txtDiachi.Text = "";
            mskSodt.Text = "";
            chkmakhach.Checked = false;
            chktenkhach.Checked = false;
            chksdt.Checked = false;
            txttksdt.Enabled = false;
            txttktenkhach.Enabled = false;
            txttkmakhach.Enabled = false;
            txttkmakhach.Text = "";
            txttktenkhach.Text = "";
            txttksdt.Text = "";
        }
                
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txttkmakhach.Text == "") && (txttktenkhach.Text == "") && (txttksdt.Text == ""))
            {
                MessageBox.Show("Hãy nhập điều kiện để tìm kiếm!", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblkhachhang WHERE 1=1";
            if (txttkmakhach.Text != "")
                sql = sql + " AND Makhach LIKE N'%" + txttkmakhach.Text + "%'";
            if (txttktenkhach.Text != "")
                sql = sql + " AND Tenkhach LIKE N'%" + txttktenkhach.Text + "%'";
            if (txttksdt.Text != "")
                sql = sql + " AND Dienthoai LIKE N'%" + txttksdt.Text.Trim() + "%'";
            tblKH = Class.Functions.GetDataToTable(sql);
            if (tblKH.Rows.Count == 0)
                MessageBox.Show("Không có khách hàng nào thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblKH.Rows.Count + " khách hàng thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgvKhach.DataSource = tblKH;
            ResetValues();
        }

        private void dgvKhach_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhach.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMakhach.Text = dgvKhach.CurrentRow.Cells["Makhach"].Value.ToString();
            txtTenkhach.Text = dgvKhach.CurrentRow.Cells["Tenkhach"].Value.ToString();
            txtDiachi.Text = dgvKhach.CurrentRow.Cells["Diachi"].Value.ToString();
            mskSodt.Text = dgvKhach.CurrentRow.Cells["Dienthoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMakhach.Enabled = true;
            txtMakhach.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhach.Focus();
                return;
            }
            if (txtTenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhach.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskSodt.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSodt.Focus();
                return;
            }
            sql = "SELECT Makhach FROM tblkhachhang WHERE Makhach=N'" + txtMakhach.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhach.Focus();
                txtMakhach.Text = "";
                return;
            }
            sql = "INSERT INTO tblkhachhang(Makhach,Tenkhach,Diachi,Dienthoai) VALUES (N'" + txtMakhach.Text.Trim() + "',N'" + txtTenkhach.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "','" + mskSodt.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMakhach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhach.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskSodt.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSodt.Focus();
                return;
            }
            sql = "UPDATE tblkhachhang SET  Tenkhach=N'" + txtTenkhach.Text.Trim().ToString() + "',Diachi=N'" + txtDiachi.Text.Trim().ToString() + "',Dienthoai='" + mskSodt.Text.ToString() + "' WHERE Makhach=N'" + txtMakhach.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMakhach.Enabled = false;
        }

        private void txtMakhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenkhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");    
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn thức sự muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Makhach, Tenkhach, Diachi, Dienthoai FROM tblkhachhang";
            tblKH = Class.Functions.GetDataToTable(sql);
            dgvKhach.DataSource = tblKH;
        }

        private void chkmakhach_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmakhach.Checked)
            {
                txttkmakhach.Enabled = true;

            }
            else { txttkmakhach.Text = ""; txttkmakhach.Enabled = false; }
                
        }

        private void chktenkhach_CheckedChanged(object sender, EventArgs e)
        {
            if (chktenkhach.Checked) { txttktenkhach.Enabled = true; }
            else { txttktenkhach.Text = ""; txttktenkhach.Enabled = false; }
        }

        private void chksdt_CheckedChanged(object sender, EventArgs e)
        {
            if (chksdt.Checked) { txttksdt.Enabled = true; }
            else { txttksdt.Text = ""; txttksdt.Enabled = false; }
        }

        private void btndatlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            string sql = "SELECT Makhach, Tenkhach, Diachi, Dienthoai FROM tblkhachhang";
            tblKH = Class.Functions.GetDataToTable(sql);
            dgvKhach.DataSource = tblKH;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblkhachhang WHERE Makhach=N'" + txtMakhach.Text + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }
    }
}
