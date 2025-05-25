using System.Runtime.InteropServices;
using beauty_shop.Forms;
using FontAwesome.Sharp;
namespace beauty_shop
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(1);

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);  // tím nhạt
            public static Color color2 = Color.FromArgb(249, 118, 176);  // hồng đậm
            public static Color color3 = Color.FromArgb(253, 138, 114);  // cam nhạt
            public static Color color4 = Color.FromArgb(95, 77, 221);    // tím xanh
            public static Color color5 = Color.FromArgb(249, 88, 155);   // hồng cánh sen
            public static Color color6 = Color.FromArgb(24, 161, 251);   // xanh dương sáng
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                if (senderBtn != null)
                {

                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                    currentBtn.ForeColor = color;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = color;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();

                    iconPictureBox1.IconChar = currentBtn.IconChar;
                    iconPictureBox1.IconColor = color;
                    txtCurrentChildForm.Text = currentBtn.Text;
                }
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);

                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }

        }

        private void btnDashboard_Click(object sender, System.EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new DanhMucHeThong());

        }

        private void btnOrders_Click(object sender, System.EventArgs e)
        {

            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormOrders());
        }

        private void btnProducts_Click(object sender, System.EventArgs e)
        {

            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new HoaDon());
        }

        private void btnCustomers_Click(object sender, System.EventArgs e)
        {

            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new QuanLySP());
        }

        private void btnMarketing_Click(object sender, System.EventArgs e)
        {

            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormMarketing());
        }

        private void btnSetting_Click(object sender, System.EventArgs e)
        {

            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new NhaCungCap());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            Reset();
            OpenChildForm(new BaoCaoThongKe());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();



        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconPictureBox1.IconChar = IconChar.Home;
            iconPictureBox1.IconColor = Color.MediumPurple;
            txtCurrentChildForm.Text = "Home";
        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMaximum_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 6;
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                Point pos = PointToClient(new Point(m.LParam.ToInt32()));
                Size clientSize = this.ClientSize;

                if (pos.X <= RESIZE_HANDLE_SIZE)
                {
                    if (pos.Y <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTTOPLEFT;
                    else if (pos.Y >= clientSize.Height - RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                    else
                        m.Result = (IntPtr)HTLEFT;
                }
                else if (pos.X >= clientSize.Width - RESIZE_HANDLE_SIZE)
                {
                    if (pos.Y <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTTOPRIGHT;
                    else if (pos.Y >= clientSize.Height - RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else
                        m.Result = (IntPtr)HTRIGHT;
                }
                else if (pos.Y <= RESIZE_HANDLE_SIZE)
                {
                    m.Result = (IntPtr)HTTOP;
                }
                else if (pos.Y >= clientSize.Height - RESIZE_HANDLE_SIZE)
                {
                    m.Result = (IntPtr)HTBOTTOM;
                }

                return;
            }

            base.WndProc(ref m);
        }

    }
}
