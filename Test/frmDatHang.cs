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
                double sl = Convert.ToDouble(txtSoLuong.Text);
                double gia = Convert.ToInt32(txtGia.Text);
                double tong = (sl * gia);
                txtTongTien.Text = tong.ToString();
            }
            catch (Exception ex)
            {

            }
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            Update();
        }
        
        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            Update();
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
            cbbMaDaiLy.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO DatHang VALUES (@MaDaiLy, @TenHang, @Gia, @SoLuong, @TongTien, @HinhThucThanhToan, @NgayDat)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("MaDaiLy", cbbMaDaiLy.Text);
            cmd.Parameters.AddWithValue("TenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("Gia", txtGia.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
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
            cmd.Parameters.AddWithValue("maDaiLy", cbbMaDaiLy.Text);
            cmd.Parameters.AddWithValue("tenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("giaSP", txtGia.Text);
            cmd.Parameters.AddWithValue("soLuong", txtSoLuong.Text);
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
            cmd.Parameters.AddWithValue("maDaiLy", cbbMaDaiLy.Text);
            cmd.Parameters.AddWithValue("tenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("giaSP", txtGia.Text);
            cmd.Parameters.AddWithValue("soLuong", txtSoLuong.Text);
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
            cbbMaDaiLy.Text = dgvDatHang.Rows[numrow].Cells[0].Value.ToString();
            cbbTenHang.Text = dgvDatHang.Rows[numrow].Cells[1].Value.ToString();
            txtGia.Text = dgvDatHang.Rows[numrow].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvDatHang.Rows[numrow].Cells[3].Value.ToString();
            txtTongTien.Text = dgvDatHang.Rows[numrow].Cells[4].Value.ToString();
            cbbHinhThucThanhToan.Text = dgvDatHang.Rows[numrow].Cells[5].Value.ToString();
        }

       

        
        List<TenGia> listItem;
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            listItem = new List<TenGia>()
            {
                new TenGia(){Ten = "Jet", Gia = 3000},
                new TenGia(){Ten = "Hero", Gia = 2000},
                new TenGia(){Ten = "555", Gia = 4500},
                new TenGia(){Ten = "Sài Gòn", Gia = 1500},
                new TenGia(){Ten = "Marboro", Gia = 3200},
                new TenGia(){Ten = "Craven", Gia = 2500},
                new TenGia(){Ten = "Khánh Hội", Gia = 1300},
                new TenGia(){Ten = "Camel", Gia = 3500},
                new TenGia(){Ten = "Marula", Gia = 4000}
            };
            cbbTenHang.DataSource = listItem;
            cbbTenHang.DisplayMember = "Ten";
        }

        private void cbbTenHang_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                TenGia ma = cb.SelectedValue as TenGia;
                txtGia.Text = ma.Gia.ToString();
            }
        }

        
    }

    public class TenGia
    {
        public string Ten { get; set; }
        public float Gia { get; set; }
    }
}
