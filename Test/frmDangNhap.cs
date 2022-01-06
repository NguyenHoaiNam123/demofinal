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
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S9FKVPS\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");
                try
                {
                    conn.Open();
                    string tk = txtTenDangNhap.Text;
                    string mk = txtMatKhau.Text;
                    string sql = "select *from TaiKhoan where TenDangNhap='" + tk + "' and MatKhau='"+mk+"'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if(dta.Read()==true)
                    {
                        frmMain main = new frmMain();
                        main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sai Tên Đăng Nhập hoặc Mật Khẩu!");
                    }    


                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối!");
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
