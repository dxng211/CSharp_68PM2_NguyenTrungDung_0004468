using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class Quan_ly_sinh_vien : Form
    {
        public Quan_ly_sinh_vien()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void abcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QuanLySinhVien uC_QuanLySinhVien = new UC_QuanLySinhVien();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(uC_QuanLySinhVien);
            menuQLSV.Font = new Font(menuQLSV.Font, FontStyle.Bold);
            menuQLLH.Font = new Font(menuQLLH.Font, FontStyle.Regular);
        }

        private void bcdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_QuanLyLopHoc uC_QuanLyLopHoc = new UC_QuanLyLopHoc();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(uC_QuanLyLopHoc);
            menuQLSV.Font = new Font(menuQLSV.Font, FontStyle.Regular);
            menuQLLH.Font = new Font(menuQLLH.Font, FontStyle.Bold);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Quan_ly_sinh_vien_Load(object sender, EventArgs e)
        {
            menuQLSV.Font = new Font(menuQLSV.Font, FontStyle.Bold);
            menuQLLH.Font = new Font(menuQLLH.Font, FontStyle.Regular);
            //thay doi noi dung panel
            UC_QuanLySinhVien uC_QuanLySinhVien = new UC_QuanLySinhVien();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(uC_QuanLySinhVien);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
