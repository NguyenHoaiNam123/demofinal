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
        private void Update()
        {
            try
            {
                double sl = Convert.ToDouble(nmSoLuong.Text);
                int gia = Convert.ToInt32(txtGia.Text);
                double tong = (sl * gia);
                txtTongTien.Text = tong.ToString();
            }
            catch(Exception ex)
            {

            }
        }
        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT *FROM DatHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvDatHang.DataSource = dt;
            dgvDatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLyBanHang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
            txtMaDaiLy.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO DatHang VALUES (@MaDaiLy, @TenHang, @Gia, @SoLuong, @TongTien, @HinhThucThanhToan, @NgayDat)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("MaDaiLy", txtMaDaiLy.Text);
            cmd.Parameters.AddWithValue("TenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("SoLuong", nmSoLuong.Text);
            cmd.Parameters.AddWithValue("TongTien", txtTongTien.Text);
            cmd.Parameters.AddWithValue("HinhThucThanhToan", cbbHinhThucThanhToan.Text);
            cmd.Parameters.AddWithValue("NgayDat", dtpNgayDat.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM DatHang WHERE maDaiLy = @maDaiLy";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("maDaiLy", txtMaDaiLy.Text);
            cmd.Parameters.AddWithValue("tenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("giaSP", txtGia.Text);
            cmd.Parameters.AddWithValue("soLuong", nmSoLuong.Text);
            cmd.Parameters.AddWithValue("tongTien", txtTongTien.Text);
            cmd.Parameters.AddWithValue("HinhThucThanhToan", cbbHinhThucThanhToan.Text);
            cmd.Parameters.AddWithValue("NgayDat", dtpNgayDat.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE DatHang SET tenHang = @tenHang, giaSP = @giaSP, soLuong = @soLuong, tongTien = @tongTien, HinhThucThanhToan = @HinhThucThanhToan, NgayDat = @NgayDat WHERE maDaiLy = @maDaiLy";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("maDaiLy", txtMaDaiLy.Text);
            cmd.Parameters.AddWithValue("tenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("giaSP", txtGia.Text);
            cmd.Parameters.AddWithValue("soLuong", nmSoLuong.Text);
            cmd.Parameters.AddWithValue("tongTien", txtTongTien.Text);
            cmd.Parameters.AddWithValue("HinhThucThanhToan", cbbHinhThucThanhToan.Text);
            cmd.Parameters.AddWithValue("NgayDat", dtpNgayDat.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void dgvDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaDaiLy.Text = dgvDatHang.Rows[numrow].Cells[0].Value.ToString();
            cbbTenHang.Text = dgvDatHang.Rows[numrow].Cells[1].Value.ToString();
            txtGia.Text = dgvDatHang.Rows[numrow].Cells[2].Value.ToString();
            nmSoLuong.Text = dgvDatHang.Rows[numrow].Cells[3].Value.ToString();
            txtTongTien.Text = dgvDatHang.Rows[numrow].Cells[4].Value.ToString();
            cbbHinhThucThanhToan.Text = dgvDatHang.Rows[numrow].Cells[5].Value.ToString();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void nmSoLuong_ValueChanged(object sender, EventArgs e)
        {
            Update();
        }
    }
}
