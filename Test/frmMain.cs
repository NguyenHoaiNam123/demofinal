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
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPhieuNhapKho_Click(object sender, EventArgs e)
        {
            //tạo khai báo form mới
            frmPhieuNhapKho nhap = new frmPhieuNhapKho();
            //hiển thị form đó lên
            nhap.ShowDialog();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            frmDatHang dathang = new frmDatHang();
            dathang.ShowDialog();
        }

        private void btnPhieuXuatKho_Click(object sender, EventArgs e)
        {
            frmPhieuXuatKho xuat = new frmPhieuXuatKho();
            xuat.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe thongke = new frmThongKe();
            thongke.ShowDialog();
        }
    }
}
