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
namespace QuanLySachPQL
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private string tukhoa = string.Empty;
        private void loadData()
        {
            List<CustomParameter> parameters = new List<CustomParameter>();
            parameters.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = tukhoa
            });

            dataNhanVien.DataSource= new DataSql().selectData("SelectAllNhanVien",parameters);

            //Doi ten header
            //dataNhanVien.Columns["MSNV"].HeaderText = "MSSV";
            //dataNhanVien.Columns["Gtinh"].HeaderText = "Giới Tính";
            //dataNhanVien.Columns["CCCD/CMND"].HeaderText = "CCCD/CMND";
            //dataNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            //dataNhanVien.Columns["AnhNV"].HeaderText = "Ảnh";
            //dataNhanVien.Columns["HoVaTen"].HeaderText = "Họ Tên";
            //dataNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
            //dataNhanVien.Columns["Luong"].HeaderText = "Lương";
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
