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

namespace Test
{
    public partial class frmDangNhap : Form
    {
        ConnectSQL con = new ConnectSQL(); 
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = con.GetData("SELECT * FROM TaiKhoan WHERE TenDangNhap = '" + txtTenDangNhap.Text + "' and MatKhau = '" + txtMatKhau.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    frmMain main = new frmMain(dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][6].ToString());
                    this.Hide();
                    main.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Sai Tên Đăng Nhập hoặc Mật Khẩu!!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối!");
            }
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
