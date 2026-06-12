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
    public partial class DSSinhVien1Lop : Form
    {
        private void label_TenLop_Click(object sender, EventArgs e)
        {

        }

        private void label_TongSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void grd_DSSV_Lop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private databaseDataContext db = new databaseDataContext();

        public DSSinhVien1Lop(string maLop)
        {
            InitializeComponent();
            LoadDanhSachSinhVien(maLop);
        }

        private void LoadDanhSachSinhVien(string maLop)
        {
            label_TenLop.Text = $"Danh sách sinh viên lớp {maLop.Trim()}";

            var dSSVTheoLop = db.tbl_sinhviens.Where(x => x.malop.Trim() == maLop.Trim()).ToList();

            grd_DSSV_Lop.DataSource = dSSVTheoLop;
            label_TongSinhVien.Text = $"Tổng số sinh viên: {dSSVTheoLop.Count}";
        }
    }
}
