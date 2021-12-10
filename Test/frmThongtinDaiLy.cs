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
    public partial class frmThongtinDaiLy : Form
    {
        public frmThongtinDaiLy()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S9FKVPS\SQLEXPRESS;Initial Catalog=User;Integrated Security=True");
                try
                {
                    conn.Open();
                    string tk = txtTenDangNhap.Text;
                    string mk = txtMatKhau.Text;
                    string sql = "select *from NguoiDung where TaiKhoan='" + tk + "' and MatKhau='"+mk+"'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if(dta.Read()==true)
                    {
                        frmDatHang dathang = new frmDatHang();
                        dathang.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai Tên Đăng Nhập hoặc Sai Mật Khẩu!");
                    }    


                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối!");
                }    
        }
    }
}
