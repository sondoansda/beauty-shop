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
    public partial class Mau : Form
    {
        public Mau()
        {
            InitializeComponent();
        }

        private void chatlieu_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            txtma.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            ResetValues();
        }

        DataTable tblchatlieu;

        private void ResetValues()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtma.Enabled = false;
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Mamau, Tenmau FROM tblmausac";
            tblchatlieu = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblchatlieu;
            DataGridView.Columns[0].HeaderText = "Mã màu";
            DataGridView.Columns[1].HeaderText = "Tên màu";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 150;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtma.Enabled = true;
            txtma.Focus();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtma.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtma.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtma.Focus();
                return;
            }
            if (txtten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtten.Focus();
                return;
            }
            sql = "SELECT Mamau FROM tblmausac WHERE Mamau=N'" + txtma.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã màu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtma.Focus();
                txtma.Text = "";
                return;
            }
            sql = "INSERT INTO tblmausac(Mamau, Tenmau) VALUES(N'" + txtma.Text.Trim() + "',N'" + txtten.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txtma.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblchatlieu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtma.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtten.Focus();
                return;
            }
            sql = "UPDATE tblmausac SET Tenmau=N'" + txtten.Text.ToString() + "' WHERE Mamau=N'" + txtma.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnboqua.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblchatlieu.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtma.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE FROM tblmausac WHERE Mamau=N'" + txtma.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtma.Text == "") && (txtten.Text == ""))
            {
                MessageBox.Show("Bạn cần nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "SELECT * FROM tblmausac WHERE 1=1";
            if (txtma.Text != "")
                sql += " AND Mamau Like N'%" + txtma.Text + "%'";
            if (txtten.Text != "")
                sql += " AND Tenmau Like N'%" + txtten.Text + "%'";
            tblchatlieu = Class.Functions.GetDataToTable(sql);
            if (tblchatlieu.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Có " + tblchatlieu.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataGridView.DataSource = tblchatlieu;
            ResetValues();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            ResetValues();
            string sql;
            sql = "SELECT Mamau, Tenmau FROM tblmausac";
            tblchatlieu = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblchatlieu;
        }

        private void DataGridView_Click_1(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtma.Focus();
                return;
            }
            if (tblchatlieu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtma.Text = DataGridView.CurrentRow.Cells["Mamau"].Value.ToString();
            txtten.Text = DataGridView.CurrentRow.Cells["Tenmau"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }
    }
}
