
namespace Test
{
    partial class frmDoanhThu
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
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.rdbXuatKho = new System.Windows.Forms.RadioButton();
            this.rdbNhapKho = new System.Windows.Forms.RadioButton();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.rdbDoanhThu = new System.Windows.Forms.RadioButton();
            this.mtbTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.mtbDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.Location = new System.Drawing.Point(695, 9);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(87, 15);
            this.lblDoanhThu.TabIndex = 19;
            this.lblDoanhThu.Text = "DOANH THU";
            this.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDoanhThu.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(-8, 147);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.Size = new System.Drawing.Size(848, 245);
            this.dgvDoanhThu.TabIndex = 20;
            // 
            // rdbXuatKho
            // 
            this.rdbXuatKho.AutoSize = true;
            this.rdbXuatKho.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbXuatKho.Location = new System.Drawing.Point(503, 101);
            this.rdbXuatKho.Name = "rdbXuatKho";
            this.rdbXuatKho.Size = new System.Drawing.Size(69, 17);
            this.rdbXuatKho.TabIndex = 23;
            this.rdbXuatKho.Text = "Xuất Kho";
            this.rdbXuatKho.UseVisualStyleBackColor = true;
            // 
            // rdbNhapKho
            // 
            this.rdbNhapKho.AutoSize = true;
            this.rdbNhapKho.Checked = true;
            this.rdbNhapKho.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbNhapKho.Location = new System.Drawing.Point(412, 101);
            this.rdbNhapKho.Name = "rdbNhapKho";
            this.rdbNhapKho.Size = new System.Drawing.Size(73, 17);
            this.rdbNhapKho.TabIndex = 22;
            this.rdbNhapKho.TabStop = true;
            this.rdbNhapKho.Text = "Nhập Kho";
            this.rdbNhapKho.UseVisualStyleBackColor = true;
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.btnDoanhThu.Location = new System.Drawing.Point(737, 98);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(75, 23);
            this.btnDoanhThu.TabIndex = 25;
            this.btnDoanhThu.Text = "Doanh Thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // rdbDoanhThu
            // 
            this.rdbDoanhThu.AutoSize = true;
            this.rdbDoanhThu.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbDoanhThu.Location = new System.Drawing.Point(589, 101);
            this.rdbDoanhThu.Name = "rdbDoanhThu";
            this.rdbDoanhThu.Size = new System.Drawing.Size(79, 17);
            this.rdbDoanhThu.TabIndex = 24;
            this.rdbDoanhThu.Text = "Doanh Thu";
            this.rdbDoanhThu.UseVisualStyleBackColor = true;
            // 
            // mtbTuNgay
            // 
            this.mtbTuNgay.Location = new System.Drawing.Point(545, 50);
            this.mtbTuNgay.Mask = "00/00/0000";
            this.mtbTuNgay.Name = "mtbTuNgay";
            this.mtbTuNgay.Size = new System.Drawing.Size(100, 20);
            this.mtbTuNgay.TabIndex = 26;
            this.mtbTuNgay.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDenNgay
            // 
            this.mtbDenNgay.Location = new System.Drawing.Point(712, 50);
            this.mtbDenNgay.Mask = "00/00/0000";
            this.mtbDenNgay.Name = "mtbDenNgay";
            this.mtbDenNgay.Size = new System.Drawing.Size(100, 20);
            this.mtbDenNgay.TabIndex = 27;
            this.mtbDenNgay.ValidatingType = typeof(System.DateTime);
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(480, 53);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(48, 13);
            this.lblTuNgay.TabIndex = 28;
            this.lblTuNgay.Text = "Từ Ngày";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(651, 53);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(55, 13);
            this.lblDenNgay.TabIndex = 29;
            this.lblDenNgay.Text = "Đến Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "TOBACCO VIET COMPANY";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.Color.Red;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtThanhTien.Location = new System.Drawing.Point(712, 407);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(100, 20);
            this.txtThanhTien.TabIndex = 31;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.mtbDenNgay);
            this.Controls.Add(this.mtbTuNgay);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.rdbDoanhThu);
            this.Controls.Add(this.rdbXuatKho);
            this.Controls.Add(this.rdbNhapKho);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.lblDoanhThu);
            this.Name = "frmDoanhThu";
            this.Text = "DOANH THU";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.RadioButton rdbXuatKho;
        private System.Windows.Forms.RadioButton rdbNhapKho;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.RadioButton rdbDoanhThu;
        private System.Windows.Forms.MaskedTextBox mtbTuNgay;
        private System.Windows.Forms.MaskedTextBox mtbDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThanhTien;
    }
}