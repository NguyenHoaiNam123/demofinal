﻿
namespace Test
{
    partial class frmPhieuNhapKho
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
            this.labelTen = new System.Windows.Forms.Label();
            this.grpNhapThongTin = new System.Windows.Forms.GroupBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtGiaNhapHang = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblGiaNhapHang = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.dsPhieuNhapKho = new System.Windows.Forms.DataGridView();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.grpNhapThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhieuNhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(3, 19);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(0, 13);
            this.labelTen.TabIndex = 0;
            this.labelTen.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpNhapThongTin
            // 
            this.grpNhapThongTin.Controls.Add(this.txtTongTien);
            this.grpNhapThongTin.Controls.Add(this.lblTongTien);
            this.grpNhapThongTin.Controls.Add(this.lblNgayNhap);
            this.grpNhapThongTin.Controls.Add(this.dtpNgayNhap);
            this.grpNhapThongTin.Controls.Add(this.txtTenHang);
            this.grpNhapThongTin.Controls.Add(this.btnSua);
            this.grpNhapThongTin.Controls.Add(this.btnThem);
            this.grpNhapThongTin.Controls.Add(this.txtMaHang);
            this.grpNhapThongTin.Controls.Add(this.lblMaHang);
            this.grpNhapThongTin.Controls.Add(this.btnXoa);
            this.grpNhapThongTin.Controls.Add(this.btnThoat);
            this.grpNhapThongTin.Controls.Add(this.txtGiaNhapHang);
            this.grpNhapThongTin.Controls.Add(this.txtSoLuong);
            this.grpNhapThongTin.Controls.Add(this.lblGiaNhapHang);
            this.grpNhapThongTin.Controls.Add(this.lblSoluong);
            this.grpNhapThongTin.Controls.Add(this.lblTenHang);
            this.grpNhapThongTin.Location = new System.Drawing.Point(13, 19);
            this.grpNhapThongTin.Name = "grpNhapThongTin";
            this.grpNhapThongTin.Size = new System.Drawing.Size(683, 250);
            this.grpNhapThongTin.TabIndex = 1;
            this.grpNhapThongTin.TabStop = false;
            this.grpNhapThongTin.Text = "Nhập thông tin";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(88, 43);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(207, 20);
            this.txtTenHang.TabIndex = 19;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(126, 212);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(9, 212);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(88, 16);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(207, 20);
            this.txtMaHang.TabIndex = 16;
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Location = new System.Drawing.Point(6, 16);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(54, 13);
            this.lblMaHang.TabIndex = 15;
            this.lblMaHang.Text = "Mã Hàng:";
            this.lblMaHang.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(255, 212);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(383, 212);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGiaNhapHang
            // 
            this.txtGiaNhapHang.Location = new System.Drawing.Point(88, 108);
            this.txtGiaNhapHang.Name = "txtGiaNhapHang";
            this.txtGiaNhapHang.Size = new System.Drawing.Size(207, 20);
            this.txtGiaNhapHang.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(88, 75);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(207, 20);
            this.txtSoLuong.TabIndex = 7;
            // 
            // lblGiaNhapHang
            // 
            this.lblGiaNhapHang.AutoSize = true;
            this.lblGiaNhapHang.Location = new System.Drawing.Point(6, 111);
            this.lblGiaNhapHang.Name = "lblGiaNhapHang";
            this.lblGiaNhapHang.Size = new System.Drawing.Size(84, 13);
            this.lblGiaNhapHang.TabIndex = 3;
            this.lblGiaNhapHang.Text = "Giá Nhập Hàng:";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(6, 82);
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
            // dsPhieuNhapKho
            // 
            this.dsPhieuNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsPhieuNhapKho.Location = new System.Drawing.Point(12, 275);
            this.dsPhieuNhapKho.Name = "dsPhieuNhapKho";
            this.dsPhieuNhapKho.Size = new System.Drawing.Size(684, 150);
            this.dsPhieuNhapKho.TabIndex = 2;
            this.dsPhieuNhapKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsPhieuNhapKho_CellContentClick);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(88, 173);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(207, 20);
            this.dtpNgayNhap.TabIndex = 20;
            this.dtpNgayNhap.ValueChanged += new System.EventHandler(this.dtpNgayNhap_ValueChanged);
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(6, 173);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(64, 13);
            this.lblNgayNhap.TabIndex = 21;
            this.lblNgayNhap.Text = "Ngày Nhập:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(6, 139);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(59, 13);
            this.lblTongTien.TabIndex = 22;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(88, 136);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(207, 20);
            this.txtTongTien.TabIndex = 23;
            // 
            // frmPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 437);
            this.Controls.Add(this.dsPhieuNhapKho);
            this.Controls.Add(this.grpNhapThongTin);
            this.Controls.Add(this.labelTen);
            this.Name = "frmPhieuNhapKho";
            this.Text = "PHIẾU NHẬP KHO";
            this.Load += new System.EventHandler(this.frmPhieuNhapKho_Load);
            this.grpNhapThongTin.ResumeLayout(false);
            this.grpNhapThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPhieuNhapKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.GroupBox grpNhapThongTin;
        private System.Windows.Forms.TextBox txtGiaNhapHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblGiaNhapHang;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dsPhieuNhapKho;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
    }
}