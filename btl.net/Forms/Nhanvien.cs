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
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            txtManv.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            chkmacv.Checked = false;
            chkmanvien.Checked = false;
            chktennvien.Checked = false;
            chksdt.Checked = false;

            Load_DataGridView();
            Functions.FillCombo("SELECT Macongviec, Tencongviec FROM tblcongviec", cboMacv, "Macongviec", "Macongviec");
            cboMacv.SelectedIndex = -1;
            Functions.FillCombo("SELECT Macongviec, Tencongviec FROM tblcongviec", cbotkmacv, "Macongviec", "Macongviec");
            cbotkmacv.SelectedIndex = -1;
            Functions.FillCombo("SELECT Manhanvien, Tennhanvien FROM tblnhanvien", cbotkmanvien, "Manhanvien", "Manhanvien");
            cbotkmanvien.SelectedIndex = -1;
            ResetValues();
        }
        DataTable tblNV;

        private void ResetValues()
        {
            txtManv.Text = "";
            txtTennv.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            txtngaysinh.Text = "  /  /    ";
            //txtngaysinh.Enabled = false;
            mskSodt.Text = "";
            txtDiachi.Text = "";
            cboMacv.Text = "";
            chkmacv.Checked = false;
            chkmanvien.Checked = false;
            chktennvien.Checked = false;
            chksdt.Checked = false;
            txttksdt.Text = "";
            cbotkmanvien.Text = "";
            txttktennvien.Text = "";
            cbotkmacv.Text = "";                                                        //
            cbotkmanvien.Enabled = false;
            txttksdt.Enabled = false;
            txttktennvien.Enabled = false;
            cbotkmacv.Enabled = false;              //
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Manhanvien, Tennhanvien, Gioitinh, Ngaysinh, Dienthoai, Diachi, Macongviec FROM tblnhanvien";
            tblNV = Functions.GetDataToTable(sql);
            dgvNV.DataSource = tblNV;
            dgvNV.Columns[0].HeaderText = "Mã nhân viên";
            dgvNV.Columns[1].HeaderText = "Tên nhân viên";
            dgvNV.Columns[2].HeaderText = "Giới tính";
            dgvNV.Columns[3].HeaderText = "Ngày sinh";
            dgvNV.Columns[4].HeaderText = "Điện thoại";
            dgvNV.Columns[5].HeaderText = "Địa chỉ";
            dgvNV.Columns[6].HeaderText = "Mã công việc";
            dgvNV.AllowUserToAddRows = false;
            dgvNV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvNV_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManv.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtManv.Text = dgvNV.CurrentRow.Cells["Manhanvien"].Value.ToString();
            txtTennv.Text = dgvNV.CurrentRow.Cells["Tennhanvien"].Value.ToString();
            if (dgvNV.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam")
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
            }
            txtngaysinh.Text = dgvNV.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            mskSodt.Text = dgvNV.CurrentRow.Cells["Dienthoai"].Value.ToString();
            txtDiachi.Text = dgvNV.CurrentRow.Cells["Diachi"].Value.ToString();
            ma = dgvNV.CurrentRow.Cells["Macongviec"].Value.ToString();
            cboMacv.Text = Functions.GetFieldValues("SELECT Tencongviec FROM tblcongviec WHERE Macongviec = N'" + ma + "'");
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
            txtManv.Enabled = true;
            txtManv.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtManv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManv.Focus();
                return;
            }
            if (txtTennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennv.Focus();
                return;
            }
            if (rdoNam.Checked)
                gt = "Nam";
            else if (rdoNu.Checked)
                gt = "Nữ";
            else
            {
                MessageBox.Show("Hãy chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT Manhanvien FROM tblnhanvien WHERE Manhanvien=N'" + txtManv.Text.Trim() + "'";
            if (mskSodt.Text == "(   )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSodt.Focus();
                return;
            }
            if (txtngaysinh.Text == "  /  /    ")
            {
                MessageBox.Show("Hãy nhập ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtngaysinh.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }

            if (cboMacv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMacv.Focus();
                return;
            }
            sql = "INSERT INTO tblnhanvien(Manhanvien,Tennhanvien,Gioitinh,Ngaysinh,Dienthoai,Diachi,Macongviec) VALUES(N'" + txtManv.Text.Trim() + "', N'" + txtTennv.Text.Trim() + "', N'" + gt + "', '" + txtngaysinh.Text + "', '" + mskSodt.Text + "', N'" + txtDiachi.Text.Trim() + "', N'" + cboMacv.SelectedValue.ToString() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManv.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennv.Focus();
                return;
            }
            if (rdoNam.Checked)
                gt = "Nam";
            else if (rdoNu.Checked)
                gt = "Nữ";
            else
            {
                MessageBox.Show("Hãy chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtngaysinh.Text == "  /  /    ")
            {
                MessageBox.Show("Hãy nhập ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtngaysinh.Focus();
                return;
            }
            if (mskSodt.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskSodt.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (cboMacv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMacv.Focus();
                return;
            }


            sql = "UPDATE tblnhanvien SET Tennhanvien=N'" + txtTennv.Text.Trim() + "',Gioitinh=N'" + gt + "',NgaySinh = '" + txtngaysinh.Text + "',Dienthoai='" + mskSodt.Text.ToString() + "',Diachi=N'" + txtDiachi.Text.Trim() + "',Macongviec='" + cboMacv.SelectedValue.ToString() + "' WHERE Manhanvien=N'" + txtManv.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblnhanvien WHERE Manhanvien=N'" + txtManv.Text + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql, gt = "";
            if ((cbotkmanvien.Text == "") && (txttktennvien.Text == "")  && (cbotkmacv.Text == "") && (txttksdt.Text == ""))
            {
                MessageBox.Show("Hãy nhập điều kiện để tìm kiếm!", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblnhanvien WHERE 1=1";
            if (cbotkmanvien.Text != "")
                sql = sql + " AND Manhanvien LIKE N'%" + cbotkmanvien.Text + "%'";
            if (txttktennvien.Text != "")
                sql = sql + " AND Tennhanvien LIKE N'%" + txttktennvien.Text + "%'";
            if (cbotkmacv.Text != "")
                sql = sql + " AND Macongviec LIKE N'%" + cbotkmacv.SelectedValue + "%'";
            if (txttksdt.Text != "")
                sql = sql + " AND Dienthoai LIKE N'%" + txttksdt.Text.Trim() + "%'";
            tblNV = Functions.GetDataToTable(sql);
            if (tblNV.Rows.Count == 0)
                MessageBox.Show("Không có nhân viên nào thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblNV.Rows.Count + " nhân viên thỏa mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgvNV.DataSource = tblNV;
            ResetValues();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManv.Enabled = false;
        }

        private void txtManv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTennv_KeyUp(object sender, KeyEventArgs e)
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
            string sql = "SELECT Manhanvien, Tennhanvien, Diachi, Gioitinh, Ngaysinh, Dienthoai, Macongviec FROM tblnhanvien";
            tblNV = Functions.GetDataToTable(sql);
            dgvNV.DataSource = tblNV;
        }

        private void btndatlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            string sql = "SELECT Manhanvien, Tennhanvien, Diachi, Gioitinh, Ngaysinh, Dienthoai, Macongviec FROM tblnhanvien";
            tblNV = Functions.GetDataToTable(sql);
            dgvNV.DataSource = tblNV;
        }

        private void chkmanvien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmanvien.Checked) { cbotkmanvien.Enabled = true; }
            else { cbotkmanvien.Text = ""; cbotkmanvien.Enabled = false; }
        }

        private void chktennvien_CheckedChanged(object sender, EventArgs e)
        {
            if(chktennvien.Checked) {txttktennvien.Enabled = true; }
            else { txttktennvien.Text = "";txttktennvien.Enabled= false; }
        }

        private void chksdt_CheckedChanged(object sender, EventArgs e)
        {
            if(chksdt.Checked) {txttksdt.Enabled = true; }
            else{ txttksdt.Text = "";txttksdt.Enabled = false; }
        }

        private void chkmacv_CheckedChanged(object sender, EventArgs e)
        {
            if( chkmacv.Checked) {cbotkmacv.Enabled = true; }
            else {cbotkmacv.Text=""; cbotkmacv.Enabled= false; }
        }

        private void txtDiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == ',' || Convert.ToInt32(e.KeyChar) == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
