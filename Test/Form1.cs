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
    }
}
