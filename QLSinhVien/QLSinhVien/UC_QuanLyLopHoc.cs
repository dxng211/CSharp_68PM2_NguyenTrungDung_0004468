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
    public partial class UC_QuanLyLopHoc : UserControl
    {
        databaseDataContext db = new databaseDataContext();
        public UC_QuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void UC_QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            List<tbl_lophoc> dSLH = db.tbl_lophocs.ToList();
            gridviewQLLH.DataSource = dSLH;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tbl_lophoc lophoc = new tbl_lophoc();
            lophoc.id = txtMaID.Text;
            lophoc.malop = txtMaLop.Text;
            lophoc.tenlop = txtTenLop.Text;
            lophoc.ghichu = txtGhiChu.Text;
            try
            {
                db.tbl_lophocs.InsertOnSubmit(lophoc);
                db.SubmitChanges();
                MessageBox.Show("Thêm mới thành công");
                LoadData();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
