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
    public partial class frmPhieuNhapKho : Form
    {
        List<String> listGioiTinh = new List<string>() { "Nam, Nữ" };
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
            //thao tác để lấy dữ liệu
            MessageBox.Show("Lưu phiếu nhập kho thành công");
            //đóng form hiện tại
            this.Close();
        }

        private void frmPhieuNhapKho_Load(object sender, EventArgs e)
        {
            
        }
    }
}
