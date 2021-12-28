
namespace Test
{
    partial class frmInPhieuXuatKho
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
            this.InnPhieuXuatKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.PhieuXuatKho1 = new Test.PhieuXuatKho();
            this.SuspendLayout();
            // 
            // InnPhieuXuatKho
            // 
            this.InnPhieuXuatKho.ActiveViewIndex = 0;
            this.InnPhieuXuatKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InnPhieuXuatKho.Cursor = System.Windows.Forms.Cursors.Default;
            this.InnPhieuXuatKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnPhieuXuatKho.Location = new System.Drawing.Point(0, 0);
            this.InnPhieuXuatKho.Name = "InnPhieuXuatKho";
            this.InnPhieuXuatKho.ReportSource = this.PhieuXuatKho1;
            this.InnPhieuXuatKho.Size = new System.Drawing.Size(860, 450);
            this.InnPhieuXuatKho.TabIndex = 0;
            // 
            // frmInPhieuXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.InnPhieuXuatKho);
            this.Name = "frmInPhieuXuatKho";
            this.Text = "frmInPhieuXuatKho";
            this.ResumeLayout(false);

        }

        #endregion
        private PhieuXuatKho PhieuXuatKho1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer InnPhieuXuatKho;
    }
}