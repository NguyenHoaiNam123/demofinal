
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
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnInPhieuXuatHang = new System.Windows.Forms.Button();
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.txtHinhThucThanhToan = new System.Windows.Forms.TextBox();
            this.lblHinhThucThanhToan = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dgvPhieuXuatKho = new System.Windows.Forms.DataGridView();
            this.lblDanhSachDatHang = new System.Windows.Forms.Label();
            this.dgvTinhTrangThanhToan = new System.Windows.Forms.DataGridView();
            this.lblTinhTrangThanhToan = new System.Windows.Forms.Label();
            this.lblTinhTrangDonHang = new System.Windows.Forms.Label();
            this.dgvTinhTrangDonHang = new System.Windows.Forms.DataGridView();
            this.pnThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuatKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangDonHang)).BeginInit();
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
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(3, 75);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(59, 13);
            this.lblTongTien.TabIndex = 22;
            this.lblTongTien.Text = "Tổng Tiền:";
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // btnInPhieuXuatHang
            // 
            this.btnInPhieuXuatHang.BackColor = System.Drawing.Color.Red;
            this.btnInPhieuXuatHang.Location = new System.Drawing.Point(199, 227);
            this.btnInPhieuXuatHang.Name = "btnInPhieuXuatHang";
            this.btnInPhieuXuatHang.Size = new System.Drawing.Size(109, 23);
            this.btnInPhieuXuatHang.TabIndex = 9;
            this.btnInPhieuXuatHang.Text = "In Phiếu Xuất Hàng";
            this.btnInPhieuXuatHang.UseVisualStyleBackColor = false;
            this.btnInPhieuXuatHang.Click += new System.EventHandler(this.btnInPhieuXuatHang_Click);
            // 
            // pnThongTin
            // 
            this.pnThongTin.Controls.Add(this.dtpNgayDat);
            this.pnThongTin.Controls.Add(this.lblNgayDat);
            this.pnThongTin.Controls.Add(this.txtHinhThucThanhToan);
            this.pnThongTin.Controls.Add(this.lblHinhThucThanhToan);
            this.pnThongTin.Controls.Add(this.txtTongTien);
            this.pnThongTin.Controls.Add(this.lblTongTien);
            this.pnThongTin.Controls.Add(this.lblMaDaiLy);
            this.pnThongTin.Controls.Add(this.txtMaDaiLy);
            this.pnThongTin.Location = new System.Drawing.Point(39, 33);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(319, 157);
            this.pnThongTin.TabIndex = 11;
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDat.Location = new System.Drawing.Point(67, 37);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(134, 20);
            this.dtpNgayDat.TabIndex = 34;
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(4, 43);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(52, 13);
            this.lblNgayDat.TabIndex = 33;
            this.lblNgayDat.Text = "Ngày Đặt";
            // 
            // txtHinhThucThanhToan
            // 
            this.txtHinhThucThanhToan.Location = new System.Drawing.Point(134, 112);
            this.txtHinhThucThanhToan.Name = "txtHinhThucThanhToan";
            this.txtHinhThucThanhToan.ReadOnly = true;
            this.txtHinhThucThanhToan.Size = new System.Drawing.Size(170, 20);
            this.txtHinhThucThanhToan.TabIndex = 32;
            // 
            // lblHinhThucThanhToan
            // 
            this.lblHinhThucThanhToan.AutoSize = true;
            this.lblHinhThucThanhToan.Location = new System.Drawing.Point(4, 115);
            this.lblHinhThucThanhToan.Name = "lblHinhThucThanhToan";
            this.lblHinhThucThanhToan.Size = new System.Drawing.Size(122, 13);
            this.lblHinhThucThanhToan.TabIndex = 31;
            this.lblHinhThucThanhToan.Text = "Hình Thức Thanh Toán:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(68, 72);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(134, 20);
            this.txtTongTien.TabIndex = 23;
            // 
            // dgvPhieuXuatKho
            // 
            this.dgvPhieuXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuatKho.Location = new System.Drawing.Point(32, 256);
            this.dgvPhieuXuatKho.Name = "dgvPhieuXuatKho";
            this.dgvPhieuXuatKho.Size = new System.Drawing.Size(383, 165);
            this.dgvPhieuXuatKho.TabIndex = 14;
            this.dgvPhieuXuatKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuXuatKho_CellClick);
            this.dgvPhieuXuatKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuXuatKho_CellContentClick_1);
            // 
            // lblDanhSachDatHang
            // 
            this.lblDanhSachDatHang.AutoSize = true;
            this.lblDanhSachDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSachDatHang.Location = new System.Drawing.Point(36, 232);
            this.lblDanhSachDatHang.Name = "lblDanhSachDatHang";
            this.lblDanhSachDatHang.Size = new System.Drawing.Size(157, 15);
            this.lblDanhSachDatHang.TabIndex = 15;
            this.lblDanhSachDatHang.Text = "DANH SÁCH ĐẶT HÀNG";
            this.lblDanhSachDatHang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDanhSachDatHang.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvTinhTrangThanhToan
            // 
            this.dgvTinhTrangThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhTrangThanhToan.Location = new System.Drawing.Point(439, 33);
            this.dgvTinhTrangThanhToan.Name = "dgvTinhTrangThanhToan";
            this.dgvTinhTrangThanhToan.Size = new System.Drawing.Size(518, 150);
            this.dgvTinhTrangThanhToan.TabIndex = 16;
            // 
            // lblTinhTrangThanhToan
            // 
            this.lblTinhTrangThanhToan.AutoSize = true;
            this.lblTinhTrangThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrangThanhToan.Location = new System.Drawing.Point(436, 9);
            this.lblTinhTrangThanhToan.Name = "lblTinhTrangThanhToan";
            this.lblTinhTrangThanhToan.Size = new System.Drawing.Size(179, 15);
            this.lblTinhTrangThanhToan.TabIndex = 17;
            this.lblTinhTrangThanhToan.Text = "TÌNH TRẠNG THANH TOÁN";
            this.lblTinhTrangThanhToan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTinhTrangDonHang
            // 
            this.lblTinhTrangDonHang.AutoSize = true;
            this.lblTinhTrangDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrangDonHang.Location = new System.Drawing.Point(436, 227);
            this.lblTinhTrangDonHang.Name = "lblTinhTrangDonHang";
            this.lblTinhTrangDonHang.Size = new System.Drawing.Size(165, 15);
            this.lblTinhTrangDonHang.TabIndex = 18;
            this.lblTinhTrangDonHang.Text = "TÌNH TRẠNG ĐƠN HÀNG";
            this.lblTinhTrangDonHang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTinhTrangDonHang
            // 
            this.dgvTinhTrangDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhTrangDonHang.Location = new System.Drawing.Point(439, 256);
            this.dgvTinhTrangDonHang.Name = "dgvTinhTrangDonHang";
            this.dgvTinhTrangDonHang.Size = new System.Drawing.Size(518, 165);
            this.dgvTinhTrangDonHang.TabIndex = 19;
            // 
            // frmPhieuXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 483);
            this.Controls.Add(this.dgvTinhTrangDonHang);
            this.Controls.Add(this.lblTinhTrangDonHang);
            this.Controls.Add(this.lblTinhTrangThanhToan);
            this.Controls.Add(this.dgvTinhTrangThanhToan);
            this.Controls.Add(this.lblDanhSachDatHang);
            this.Controls.Add(this.dgvPhieuXuatKho);
            this.Controls.Add(this.btnInPhieuXuatHang);
            this.Controls.Add(this.pnThongTin);
            this.Name = "frmPhieuXuatKho";
            this.Text = "PHIẾU XUẤT KHO";
            this.Load += new System.EventHandler(this.frmPhieuXuatKho_Load);
            this.pnThongTin.ResumeLayout(false);
            this.pnThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuatKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrangDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaDaiLy;
        private System.Windows.Forms.TextBox txtMaDaiLy;
        private System.Windows.Forms.Button btnInPhieuXuatHang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Panel pnThongTin;
        private System.Windows.Forms.DataGridView dgvPhieuXuatKho;
        private System.Windows.Forms.Label lblHinhThucThanhToan;
        private System.Windows.Forms.TextBox txtHinhThucThanhToan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label lblDanhSachDatHang;
        private System.Windows.Forms.DataGridView dgvTinhTrangThanhToan;
        private System.Windows.Forms.Label lblTinhTrangThanhToan;
        private System.Windows.Forms.Label lblTinhTrangDonHang;
        private System.Windows.Forms.DataGridView dgvTinhTrangDonHang;
    }
}