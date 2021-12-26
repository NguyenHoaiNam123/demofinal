
namespace Test
{
    partial class frmMain
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
            this.btnPhieuNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhieuXuatKho = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.thsmThongKeuNhapXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPhieuNhapKho
            // 
            this.btnPhieuNhapKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNhapKho.Name = "btnPhieuNhapKho";
            this.btnPhieuNhapKho.Size = new System.Drawing.Size(158, 25);
            this.btnPhieuNhapKho.Text = "PHIẾU NHẬP KHO";
            this.btnPhieuNhapKho.Click += new System.EventHandler(this.btnPhieuNhapKho_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(105, 25);
            this.btnDatHang.Text = "ĐẶT HÀNG";
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // btnPhieuXuatKho
            // 
            this.btnPhieuXuatKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuXuatKho.Name = "btnPhieuXuatKho";
            this.btnPhieuXuatKho.Size = new System.Drawing.Size(154, 25);
            this.btnPhieuXuatKho.Text = "PHIẾU XUẤT KHO";
            this.btnPhieuXuatKho.Click += new System.EventHandler(this.btnPhieuXuatKho_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thsmThongKeuNhapXuat,
            this.doanhThuToolStripMenuItem});
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(102, 25);
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // thsmThongKeuNhapXuat
            // 
            this.thsmThongKeuNhapXuat.Name = "thsmThongKeuNhapXuat";
            this.thsmThongKeuNhapXuat.Size = new System.Drawing.Size(237, 26);
            this.thsmThongKeuNhapXuat.Text = "Thống Kê Nhập Xuất";
            this.thsmThongKeuNhapXuat.Click += new System.EventHandler(this.thoToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPhieuNhapKho,
            this.btnDatHang,
            this.btnPhieuXuatKho,
            this.btnThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::Test.Properties.Resources.tobacco;
            this.ClientSize = new System.Drawing.Size(977, 456);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "TOBACCO VIET COMPANY";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem btnPhieuNhapKho;
        private System.Windows.Forms.ToolStripMenuItem btnDatHang;
        private System.Windows.Forms.ToolStripMenuItem btnPhieuXuatKho;
        private System.Windows.Forms.ToolStripMenuItem btnThongKe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thsmThongKeuNhapXuat;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
    }
}

