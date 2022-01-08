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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con;
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLyBanHang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
            NhapKho();
            XuatKho();
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT *FROM HangHoa";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvThongKe.DataSource = dt;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.Columns["maHang"].HeaderText = "Mã Hàng";
            dgvThongKe.Columns["TenHang"].HeaderText = "Tên Hàng";
            dgvThongKe.Columns["GiaNhap"].HeaderText = "Giá Nhập";
            dgvThongKe.Columns["GiaBan"].HeaderText = "Giá Bán";
            dgvThongKe.Columns["TonKho"].HeaderText = "Tồn Kho";
        }
        public void NhapKho()
        {
            string sqlSELECT = "SELECT *FROM PhieuNhapHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvThongKe.DataSource = dt;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.Columns["tenHang"].HeaderText = "Tên Hàng";
            dgvThongKe.Columns["soLuong"].HeaderText = "Số Lượng";
            dgvThongKe.Columns["giaNhapHang"].HeaderText = "Giá Nhập Hàng";
            dgvThongKe.Columns["tongTien"].HeaderText = "Tổng Tiền";
            dgvThongKe.Columns["ngayNhap"].HeaderText = "Ngày Nhập";
            //ẩn
            dgvThongKe.Columns["maHang"].Visible = false;
        }
        public void XuatKho()
        {
            string sqlSELECT = "SELECT *FROM DatHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvThongKe.DataSource = dt;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.Columns["MaDaiLy"].HeaderText = "Mã Đại Lý";
            dgvThongKe.Columns["TenHang"].HeaderText = "Tên Hàng";
            dgvThongKe.Columns["Gia"].HeaderText = "Giá Bán";
            dgvThongKe.Columns["soLuong"].HeaderText = "Số Lượng";
            dgvThongKe.Columns["tongTien"].HeaderText = "Tổng Tiền";
            dgvThongKe.Columns["HinhThucThanhToan"].HeaderText = "Hình Thức Thanh Toán";
            dgvThongKe.Columns["NgayDat"].HeaderText = "Ngày Đặt";
        }

        
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (rdbTatCaMatHang.Checked)
            {
                HienThi();
                return;
            }
            else if(rdbXuatKho.Checked)
            {
                XuatKho();

            }
            else if(rdbNhapKho.Checked)
            {
                NhapKho();

            }
        }
    }
}
