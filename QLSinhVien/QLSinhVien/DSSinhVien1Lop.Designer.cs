namespace QLSinhVien
{
    partial class DSSinhVien1Lop
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_TenLop = new System.Windows.Forms.Label();
            this.label_TongSinhVien = new System.Windows.Forms.Label();
            this.grd_DSSV_Lop = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DSSV_Lop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grd_DSSV_Lop);
            this.panel1.Controls.Add(this.label_TongSinhVien);
            this.panel1.Controls.Add(this.label_TenLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 653);
            this.panel1.TabIndex = 0;
            // 
            // label_TenLop
            // 
            this.label_TenLop.AutoSize = true;
            this.label_TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenLop.Location = new System.Drawing.Point(45, 38);
            this.label_TenLop.Name = "label_TenLop";
            this.label_TenLop.Size = new System.Drawing.Size(59, 20);
            this.label_TenLop.TabIndex = 0;
            this.label_TenLop.Text = "label1";
            this.label_TenLop.Click += new System.EventHandler(this.label_TenLop_Click);
            // 
            // label_TongSinhVien
            // 
            this.label_TongSinhVien.AutoSize = true;
            this.label_TongSinhVien.Location = new System.Drawing.Point(46, 70);
            this.label_TongSinhVien.Name = "label_TongSinhVien";
            this.label_TongSinhVien.Size = new System.Drawing.Size(44, 16);
            this.label_TongSinhVien.TabIndex = 1;
            this.label_TongSinhVien.Text = "label1";
            this.label_TongSinhVien.Click += new System.EventHandler(this.label_TongSinhVien_Click);
            // 
            // grd_DSSV_Lop
            // 
            this.grd_DSSV_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_DSSV_Lop.Location = new System.Drawing.Point(49, 103);
            this.grd_DSSV_Lop.Name = "grd_DSSV_Lop";
            this.grd_DSSV_Lop.RowHeadersWidth = 51;
            this.grd_DSSV_Lop.RowTemplate.Height = 24;
            this.grd_DSSV_Lop.Size = new System.Drawing.Size(1050, 500);
            this.grd_DSSV_Lop.TabIndex = 2;
            this.grd_DSSV_Lop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_DSSV_Lop_CellContentClick);
            // 
            // DSSinhVien1Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel1);
            this.Name = "DSSinhVien1Lop";
            this.Text = "DSSinhVien1Lop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DSSV_Lop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grd_DSSV_Lop;
        private System.Windows.Forms.Label label_TongSinhVien;
        private System.Windows.Forms.Label label_TenLop;
    }
}