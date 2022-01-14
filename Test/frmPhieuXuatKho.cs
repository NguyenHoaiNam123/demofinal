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
    public partial class frmPhieuXuatKho : Form
    {
        public frmPhieuXuatKho()
        {
            InitializeComponent();
        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhieuXuatKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection con;
        private void dgvPhieuXuatKho_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT *FROM DatHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvPhieuXuatKho.DataSource = dt;
            dgvPhieuXuatKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void TinhTrang()
        {
            string sqlSELECT = "SELECT *FROM ChuyenHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvTinhTrangDonHang.DataSource = dt;
            dgvTinhTrangDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void ThanhToan()
        {
            string sqlSELECT = "SELECT *FROM TinhTrangDonHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvTinhTrangThanhToan.DataSource = dt;
            dgvTinhTrangThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void frmPhieuXuatKho_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLyBanHang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
            TinhTrang();
            ThanhToan();
            
            

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPhieuXuatKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaDaiLy.Text = dgvPhieuXuatKho.Rows[numrow].Cells[0].Value.ToString();
            txtTongTien.Text = dgvPhieuXuatKho.Rows[numrow].Cells[4].Value.ToString();
            txtHinhThucThanhToan.Text = dgvPhieuXuatKho.Rows[numrow].Cells[5].Value.ToString();
            dtpNgayDat.Text = dgvPhieuXuatKho.Rows[numrow].Cells[6].Value.ToString();
        }

        private void btnInPhieuXuatHang_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
