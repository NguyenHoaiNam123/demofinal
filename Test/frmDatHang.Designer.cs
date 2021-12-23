
namespace Test
{
    partial class frmDatHang
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
            this.grpNhapThongTin = new System.Windows.Forms.GroupBox();
            this.rdbtnTienMat = new System.Windows.Forms.RadioButton();
            this.rdbtnChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.rdbtnMomo = new System.Windows.Forms.RadioButton();
            this.lblHinhThucThanhToan = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.lblMaDaiLy = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.dgvDatHang = new System.Windows.Forms.DataGridView();
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbTenHang = new System.Windows.Forms.ComboBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.grpNhapThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNhapThongTin
            // 
            this.grpNhapThongTin.Controls.Add(this.txtGia);
            this.grpNhapThongTin.Controls.Add(this.lblGia);
            this.grpNhapThongTin.Controls.Add(this.cbbTenHang);
            this.grpNhapThongTin.Controls.Add(this.nmSoLuong);
            this.grpNhapThongTin.Controls.Add(this.rdbtnTienMat);
            this.grpNhapThongTin.Controls.Add(this.rdbtnChuyenKhoan);
            this.grpNhapThongTin.Controls.Add(this.rdbtnMomo);
            this.grpNhapThongTin.Controls.Add(this.lblHinhThucThanhToan);
            this.grpNhapThongTin.Controls.Add(this.btnSua);
            this.grpNhapThongTin.Controls.Add(this.btnThem);
            this.grpNhapThongTin.Controls.Add(this.txtMaHang);
            this.grpNhapThongTin.Controls.Add(this.lblMaDaiLy);
            this.grpNhapThongTin.Controls.Add(this.btnLuu);
            this.grpNhapThongTin.Controls.Add(this.btnThoat);
            this.grpNhapThongTin.Controls.Add(this.txtTongTien);
            this.grpNhapThongTin.Controls.Add(this.lblTongTien);
            this.grpNhapThongTin.Controls.Add(this.lblSoluong);
            this.grpNhapThongTin.Controls.Add(this.lblTenHang);
            this.grpNhapThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpNhapThongTin.Name = "grpNhapThongTin";
            this.grpNhapThongTin.Size = new System.Drawing.Size(599, 217);
            this.grpNhapThongTin.TabIndex = 2;
            this.grpNhapThongTin.TabStop = false;
            this.grpNhapThongTin.Text = "Nhập thông tin";
            // 
            // rdbtnTienMat
            // 
            this.rdbtnTienMat.AutoSize = true;
            this.rdbtnTienMat.Location = new System.Drawing.Point(460, 79);
            this.rdbtnTienMat.Name = "rdbtnTienMat";
            this.rdbtnTienMat.Size = new System.Drawing.Size(67, 17);
            this.rdbtnTienMat.TabIndex = 22;
            this.rdbtnTienMat.TabStop = true;
            this.rdbtnTienMat.Text = "Tiền Mặt";
            this.rdbtnTienMat.UseVisualStyleBackColor = true;
            // 
            // rdbtnChuyenKhoan
            // 
            this.rdbtnChuyenKhoan.AutoSize = true;
            this.rdbtnChuyenKhoan.Location = new System.Drawing.Point(460, 48);
            this.rdbtnChuyenKhoan.Name = "rdbtnChuyenKhoan";
            this.rdbtnChuyenKhoan.Size = new System.Drawing.Size(131, 17);
            this.rdbtnChuyenKhoan.TabIndex = 21;
            this.rdbtnChuyenKhoan.TabStop = true;
            this.rdbtnChuyenKhoan.Text = "Chuyển Khoản: Số TK";
            this.rdbtnChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // rdbtnMomo
            // 
            this.rdbtnMomo.AutoSize = true;
            this.rdbtnMomo.Location = new System.Drawing.Point(460, 16);
            this.rdbtnMomo.Name = "rdbtnMomo";
            this.rdbtnMomo.Size = new System.Drawing.Size(105, 17);
            this.rdbtnMomo.TabIndex = 20;
            this.rdbtnMomo.TabStop = true;
            this.rdbtnMomo.Text = "Momo: Số Momo";
            this.rdbtnMomo.UseVisualStyleBackColor = true;
            // 
            // lblHinhThucThanhToan
            // 
            this.lblHinhThucThanhToan.AutoSize = true;
            this.lblHinhThucThanhToan.Location = new System.Drawing.Point(331, 16);
            this.lblHinhThucThanhToan.Name = "lblHinhThucThanhToan";
            this.lblHinhThucThanhToan.Size = new System.Drawing.Size(122, 13);
            this.lblHinhThucThanhToan.TabIndex = 19;
            this.lblHinhThucThanhToan.Text = "Hình Thức Thanh Toán:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(125, 169);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 169);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(88, 16);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(207, 20);
            this.txtMaHang.TabIndex = 16;
            // 
            // lblMaDaiLy
            // 
            this.lblMaDaiLy.AutoSize = true;
            this.lblMaDaiLy.Location = new System.Drawing.Point(6, 16);
            this.lblMaDaiLy.Name = "lblMaDaiLy";
            this.lblMaDaiLy.Size = new System.Drawing.Size(58, 13);
            this.lblMaDaiLy.TabIndex = 15;
            this.lblMaDaiLy.Text = "Mã Đại Lý:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(375, 169);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(248, 169);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(88, 143);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(207, 20);
            this.txtTongTien.TabIndex = 8;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtGiaTien_TextChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(7, 146);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(59, 13);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(10, 117);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(56, 13);
            this.lblSoluong.TabIndex = 2;
            this.lblSoluong.Text = "Số Lượng:";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(6, 44);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(58, 13);
            this.lblTenHang.TabIndex = 0;
            this.lblTenHang.Text = "Tên Hàng:";
            // 
            // dgvDatHang
            // 
            this.dgvDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatHang.Location = new System.Drawing.Point(12, 235);
            this.dgvDatHang.Name = "dgvDatHang";
            this.dgvDatHang.Size = new System.Drawing.Size(599, 150);
            this.dgvDatHang.TabIndex = 3;
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.Location = new System.Drawing.Point(88, 115);
            this.nmSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(113, 20);
            this.nmSoLuong.TabIndex = 26;
            this.nmSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbTenHang
            // 
            this.cbbTenHang.FormattingEnabled = true;
            this.cbbTenHang.Items.AddRange(new object[] {
            "Jet",
            "Hero",
            "555",
            "Sài Gòn",
            "Marlboro",
            "Craven",
            "Khánh Hội",
            "Camel",
            "Marula"});
            this.cbbTenHang.Location = new System.Drawing.Point(88, 44);
            this.cbbTenHang.Name = "cbbTenHang";
            this.cbbTenHang.Size = new System.Drawing.Size(207, 21);
            this.cbbTenHang.TabIndex = 27;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(8, 83);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(26, 13);
            this.lblGia.TabIndex = 28;
            this.lblGia.Text = "Giá:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(88, 83);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(207, 20);
            this.txtGia.TabIndex = 29;
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 426);
            this.Controls.Add(this.dgvDatHang);
            this.Controls.Add(this.grpNhapThongTin);
            this.Name = "frmDatHang";
            this.Text = "Đặt Hàng";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            this.grpNhapThongTin.ResumeLayout(false);
            this.grpNhapThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhapThongTin;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label lblMaDaiLy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.DataGridView dgvDatHang;
        private System.Windows.Forms.RadioButton rdbtnTienMat;
        private System.Windows.Forms.RadioButton rdbtnChuyenKhoan;
        private System.Windows.Forms.RadioButton rdbtnMomo;
        private System.Windows.Forms.Label lblHinhThucThanhToan;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.ComboBox cbbTenHang;
    }
}