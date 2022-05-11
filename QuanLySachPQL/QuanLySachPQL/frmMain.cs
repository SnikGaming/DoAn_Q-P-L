using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
namespace QuanLySachPQL
{
    public partial class frmMain : Form
    {
        private Color background =Color.Black;
        private Color fontChar =Color.FromArgb(20, 178, 102);
        private Color foreground =Color.FromArgb(255, 185, 0);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrom();
        }

        private void pnlAvatar_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrom();

        }

        private void MoveFrom()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frmGiaoDien());
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

                // lbl title
                lblTitleChildForm.ForeColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                Color iconColor = Color.FromArgb(248, 54, 0);

                //currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.BackColor = Color.FromArgb(12, 19, 29);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = iconColor;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //Doi mau khi mo from
            //childForm.BackColor = Color.FromArgb(240, 216, 214);
            childForm.Dock = DockStyle.Fill;
            pnlForm.Controls.Add(childForm);
            pnlForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        
        private void Reset()
        {
            Color iconColor = Color.FromArgb(248, 54, 0);

            DisableButton();
            leftBorderBtn.Visible = false;
         
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Green;
            iconCurrentChildForm.ForeColor= iconColor;
            lblTitleChildForm.Text = "Home";

            btnHoaDon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            btnNCC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            btnSanPham.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            btnNV.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            btnThongKe.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));

            lblTitleChildForm.ForeColor = iconColor;
        }
        //Events
        //Reset
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        //Menu Button_Clicks

        //Close-Maximize-Minimize
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmNhanVien());
            
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            lblTitleChildForm.Text = btnSanPham.Text;
            menuSP.Show(btnSanPham,btnSanPham.Width,0);


        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new frmGiaoDien());
        }
        private void btnNCC_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            lblTitleChildForm.Text = btnNCC.Text;

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            lblTitleChildForm.Text = btnHoaDon.Text;

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            new frmAddOrEditNhanVien().ShowDialog();
            lblTitleChildForm.Text = btnThongKe.Text;

        }
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrom();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show("Bạn có muốn thoát chương trình...!","Thông báo...!",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))==DialogResult.OK)
            Application.Exit();
            
        }

        private void btnMaxWin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinWin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void menuSach_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frmSach());

        }

        private void menuSPChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void menuLoaiSach_Click(object sender, EventArgs e)
        {

        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }
    }
}
