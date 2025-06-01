using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using btl.net.Class;


namespace btl.net.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GHMF8TE\CHUKIEU;Initial Catalog=shopmypham;Integrated Security=True;Encrypt=False");
            try
            {
                conn.Open();
                string tk = txttaikhoan.Text;
                string mk = txtmatkhau.Text;
                if (txttaikhoan.Text == "")
                {
                    MessageBox.Show("Chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttaikhoan.Focus();
                    return;
                }
                if (txtmatkhau.Text == "")
                {
                    MessageBox.Show("Chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmatkhau.Focus();
                    return;
                }
                string sql = "select * from taikhoan where taikhoan='" + tk + "' and matkhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Trangchu.quyen = Functions.XemDL("select quyen from taikhoan where taikhoan='" + tk + "' and matkhau='" + mk + "'").Rows[0][0].ToString().Trim();
                    Trangchu f1 = new Trangchu();
                    f1.Show();
                    this.Hide();
                    f1.dangxuat += f_dangxuat;
                }
                else MessageBox.Show("Đăng nhập không thành công");
            }
            catch (Exception )
            {
                MessageBox.Show("Kết nối không thành công");
            }
        }
        private void f_dangxuat(object sender, EventArgs e)
        {
            (sender as Trangchu).isthoat = false;
            (sender as Trangchu).Close();
            this.Show();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtmatkhau.PasswordChar = '\0';
            else txtmatkhau.PasswordChar = '●';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
