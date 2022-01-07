
namespace Test
{
    partial class frmThongKe
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
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.grpXuatKho = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMaDaiLy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDaiLy = new System.Windows.Forms.TextBox();
            this.lblMaMatHang = new System.Windows.Forms.Label();
            this.txtMaMatHang = new System.Windows.Forms.TextBox();
            this.txtTenDaiLy = new System.Windows.Forms.TextBox();
            this.lblTenDaiLy = new System.Windows.Forms.Label();
            this.dgvNhapKho = new System.Windows.Forms.DataGridView();
            this.dgvXuatKho = new System.Windows.Forms.DataGridView();
            this.grpNhapThongTin.SuspendLayout();
            this.grpXuatKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatKho)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNhapThongTin
            // 
            this.grpNhapThongTin.Controls.Add(this.txtTongTien);
            this.grpNhapThongTin.Controls.Add(this.lblTongTien);
            this.grpNhapThongTin.Controls.Add(this.txtSoLuong);
            this.grpNhapThongTin.Controls.Add(this.lblSoluong);
            this.grpNhapThongTin.Controls.Add(this.txtMaHang);
            this.grpNhapThongTin.Controls.Add(this.lblMaHang);
            this.grpNhapThongTin.Controls.Add(this.cboTenHang);
            this.grpNhapThongTin.Controls.Add(this.lblTenHang);
            this.grpNhapThongTin.Location = new System.Drawing.Point(21, 12);
            this.grpNhapThongTin.Name = "grpNhapThongTin";
            this.grpNhapThongTin.Size = new System.Drawing.Size(310, 184);
            this.grpNhapThongTin.TabIndex = 10;
            this.grpNhapThongTin.TabStop = false;
            this.grpNhapThongTin.Text = "Nhập Kho";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(85, 133);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(196, 20);
            this.txtTongTien.TabIndex = 11;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(6, 140);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(59, 13);
            this.lblTongTien.TabIndex = 11;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(85, 100);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(196, 20);
            this.txtSoLuong.TabIndex = 11;
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(6, 100);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(56, 13);
            this.lblSoluong.TabIndex = 11;
            this.lblSoluong.Text = "Số Lượng:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(85, 23);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(196, 20);
            this.txtMaHang.TabIndex = 17;
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Location = new System.Drawing.Point(6, 26);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(54, 13);
            this.lblMaHang.TabIndex = 16;
            this.lblMaHang.Text = "Mã Hàng:";
            // 
            // cboTenHang
            // 
            this.cboTenHang.FormattingEnabled = true;
            this.cboTenHang.Items.AddRange(new object[] {
            "Jet",
            "555",
            "Craven",
            "Khánh Hội",
            "Kent",
            "Marlboro",
            "Camel",
            "Mond"});
            this.cboTenHang.Location = new System.Drawing.Point(85, 55);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(196, 21);
            this.cboTenHang.TabIndex = 15;
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(6, 58);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(58, 13);
            this.lblTenHang.TabIndex = 3;
            this.lblTenHang.Text = "Tên Hàng:";
            // 
            // grpXuatKho
            // 
            this.grpXuatKho.Controls.Add(this.textBox1);
            this.grpXuatKho.Controls.Add(this.label2);
            this.grpXuatKho.Controls.Add(this.comboBox1);
            this.grpXuatKho.Controls.Add(this.lblMaDaiLy);
            this.grpXuatKho.Controls.Add(this.label1);
            this.grpXuatKho.Controls.Add(this.txtMaDaiLy);
            this.grpXuatKho.Controls.Add(this.lblMaMatHang);
            this.grpXuatKho.Controls.Add(this.txtMaMatHang);
            this.grpXuatKho.Controls.Add(this.txtTenDaiLy);
            this.grpXuatKho.Controls.Add(this.lblTenDaiLy);
            this.grpXuatKho.Location = new System.Drawing.Point(389, 12);
            this.grpXuatKho.Name = "grpXuatKho";
            this.grpXuatKho.Size = new System.Drawing.Size(336, 192);
            this.grpXuatKho.TabIndex = 11;
            this.grpXuatKho.TabStop = false;
            this.grpXuatKho.Text = "Xuất Kho";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tổng Tiền:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Jet",
            "555",
            "Craven",
            "Khánh Hội",
            "Kent",
            "Marlboro",
            "Camel",
            "Mond"});
            this.comboBox1.Location = new System.Drawing.Point(87, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // lblMaDaiLy
            // 
            this.lblMaDaiLy.AutoSize = true;
            this.lblMaDaiLy.Location = new System.Drawing.Point(6, 26);
            this.lblMaDaiLy.Name = "lblMaDaiLy";
            this.lblMaDaiLy.Size = new System.Drawing.Size(58, 13);
            this.lblMaDaiLy.TabIndex = 0;
            this.lblMaDaiLy.Text = "Mã Đại Lý:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Hàng:";
            // 
            // txtMaDaiLy
            // 
            this.txtMaDaiLy.Location = new System.Drawing.Point(87, 26);
            this.txtMaDaiLy.Name = "txtMaDaiLy";
            this.txtMaDaiLy.Size = new System.Drawing.Size(196, 20);
            this.txtMaDaiLy.TabIndex = 5;
            // 
            // lblMaMatHang
            // 
            this.lblMaMatHang.AutoSize = true;
            this.lblMaMatHang.Location = new System.Drawing.Point(6, 100);
            this.lblMaMatHang.Name = "lblMaMatHang";
            this.lblMaMatHang.Size = new System.Drawing.Size(75, 13);
            this.lblMaMatHang.TabIndex = 1;
            this.lblMaMatHang.Text = "Mã Mặt Hàng:";
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.Location = new System.Drawing.Point(87, 97);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.Size = new System.Drawing.Size(196, 20);
            this.txtMaMatHang.TabIndex = 7;
            // 
            // txtTenDaiLy
            // 
            this.txtTenDaiLy.Location = new System.Drawing.Point(87, 55);
            this.txtTenDaiLy.Name = "txtTenDaiLy";
            this.txtTenDaiLy.Size = new System.Drawing.Size(196, 20);
            this.txtTenDaiLy.TabIndex = 6;
            // 
            // lblTenDaiLy
            // 
            this.lblTenDaiLy.AutoSize = true;
            this.lblTenDaiLy.Location = new System.Drawing.Point(6, 58);
            this.lblTenDaiLy.Name = "lblTenDaiLy";
            this.lblTenDaiLy.Size = new System.Drawing.Size(62, 13);
            this.lblTenDaiLy.TabIndex = 2;
            this.lblTenDaiLy.Text = "Tên Đại Lý:";
            // 
            // dgvNhapKho
            // 
            this.dgvNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapKho.Location = new System.Drawing.Point(21, 262);
            this.dgvNhapKho.Name = "dgvNhapKho";
            this.dgvNhapKho.Size = new System.Drawing.Size(310, 150);
            this.dgvNhapKho.TabIndex = 12;
            this.dgvNhapKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvXuatKho
            // 
            this.dgvXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXuatKho.Location = new System.Drawing.Point(389, 262);
            this.dgvXuatKho.Name = "dgvXuatKho";
            this.dgvXuatKho.Size = new System.Drawing.Size(336, 150);
            this.dgvXuatKho.TabIndex = 13;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 472);
            this.Controls.Add(this.dgvXuatKho);
            this.Controls.Add(this.dgvNhapKho);
            this.Controls.Add(this.grpXuatKho);
            this.Controls.Add(this.grpNhapThongTin);
            this.Name = "frmThongKe";
            this.Text = "THỐNG KÊ";
            this.grpNhapThongTin.ResumeLayout(false);
            this.grpNhapThongTin.PerformLayout();
            this.grpXuatKho.ResumeLayout(false);
            this.grpXuatKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXuatKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhapThongTin;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.GroupBox grpXuatKho;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaMatHang;
        private System.Windows.Forms.TextBox txtMaMatHang;
        private System.Windows.Forms.TextBox txtTenDaiLy;
        private System.Windows.Forms.Label lblTenDaiLy;
        private System.Windows.Forms.Label lblMaDaiLy;
        private System.Windows.Forms.TextBox txtMaDaiLy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvNhapKho;
        private System.Windows.Forms.DataGridView dgvXuatKho;
    }
}