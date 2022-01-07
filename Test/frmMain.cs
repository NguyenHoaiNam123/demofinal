using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class frmMain : Form
    {
        string tendangnhap = "", matkhau = "", vaitro = "";
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string tendangnhap, string matkhau, string vaitro)
        {   
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.vaitro = vaitro;
        }

        private void btnPhieuNhapKho_Click(object sender, EventArgs e)
        {
            if(vaitro == "Ketoan")
            {
                frmPhieuNhapKho phieunhap = new frmPhieuNhapKho();
                phieunhap.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được sử dụng chức năng này!");
            }
            
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (vaitro == "Daily")
            {
                frmDatHang dathang = new frmDatHang();
                dathang.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được sử dụng chức năng này!");
            }
        }

        private void btnPhieuXuatKho_Click(object sender, EventArgs e)
        {
            if (vaitro == "Ketoan")
            {
                frmPhieuXuatKho phieuxuat = new frmPhieuXuatKho();
                phieuxuat.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được sử dụng chức năng này!");
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (vaitro == "Daily")
            {
                MessageBox.Show("Bạn không được sử dụng chức năng này");
            }
          
        }

        private void thoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vaitro == "Ketoan")
            {
                frmThongKe thongke = new frmThongKe();
                thongke.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được sử dụng chức năng này!");
            }
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vaitro == "Ketoan")
            {
                frmDoanhThu doanhthu = new frmDoanhThu();
                doanhthu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được sử dụng chức năng này!");
            }
        }
    }
}
