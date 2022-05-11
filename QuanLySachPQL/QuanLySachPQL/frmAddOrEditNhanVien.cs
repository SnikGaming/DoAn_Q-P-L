using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySachPQL
{
    public partial class frmAddOrEditNhanVien : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmAddOrEditNhanVien()
        {
            InitializeComponent();
        }

        private void frmAddOrEditNhanVien_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Vui lòng chọn ảnh.";
            ofd.Filter = "Image Files(*.png;*.jpg)|*.png;*.jpg";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                picImageNV.ImageLocation=ofd.FileName;
               //txtcmt.Text=ofd.FileName.ToString();
                
            }
        }
    }
}
