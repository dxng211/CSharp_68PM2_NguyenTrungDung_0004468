using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class UC_QuanLySinhVien : UserControl
    {
        databaseDataContext db = new databaseDataContext();
        public UC_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void grid_QLSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDSLCMBX();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            tbl_sinhvien sinhvien = new tbl_sinhvien();
            sinhvien.hoten = txt_HoTen.Text;
            sinhvien.id = txt_MSSV.Text;
            sinhvien.gioitinh = cmbGioiTinh.Text;
            sinhvien.ngaysinh = DateTime.Parse(date_NgaySinh.Text);
            sinhvien.malop = cmb_Lop.SelectedValue.ToString();
            try {
                db.tbl_sinhviens.InsertOnSubmit(sinhvien);
                db.SubmitChanges();
                MessageBox.Show("Thêm mới thành công");
                LoadData();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            

        }
        public void LoadData()
        {
            List<tbl_sinhvien> dSSV = db.tbl_sinhviens.ToList();
            grid_QLSV.DataSource = dSSV;
        }
        public void LoadDSLCMBX()
        {
            List<tbl_lophoc> dSLH = db.tbl_lophocs.ToList();
            cmb_Lop.DataSource = dSLH;
            cmb_Lop.DisplayMember = "tenlop";
            cmb_Lop.ValueMember = "malop";
        }

    }

}
