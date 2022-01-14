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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLyBanHang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            NhapKho();
            DoanhThu();
            int sc = dgvDoanhThu.Rows.Count;
            
        }
        public void NhapKho()
        {
            string sqlSELECT = "SELECT *FROM PhieuNhapHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvDoanhThu.DataSource = dt;
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.Columns["tenHang"].HeaderText = "Tên Hàng";
            dgvDoanhThu.Columns["soLuong"].HeaderText = "Số Lượng";
            dgvDoanhThu.Columns["giaNhapHang"].HeaderText = "Giá Nhập Hàng";
            dgvDoanhThu.Columns["tongTien"].HeaderText = "Tổng Tiền";
            dgvDoanhThu.Columns["ngayNhap"].HeaderText = "Ngày Nhập";
            //ẩn cột 
            dgvDoanhThu.Columns["maHang"].Visible = false;
        }

        public void XuatKho()
        {
            string sqlSELECT = "SELECT *FROM DatHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvDoanhThu.DataSource = dt;
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.Columns["MaDaiLy"].HeaderText = "Mã Đại Lý";
            dgvDoanhThu.Columns["TenHang"].HeaderText = "Tên Hàng";
            dgvDoanhThu.Columns["Gia"].HeaderText = "Giá Bán";
            dgvDoanhThu.Columns["soLuong"].HeaderText = "Số Lượng";
            dgvDoanhThu.Columns["tongTien"].HeaderText = "Tổng Tiền";
            dgvDoanhThu.Columns["NgayDat"].HeaderText = "Ngày Đặt";

            //ẩn cột 
            dgvDoanhThu.Columns["HinhThucThanhToan"].Visible = false;
        }
        public void DoanhThu()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-S9FKVPS\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");
            SqlDataAdapter dr = new SqlDataAdapter("SELECT PhieuNhapHang.tenHang, PhieuNhapHang.soLuong, PhieuNhapHang.tongTien, DatHang.TenHang, DatHang.soLuong, DatHang.tongTien FROM PhieuNhapHang, DatHang", conn);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dgvDoanhThu.DataSource = dt;
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.Columns["tenHang"].HeaderText = "Tên Hàng Nhập";
            dgvDoanhThu.Columns["soLuong"].HeaderText = "Số Lượng Nhập";
            dgvDoanhThu.Columns["tongTien"].HeaderText = "Tổng Tiền Nhập";
            dgvDoanhThu.Columns["TenHang"].HeaderText = "Tên Hàng Xuất";
            dgvDoanhThu.Columns["soLuong"].HeaderText = "Số Lượng Xuất";
            dgvDoanhThu.Columns["tongTien"].HeaderText = "Tổng Tiền Xuất";
        }
        
        
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (rdbNhapKho.Checked)
            {
                NhapKho();
                return;
            }
            else if (rdbXuatKho.Checked)
            {
                XuatKho();

            }
            else if (rdbDoanhThu.Checked)
            {
                DoanhThu();

            }
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
