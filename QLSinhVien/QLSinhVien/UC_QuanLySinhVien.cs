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
        int trangHienTai = 1;
        int soDongTrenTrang = 5;
        public UC_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadDataPhanTrang();
            LoadDSLCMBX();
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
                LoadDataPhanTrang();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void grid_QLSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = grid_QLSV.Rows[e.RowIndex];

            txt_MSSV.Text = row.Cells["id"].Value.ToString();
            txt_MSSV.ReadOnly = true;
            txt_HoTen.Text = row.Cells["hoten"].Value.ToString();
            cmbGioiTinh.Text = row.Cells["gioitinh"].Value.ToString();
            
            if (row.Cells["ngaysinh"].Value != DBNull.Value && row.Cells["ngaysinh"].Value != null)
            {
                date_NgaySinh.Value = Convert.ToDateTime(row.Cells["ngaysinh"].Value);
            }

            if (row.Cells["malop"].Value != null)
            {
                cmb_Lop.SelectedValue = row.Cells["malop"].Value;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            tbl_sinhvien sinhvien = db.tbl_sinhviens.SingleOrDefault(x => x.id == txt_MSSV.Text);

            sinhvien.hoten = txt_HoTen.Text;
            sinhvien.gioitinh = cmbGioiTinh.Text;
            sinhvien.ngaysinh = DateTime.Parse(date_NgaySinh.Text);
            sinhvien.malop = cmb_Lop.SelectedValue.ToString();
            try
            {
                db.SubmitChanges();

                MessageBox.Show("Sửa thành công");
                LoadDataPhanTrang();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            tbl_sinhvien sinhvien = db.tbl_sinhviens.SingleOrDefault(x => x.id == txt_MSSV.Text);
            try
            {
                db.tbl_sinhviens.DeleteOnSubmit(sinhvien);

                db.SubmitChanges();
                MessageBox.Show("Xóa thành công");
                LoadDataPhanTrang();

                btn_LamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MSSV.Clear();
            txt_MSSV.ReadOnly = false;
            txt_HoTen.Clear();
            date_NgaySinh.Value = DateTime.Now;
            if (cmbGioiTinh.Items.Count > 0) cmbGioiTinh.SelectedIndex = 0;
            if (cmb_Lop.Items.Count > 0) cmb_Lop.SelectedIndex = 0;
            LoadDataPhanTrang() ;

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txt_TimKiem.Text;

            List<tbl_sinhvien> ketQua = db.tbl_sinhviens.Where(x => x.hoten.Contains(tuKhoa)
                                                                || x.id == tuKhoa
                                                                || x.malop == tuKhoa).ToList();

            grid_QLSV.DataSource = ketQua;
        }

        private void btn_backward_Click(object sender, EventArgs e)
        {
            if (trangHienTai > 1) 
            {
                trangHienTai--;
                LoadDataPhanTrang();
            }
        }

        private void btn_backwardx2_Click(object sender, EventArgs e)
        {
            trangHienTai = 1; 
            LoadDataPhanTrang();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            int tongSoBanGhi = db.tbl_sinhviens.Count();
            int tongSoTrang = (int)Math.Ceiling((double)tongSoBanGhi / soDongTrenTrang);

            if (trangHienTai < tongSoTrang) 
            {
                trangHienTai++;
                LoadDataPhanTrang();
            }
        }

        private void btn_forwardx2_Click(object sender, EventArgs e)
        {
            int tongSoBanGhi = db.tbl_sinhviens.Count();
            int tongSoTrang = (int)Math.Ceiling((double)tongSoBanGhi / soDongTrenTrang);
            if (tongSoTrang == 0) tongSoTrang = 1;

            trangHienTai = tongSoTrang; 
            LoadDataPhanTrang();
        }

        private void txt_Pagination_Click(object sender, EventArgs e)
        {
            
        }

        public void LoadDataPhanTrang()
        {
            int tongSoBanGhi = db.tbl_sinhviens.Count();

            int tongSoTrang = (int)Math.Ceiling((double)tongSoBanGhi / soDongTrenTrang);
            if (tongSoTrang == 0) tongSoTrang = 1;

            var dSSV = db.tbl_sinhviens
                         .Skip((trangHienTai - 1) * soDongTrenTrang)
                         .Take(soDongTrenTrang)
                         .ToList();

            grid_QLSV.DataSource = dSSV;

            txt_Pagination.Text = $"Trang {trangHienTai}/{tongSoTrang} | {tongSoBanGhi} bản ghi";
        }
    }

}
