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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
            Class.Functions.Connect();

        }
        public bool isthoat = true;
        public event EventHandler dangxuat;
        private void mnukhachhang_Click(object sender, EventArgs e)
        {
            Forms.Khachhang a = new Forms.Khachhang();
            a.Show();
        }

        private void mnunhanvien_Click(object sender, EventArgs e)
        {
            Forms.Nhanvien a = new Forms.Nhanvien();
            a.Show();
        }

        private void mnuhoadonnhap_Click(object sender, EventArgs e)
        {
            Forms.Hoadonnhap a = new Forms.Hoadonnhap();
            a.Show();
        }

        private void mnuhoadonban_Click(object sender, EventArgs e)
        {
            Forms.Hoadonban a = new Forms.Hoadonban();
            a.Show();
        }

        private void mnutkhdn_Click(object sender, EventArgs e)
        {
            Forms.Timkiemhoadonnhap a = new Forms.Timkiemhoadonnhap();
            a.Show();
        }

        private void mnutkhdb_Click(object sender, EventArgs e)
        {
            Forms.Timkiemhoadonban a = new Forms.Timkiemhoadonban();
            a.Show();
        }

        private void mnuncc_Click(object sender, EventArgs e)
        {
            Forms.Nhacungcap a = new Forms.Nhacungcap();
            a.Show();
        }

        private void mnuchatlieu_Click(object sender, EventArgs e)
        {
            Forms.chatlieu a = new Forms.chatlieu();
            a.Show();
        }

        private void mnubcaonhap_Click(object sender, EventArgs e)
        {
            Forms.frmBaocaohdn a = new Forms.frmBaocaohdn();
            a.Show();
        }

        private void mnubcaoban_Click(object sender, EventArgs e)
        {
            Forms.frmBaocaohdb a = new Forms.frmBaocaohdb();
            a.Show();
        }

        private void mnuhanghoa_Click(object sender, EventArgs e)
        {
            Forms.frmHanghoa a = new Forms.frmHanghoa();
            a.Show();
        }

        private void mnubcaodoanhthu_Click(object sender, EventArgs e)
        {
            Forms.Baocaodoanhthu a = new Forms .Baocaodoanhthu();
            a.Show();
        }

        public static string quyen;
        private void Trangchu_Load(object sender, EventArgs e)
        {
            if (quyen == "NV")
            {
                mnubcao.Visible = false;
                mnunhanvien.Visible = false;
            }
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            dangxuat(this, new EventArgs());
        }

        private void Trangchu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isthoat)
            {
                Application.Exit();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isthoat)
            {
                Application.Exit();
            }
        }

        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Loai a = new Forms.Loai();
            a.Show();
        }

        private void khốiLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Khoiluong a = new Forms.Khoiluong();
            a.Show();
        }

        private void màuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Mau a = new Forms.Mau();
            a.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.Mua a = new Forms.Mua();
            a.Show();
        }

        private void côngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Congdung a = new Forms.Congdung();
            a.Show();
        }
    }
}
