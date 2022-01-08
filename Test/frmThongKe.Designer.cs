
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
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.rdbNhapKho = new System.Windows.Forms.RadioButton();
            this.rdbXuatKho = new System.Windows.Forms.RadioButton();
            this.rdbTatCaMatHang = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvThongKe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 115);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(848, 259);
            this.dgvThongKe.TabIndex = 0;
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKe.Location = new System.Drawing.Point(657, 9);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(157, 15);
            this.lblThongKe.TabIndex = 18;
            this.lblThongKe.Text = "THỐNG KÊ NHẬP XUẤT";
            this.lblThongKe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdbNhapKho
            // 
            this.rdbNhapKho.AutoSize = true;
            this.rdbNhapKho.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbNhapKho.Location = new System.Drawing.Point(611, 46);
            this.rdbNhapKho.Name = "rdbNhapKho";
            this.rdbNhapKho.Size = new System.Drawing.Size(73, 17);
            this.rdbNhapKho.TabIndex = 19;
            this.rdbNhapKho.Text = "Nhập Kho";
            this.rdbNhapKho.UseVisualStyleBackColor = true;
            // 
            // rdbXuatKho
            // 
            this.rdbXuatKho.AutoSize = true;
            this.rdbXuatKho.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbXuatKho.Location = new System.Drawing.Point(690, 46);
            this.rdbXuatKho.Name = "rdbXuatKho";
            this.rdbXuatKho.Size = new System.Drawing.Size(69, 17);
            this.rdbXuatKho.TabIndex = 20;
            this.rdbXuatKho.Text = "Xuất Kho";
            this.rdbXuatKho.UseVisualStyleBackColor = true;
            // 
            // rdbTatCaMatHang
            // 
            this.rdbTatCaMatHang.AutoSize = true;
            this.rdbTatCaMatHang.Checked = true;
            this.rdbTatCaMatHang.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbTatCaMatHang.Location = new System.Drawing.Point(502, 46);
            this.rdbTatCaMatHang.Name = "rdbTatCaMatHang";
            this.rdbTatCaMatHang.Size = new System.Drawing.Size(103, 17);
            this.rdbTatCaMatHang.TabIndex = 21;
            this.rdbTatCaMatHang.TabStop = true;
            this.rdbTatCaMatHang.Text = "Tất cả mặt hàng";
            this.rdbTatCaMatHang.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.ForeColor = System.Drawing.Color.Red;
            this.btnThongKe.Location = new System.Drawing.Point(765, 43);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 22;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "TOBACCO VIET COMPANY";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(848, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.rdbTatCaMatHang);
            this.Controls.Add(this.rdbXuatKho);
            this.Controls.Add(this.rdbNhapKho);
            this.Controls.Add(this.lblThongKe);
            this.Controls.Add(this.dgvThongKe);
            this.Name = "frmThongKe";
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.RadioButton rdbNhapKho;
        private System.Windows.Forms.RadioButton rdbXuatKho;
        private System.Windows.Forms.RadioButton rdbTatCaMatHang;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label1;
    }
}