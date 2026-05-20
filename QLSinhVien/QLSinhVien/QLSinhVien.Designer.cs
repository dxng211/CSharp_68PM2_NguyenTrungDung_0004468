namespace QLSinhVien
{
    partial class Quan_ly_sinh_vien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLLH = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLSV,
            this.menuQLLH,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuQLSV
            // 
            this.menuQLSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuQLSV.Name = "menuQLSV";
            this.menuQLSV.Size = new System.Drawing.Size(134, 24);
            this.menuQLSV.Text = "Quản lý sinh viên";
            this.menuQLSV.Click += new System.EventHandler(this.abcToolStripMenuItem_Click);
            // 
            // menuQLLH
            // 
            this.menuQLLH.Name = "menuQLLH";
            this.menuQLLH.Size = new System.Drawing.Size(127, 24);
            this.menuQLLH.Text = "Quản lý lớp học";
            this.menuQLLH.Click += new System.EventHandler(this.bcdToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 28);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1182, 625);
            this.pnl_main.TabIndex = 1;
            // 
            // Quan_ly_sinh_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Quan_ly_sinh_vien";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Quan_ly_sinh_vien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQLSV;
        private System.Windows.Forms.ToolStripMenuItem menuQLLH;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_main;
    }
}