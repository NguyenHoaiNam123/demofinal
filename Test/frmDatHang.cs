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
using System.Configuration;

namespace Test
{
    public partial class frmDatHang : Form
    {
        public frmDatHang()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            int giaHang = Convert.ToInt32(txtGia.Text);
            int soLuong = Convert.ToInt32(nmSoLuong.Text);
            int tongTien = giaHang * soLuong;

            txtTongTien.Text = tongTien.ToString();
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT *FROM PhieuNhapHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvDatHang.DataSource = dt;
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["User"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }
    }
}
