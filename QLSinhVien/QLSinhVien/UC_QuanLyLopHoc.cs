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
        int trangHienTai = 1;
        int soDongTrenTrang = 5;
        public UC_QuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void UC_QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadDataPhanTrang();
        }
        public void LoadDataPhanTrang()
        {
            int tongSoBanGhi = db.tbl_lophocs.Count();

            int tongSoTrang = (int)Math.Ceiling((double)tongSoBanGhi / soDongTrenTrang);
            if (tongSoTrang == 0) tongSoTrang = 1;

            var dSLH = db.tbl_lophocs
                         .Skip((trangHienTai - 1) * soDongTrenTrang)
                         .Take(soDongTrenTrang)
                         .ToList();

            gridviewQLLH.DataSource = dSLH;

            txt_Pagination.Text = $"Trang {trangHienTai}/{tongSoTrang} | {soDongTrenTrang} bản ghi";
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
                LoadDataPhanTrang();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text;

            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadDataPhanTrang();
                return;
            }

            List<tbl_lophoc> ketQua = db.tbl_lophocs.Where(x => x.id.Contains(tuKhoa)
                                                                || x.malop == tuKhoa
                                                                || x.tenlop == tuKhoa).OrderBy(x => x.id).ToList();

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tim thấy lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridviewQLLH.DataSource = null;
            }
            else gridviewQLLH.DataSource = ketQua;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaID.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tbl_lophoc lophoc = db.tbl_lophocs.SingleOrDefault(x => x.id == txtMaID.Text);

            lophoc.malop = txtMaLop.Text;
            lophoc.tenlop = txtTenLop.Text;
            lophoc.ghichu = txtGhiChu.Text;
            try
            {
                db.SubmitChanges();

                MessageBox.Show("Sửa thành công");
                LoadDataPhanTrang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaID.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = txtMaLop.Text;

            bool coSinhVien = db.tbl_sinhviens.Any(sv => sv.malop == maLop);
            if (coSinhVien)
            {
                MessageBox.Show("Không thể xóa lớp này vì đang có sinh viên thuộc lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            tbl_lophoc lophoc = db.tbl_lophocs.SingleOrDefault(x => x.id == txtMaID.Text);

            DialogResult r = MessageBox.Show($"Bạn chắc chắn muốn XÓA lớp {lophoc.malop} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) return;

            try
            {
                db.tbl_lophocs.DeleteOnSubmit(lophoc);

                db.SubmitChanges();
                MessageBox.Show("Xóa thành công");
                LoadDataPhanTrang();

                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Clear();
            txtMaID.Clear();
            txtMaID.ReadOnly = false;
            txtTenLop.Clear();
            txtGhiChu.Clear();
            LoadDataPhanTrang();
        }

        private void gridviewQLLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = gridviewQLLH.Rows[e.RowIndex];

            txtMaID.Text = row.Cells["id"].Value.ToString();
            txtMaID.ReadOnly = true;
            txtMaLop.Text = row.Cells["malop"].Value.ToString();
            txtTenLop.Text = row.Cells["tenlop"].Value.ToString();
            txtGhiChu.Text = row.Cells["ghichu"].Value.ToString();
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
            int tongSoBanGhi = db.tbl_lophocs.Count();
            int tongSoTrang = (int)Math.Ceiling((double)tongSoBanGhi / soDongTrenTrang);

            if (trangHienTai < tongSoTrang)
            {
                trangHienTai++;
                LoadDataPhanTrang();
            }
        }

        private void btn_forwardx2_Click(object sender, EventArgs e)
        {
            int tongSoBanGhi = db.tbl_lophocs.Count();
            int tongSoTrang = (int)Math.Ceiling((double)tongSoBanGhi / soDongTrenTrang);
            if (tongSoTrang == 0) tongSoTrang = 1;

            trangHienTai = tongSoTrang;
            LoadDataPhanTrang();
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Chọn 1 lớp từ danh sách");
                return;
            }

            string maLopDuocChon = txtMaLop.Text;

            DSSinhVien1Lop formMoi = new DSSinhVien1Lop(maLopDuocChon);

            formMoi.ShowDialog();
        }
    }
}
