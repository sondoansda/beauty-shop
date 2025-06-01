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
    public partial class Nhacungcap : Form
    {
        public Nhacungcap()
        {
            InitializeComponent();
        }

        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            txtMancc.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            chkmancc.Checked = false;
            chktenncc.Checked = false;
            chksdt.Checked = false;
            txttksdt.Enabled = false;
            txttktenncc.Enabled = false;
            txttkmancc.Enabled = false;
            Load_DataGridView();
        }
        DataTable tblncc;

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Mancc, Tenncc, Diachi, Dienthoai FROM tblnhacungcap";
            tblncc = Class.Functions.GetDataToTable(sql);
            dgvNcc.DataSource = tblncc;
            dgvNcc.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNcc.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvNcc.Columns[2].HeaderText = "Địa chỉ";
            dgvNcc.Columns[3].HeaderText = "Điện thoại";
            dgvNcc.Columns[0].Width = 100;
            dgvNcc.Columns[1].Width = 180;
            dgvNcc.Columns[2].Width = 150;
            dgvNcc.Columns[3].Width = 150;
            dgvNcc.AllowUserToAddRows = false;
            dgvNcc.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMancc.Text = "";
            txtTenncc.Text = "";
            txtDiachi.Text = "";
            mskSodt.Text = "";
            chkmancc.Checked = false;
            chktenncc.Checked = false;
            chksdt.Checked = false;
            txttksdt.Enabled = false;
            txttktenncc.Enabled = false;
            txttkmancc.Enabled = false;
            txttkmancc.Text = "";
            txttktenncc.Text = "";
            txttksdt.Text = "";
        }

        private void dgvNcc_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMancc.Focus();
                return;
            }
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMancc.Text = dgvNcc.CurrentRow.Cells["Mancc"].Value.ToString();
            txtTenncc.Text = dgvNcc.CurrentRow.Cells["Tenncc"].Value.ToString();
            txtDiachi.Text = dgvNcc.CurrentRow.Cells["Diachi"].Value.ToString();
            mskSodt.Text = dgvNcc.CurrentRow.Cells["Dienthoai"].Value.ToString();
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
            txtMancc.Enabled = true;
            txtMancc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMancc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMancc.Focus();
                return;
            }
            if (txtTenncc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenncc.Focus();
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
            sql = "SELECT Mancc FROM tblnhacungcap WHERE Mancc=N'" + txtMancc.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà cung cấp này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMancc.Focus();
                txtMancc.Text = "";
                return;
            }
            sql = "INSERT INTO tblnhacungcap(Mancc,Tenncc,Diachi,Dienthoai) VALUES (N'" + txtMancc.Text.Trim() + "',N'" + txtTenncc.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "','" + mskSodt.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMancc.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenncc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenncc.Focus();
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
            sql = "UPDATE tblnhacungcap SET  Tenncc=N'" + txtTenncc.Text.Trim().ToString() + "',Diachi=N'" + txtDiachi.Text.Trim().ToString() + "',Dienthoai='" + mskSodt.Text.ToString() + "' WHERE Mancc=N'" + txtMancc.Text + "'";
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
            txtMancc.Enabled = false;
        }

        private void txtMancc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenncc_KeyUp(object sender, KeyEventArgs e)
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
            string sql = "SELECT Mancc, Tenncc, Diachi, Dienthoai FROM tblnhacungcap";
            tblncc = Class.Functions.GetDataToTable(sql);
            dgvNcc.DataSource = tblncc;
        }

        private void chkmancc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmancc.Checked)
            {
                txttkmancc.Enabled = true;

            }
            else { txttkmancc.Text = ""; txttkmancc.Enabled = false; }
        }

        private void chktenncc_CheckedChanged(object sender, EventArgs e)
        {
            if (chktenncc.Checked) { txttktenncc.Enabled = true; }
            else { txttktenncc.Text = ""; txttktenncc.Enabled = false; }
        }

        private void chksdt_CheckedChanged(object sender, EventArgs e)
        {
            if (chksdt.Checked) { txttksdt.Enabled = true; }
            else { txttksdt.Text = ""; txttksdt.Enabled = false; }
        }

        private void btndatlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            string sql = "SELECT Mancc, Tenncc, Diachi, Dienthoai FROM tblnhacungcap";
            tblncc = Class.Functions.GetDataToTable(sql);
            dgvNcc.DataSource = tblncc;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql, gt = "";
            if ((txttkmancc.Text == "") && (txttktenncc.Text == "") && (txttksdt.Text == ""))
            {
                MessageBox.Show("Hãy nhập điều kiện để tìm kiếm!", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblnhacungcap WHERE 1=1";
            if (txttkmancc.Text != "")
                sql = sql + " AND Mancc LIKE N'%" + txttkmancc.Text + "%'";
            if (txttktenncc.Text != "")
                sql = sql + " AND Tenncc LIKE N'%" + txttktenncc.Text + "%'";
            if (txttksdt.Text != "")
                sql = sql + " AND Dienthoai LIKE N'%" + txttksdt.Text.Trim() + "%'";
            tblncc = Functions.GetDataToTable(sql);
            if (tblncc.Rows.Count == 0)
                MessageBox.Show("Không có nhà cung cấp nào thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblncc.Rows.Count + " nhà cung cấp thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvNcc.DataSource = tblncc;
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblnhacungcap WHERE Mancc=N'" + txtMancc.Text + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }
    }
}
