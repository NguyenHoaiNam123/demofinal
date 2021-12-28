
namespace Test
{
    partial class frmPhieuXuatKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaDaiLy = new System.Windows.Forms.Label();
            this.txtMaDaiLy = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnTinhTrangThanhToan = new System.Windows.Forms.Button();
            this.btnTinhTrangDonHang = new System.Windows.Forms.Button();
            this.btnInPhieuXuatHang = new System.Windows.Forms.Button();
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.txtHinhThucThanhToan = new System.Windows.Forms.TextBox();
            this.lblHinhThucThanhToan = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPhieuXuatKho = new System.Windows.Forms.DataGridView();
            this.pnThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuatKho)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaDaiLy
            // 
            this.lblMaDaiLy.AutoSize = true;
            this.lblMaDaiLy.Location = new System.Drawing.Point(4, 9);
            this.lblMaDaiLy.Name = "lblMaDaiLy";
            this.lblMaDaiLy.Size = new System.Drawing.Size(58, 13);
            this.lblMaDaiLy.TabIndex = 0;
            this.lblMaDaiLy.Text = "Mã Đại Lý:";
            // 
            // txtMaDaiLy
            // 
            this.txtMaDaiLy.Location = new System.Drawing.Point(68, 6);
            this.txtMaDaiLy.Name = "txtMaDaiLy";
            this.txtMaDaiLy.ReadOnly = true;
            this.txtMaDaiLy.Size = new System.Drawing.Size(133, 20);
            this.txtMaDaiLy.TabIndex = 5;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(67, 194);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(134, 20);
            this.txtTongTien.TabIndex = 23;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(6, 201);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(59, 13);
            this.lblTongTien.TabIndex = 22;
            this.lblTongTien.Text = "Tổng Tiền:";
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // btnTinhTrangThanhToan
            // 
            this.btnTinhTrangThanhToan.Location = new System.Drawing.Point(269, 19);
            this.btnTinhTrangThanhToan.Name = "btnTinhTrangThanhToan";
            this.btnTinhTrangThanhToan.Size = new System.Drawing.Size(130, 23);
            this.btnTinhTrangThanhToan.TabIndex = 11;
            this.btnTinhTrangThanhToan.Text = "Tình Trạng Thanh Toán";
            this.btnTinhTrangThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnTinhTrangDonHang
            // 
            this.btnTinhTrangDonHang.Location = new System.Drawing.Point(134, 19);
            this.btnTinhTrangDonHang.Name = "btnTinhTrangDonHang";
            this.btnTinhTrangDonHang.Size = new System.Drawing.Size(120, 23);
            this.btnTinhTrangDonHang.TabIndex = 10;
            this.btnTinhTrangDonHang.Text = "Tình Trạng Đơn Hàng";
            this.btnTinhTrangDonHang.UseVisualStyleBackColor = true;
            // 
            // btnInPhieuXuatHang
            // 
            this.btnInPhieuXuatHang.Location = new System.Drawing.Point(3, 19);
            this.btnInPhieuXuatHang.Name = "btnInPhieuXuatHang";
            this.btnInPhieuXuatHang.Size = new System.Drawing.Size(109, 23);
            this.btnInPhieuXuatHang.TabIndex = 9;
            this.btnInPhieuXuatHang.Text = "In Phiếu Xuất Hàng";
            this.btnInPhieuXuatHang.UseVisualStyleBackColor = true;
            this.btnInPhieuXuatHang.Click += new System.EventHandler(this.btnInPhieuXuatHang_Click);
            // 
            // pnThongTin
            // 
            this.pnThongTin.Controls.Add(this.txtHinhThucThanhToan);
            this.pnThongTin.Controls.Add(this.lblHinhThucThanhToan);
            this.pnThongTin.Controls.Add(this.txtTongTien);
            this.pnThongTin.Controls.Add(this.txtGia);
            this.pnThongTin.Controls.Add(this.lblGia);
            this.pnThongTin.Controls.Add(this.txtSoLuong);
            this.pnThongTin.Controls.Add(this.lblTongTien);
            this.pnThongTin.Controls.Add(this.lblSoluong);
            this.pnThongTin.Controls.Add(this.txtTenHang);
            this.pnThongTin.Controls.Add(this.lblTenHang);
            this.pnThongTin.Controls.Add(this.lblMaDaiLy);
            this.pnThongTin.Controls.Add(this.txtMaDaiLy);
            this.pnThongTin.Location = new System.Drawing.Point(439, 12);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(412, 386);
            this.pnThongTin.TabIndex = 11;
            // 
            // txtHinhThucThanhToan
            // 
            this.txtHinhThucThanhToan.Location = new System.Drawing.Point(134, 254);
            this.txtHinhThucThanhToan.Name = "txtHinhThucThanhToan";
            this.txtHinhThucThanhToan.ReadOnly = true;
            this.txtHinhThucThanhToan.Size = new System.Drawing.Size(170, 20);
            this.txtHinhThucThanhToan.TabIndex = 32;
            // 
            // lblHinhThucThanhToan
            // 
            this.lblHinhThucThanhToan.AutoSize = true;
            this.lblHinhThucThanhToan.Location = new System.Drawing.Point(6, 257);
            this.lblHinhThucThanhToan.Name = "lblHinhThucThanhToan";
            this.lblHinhThucThanhToan.Size = new System.Drawing.Size(122, 13);
            this.lblHinhThucThanhToan.TabIndex = 31;
            this.lblHinhThucThanhToan.Text = "Hình Thức Thanh Toán:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(67, 152);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(134, 20);
            this.txtGia.TabIndex = 30;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(6, 159);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(26, 13);
            this.lblGia.TabIndex = 29;
            this.lblGia.Text = "Giá:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(67, 108);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(134, 20);
            this.txtSoLuong.TabIndex = 9;
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(6, 111);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(56, 13);
            this.lblSoluong.TabIndex = 8;
            this.lblSoluong.Text = "Số Lượng:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(67, 59);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(134, 20);
            this.txtTenHang.TabIndex = 7;
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(4, 59);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(58, 13);
            this.lblTenHang.TabIndex = 6;
            this.lblTenHang.Text = "Tên Hàng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTinhTrangThanhToan);
            this.panel1.Controls.Add(this.btnTinhTrangDonHang);
            this.panel1.Controls.Add(this.btnInPhieuXuatHang);
            this.panel1.Location = new System.Drawing.Point(439, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 64);
            this.panel1.TabIndex = 13;
            // 
            // dgvPhieuXuatKho
            // 
            this.dgvPhieuXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuatKho.Location = new System.Drawing.Point(2, 12);
            this.dgvPhieuXuatKho.Name = "dgvPhieuXuatKho";
            this.dgvPhieuXuatKho.Size = new System.Drawing.Size(431, 456);
            this.dgvPhieuXuatKho.TabIndex = 14;
            this.dgvPhieuXuatKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuXuatKho_CellClick);
            this.dgvPhieuXuatKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuXuatKho_CellContentClick_1);
            // 
            // frmPhieuXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 483);
            this.Controls.Add(this.dgvPhieuXuatKho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnThongTin);
            this.Name = "frmPhieuXuatKho";
            this.Text = "frmPhieuXuatKho";
            this.Load += new System.EventHandler(this.frmPhieuXuatKho_Load);
            this.pnThongTin.ResumeLayout(false);
            this.pnThongTin.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuatKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaDaiLy;
        private System.Windows.Forms.TextBox txtMaDaiLy;
        private System.Windows.Forms.Button btnTinhTrangThanhToan;
        private System.Windows.Forms.Button btnTinhTrangDonHang;
        private System.Windows.Forms.Button btnInPhieuXuatHang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Panel pnThongTin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhieuXuatKho;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblHinhThucThanhToan;
        private System.Windows.Forms.TextBox txtHinhThucThanhToan;
    }
}