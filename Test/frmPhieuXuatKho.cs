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

        private void frmPhieuXuatKho_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["User"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
            
            

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPhieuXuatKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaDaiLy.Text = dgvPhieuXuatKho.Rows[numrow].Cells[0].Value.ToString();
            txtTenHang.Text = dgvPhieuXuatKho.Rows[numrow].Cells[1].Value.ToString();
            txtGia.Text = dgvPhieuXuatKho.Rows[numrow].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvPhieuXuatKho.Rows[numrow].Cells[3].Value.ToString();
            txtTongTien.Text = dgvPhieuXuatKho.Rows[numrow].Cells[4].Value.ToString();
            txtHinhThucThanhToan.Text = dgvPhieuXuatKho.Rows[numrow].Cells[5].Value.ToString();
        }

        private void btnInPhieuXuatHang_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Ma Dai Ly", typeof(string));
            dt.Columns.Add("Ten Hang", typeof(string));
            dt.Columns.Add("Gia", typeof(int));
            dt.Columns.Add("So Luong", typeof(int));
            dt.Columns.Add("Tong Tien", typeof(double));

            
            foreach(DataGridViewRow dgv in dgvPhieuXuatKho.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value);
            }
            ds.Tables.Add(dt);
            
            frmInPhieuXuatKho inPhieu = new frmInPhieuXuatKho();
            PhieuXuatKho cr = new PhieuXuatKho();
            cr.SetDataSource(ds);
            inPhieu.InnPhieuXuatKho.ReportSource = cr;
            inPhieu.InnPhieuXuatKho.Refresh();
            inPhieu.Show();
        }
        
    }
}
