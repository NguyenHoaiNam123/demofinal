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
    public partial class frmPhieuNhapKho : Form
    {
        public frmPhieuNhapKho()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM PhieuNhapHang WHERE maHang = @maHang";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("maHang", cbbMaHang.Text);
            cmd.Parameters.AddWithValue("tenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("soLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("giaNhapHang", txtGiaNhapHang.Text);
            cmd.Parameters.AddWithValue("tongTien", txtTongTien.Text);
            cmd.Parameters.AddWithValue("ngayNhap", dtpNgayNhap.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void frmPhieuNhapKho_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLyBanHang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        SqlConnection con;
        public void HienThi()
        {
            string sqlSELECT = "SELECT *FROM PhieuNhapHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsPhieuNhapKho.DataSource = dt;
            dsPhieuNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO PhieuNhapHang VALUES (@maHang, @tenHang, @soLuong, @giaNhapHang, @tongTien, @ngayNhap)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("maHang", cbbMaHang.Text);
            cmd.Parameters.AddWithValue("tenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("soLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("giaNhapHang", txtGiaNhapHang.Text);
            cmd.Parameters.AddWithValue("tongTien", txtTongTien.Text);
            cmd.Parameters.AddWithValue("ngayNhap", dtpNgayNhap.Text);

            cmd.ExecuteNonQuery();
            HienThi();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE PhieuNhapHang SET tenHang = @tenHang, soLuong = @soLuong, giaNhapHang = @giaNhapHang, tongTien = @tongTien, ngayNhap = @ngayNhap WHERE maHang = @maHang";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("maHang", cbbMaHang.Text);
            cmd.Parameters.AddWithValue("tenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("soLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("giaNhapHang", txtGiaNhapHang.Text);
            cmd.Parameters.AddWithValue("tongTien", txtTongTien.Text);
            cmd.Parameters.AddWithValue("ngayNhap", dtpNgayNhap.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void dsPhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dsPhieuNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            cbbMaHang.Text = dsPhieuNhapKho.Rows[numrow].Cells[0].Value.ToString();
            cbbTenHang.Text = dsPhieuNhapKho.Rows[numrow].Cells[1].Value.ToString();
            txtSoLuong.Text = dsPhieuNhapKho.Rows[numrow].Cells[2].Value.ToString();
            txtGiaNhapHang.Text = dsPhieuNhapKho.Rows[numrow].Cells[3].Value.ToString();
            txtTongTien.Text = dsPhieuNhapKho.Rows[numrow].Cells[4].Value.ToString();
            dtpNgayNhap.Text = dsPhieuNhapKho.Rows[numrow].Cells[5].Value.ToString();


        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {

        }
        private void Update()
        {
            try
            {
                double sl = Convert.ToDouble(txtSoLuong.Text);
                double gia = Convert.ToInt32(txtGiaNhapHang.Text);
                double tong = (sl * gia);
                txtTongTien.Text = tong.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void nmSoLuong_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGiaNhapHang_TextChanged(object sender, EventArgs e)
        {
            Update();
        }
        List<MaHangTen> listItem;

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            listItem = new List<MaHangTen>()
            {
                new MaHangTen(){MaHang = "M01", Ten = "Jet", Gia = 3000},
                new MaHangTen(){MaHang = "M02", Ten = "Hero", Gia = 2000},
                new MaHangTen(){MaHang = "M03", Ten = "555", Gia = 4500},
                new MaHangTen(){MaHang = "M04", Ten = "Sài Gòn", Gia = 1500},
                new MaHangTen(){MaHang = "M05", Ten = "Marboro", Gia = 3200},
                new MaHangTen(){MaHang = "M06", Ten = "Craven", Gia = 2500},
                new MaHangTen(){MaHang = "M07", Ten = "Khánh Hội", Gia = 1300},
                new MaHangTen(){MaHang = "M08", Ten = "Camel", Gia = 3500},
                new MaHangTen(){MaHang = "M09", Ten = "Marula", Gia = 4000}
            };
            cbbMaHang.DataSource = listItem;
            cbbMaHang.DisplayMember = "MaHang";

            cbbTenHang.DataSource = listItem;
            cbbTenHang.DisplayMember = "Ten";

        }

        private void cbbMaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                MaHangTen ma = cb.SelectedValue as MaHangTen;
                txtGiaNhapHang.Text = ma.Gia.ToString();
            }
        }

        private void nmSoLuong_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            Update();
        }
    }
    public class MaHangTen
    {
        public string MaHang { get; set; }
        public string Ten { get; set; }
        public float Gia { get; set; }
    }
}
