using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BLL;

namespace QLCHGAGMIX
{
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            HienThiDSNhanVienDatagrid();
           
        }
        private void HienThiDSNhanVienDatagrid(){

            List<NhanVien_DTO> lstNhanVien = NhanVien_BLL.LayDSNhanVien();
            dataGridViewNV.DataSource = lstNhanVien;

            //dataGridViewNV.Columns["SMaNV"].HeaderText = "Mã số";
            //dataGridViewNV.Columns["STenNV"].HeaderText = "Họ tên";
            //dataGridViewNV.Columns["SChucVU"].HeaderText = "Chức Vụ";
            //dataGridViewNV.Columns["SGioiTinh1"].HeaderText = "Giới Tính";
            //dataGridViewNV.Columns["SDiaChi"].HeaderText = "Địa Chỉ";
            //dataGridViewNV.Columns["SDienThoai"].HeaderText = "Điện Thoại";
            //dataGridViewNV.Columns["SNgaySinh"].HeaderText = "Ngày Sinh";
            

            
            //dataGridViewNV.Columns["SMaNV"].Width = 70;
            //dataGridViewNV.Columns["STenNV"].Width = 100;
            //dataGridViewNV.Columns["SChucVU"].Width = 100;
            //dataGridViewNV.Columns["SGioiTinh1"].Width = 50;
            //dataGridViewNV.Columns["SDiaChi"].Width = 100;
            //dataGridViewNV.Columns["SDienThoai"].Width = 100;
            //dataGridViewNV.Columns["SNgaySinh"].Width = 100;

           
        }

        private void dataGridViewNV_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dataGridViewNV.SelectedRows[0];

            txtMaNV.Text = r.Cells["SMaNV"].Value.ToString();
            txtTenNV.Text = r.Cells["STenNV"].Value.ToString();
            txtChucVu.Text = r.Cells["SChucVU"].Value.ToString();
            if (r.Cells["SGioiTinh1"].Value.ToString() == "Nam")
            {
                Nam.Checked = true;
            }
            else
            {
                Nu.Checked = true;
            }
            txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
            txtDienThoai.Text = r.Cells["SDienThoai"].Value.ToString();
            dtpNgaySinh.Text = r.Cells["SNgaySinh"].Value.ToString();
          
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == "" || txtChucVu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            //Kiểm tra mã nhân  viên có bị trùng không
           if (NhanVien_BLL.TimNhanVienTheoMa(txtMaNV.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.STenNV = txtTenNV.Text;
            nv.SChucVU = txtChucVu.Text;
            if (Nam.Checked == true)
            {
                nv.SGioiTinh1 = "Nam";
            }
            else
            {
                nv.SGioiTinh1 = "Nữ";
            }
            nv.SDienThoai = txtDienThoai.Text;
            nv.SDiaChi = txtDiaChi.Text;
            nv.SNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            if (NhanVien_BLL.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSNhanVienDatagrid();
            MessageBox.Show("Đã thêm nhân  viên.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaNV.Text == "" || NhanVien_BLL.TimNhanVienTheoMa(txtMaNV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.STenNV = txtTenNV.Text;
            nv.SChucVU = txtChucVu.Text;
            if (Nam.Checked == true)
            {
                nv.SGioiTinh1 = "Nam";
            }
            else
            {
                nv.SGioiTinh1 = "Nữ";
            }
            nv.SDienThoai = txtDienThoai.Text;
            nv.SDiaChi = txtDiaChi.Text;
            nv.SNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            if (NhanVien_BLL.XoaNhanVien(nv) == true)
            {
                HienThiDSNhanVienDatagrid();
                MessageBox.Show("Đã xóa nhân viên thành công.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtTim.Text;
            List<NhanVien_DTO> lstnv = NhanVien_BLL.TimNVTheoTen(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dataGridViewNV.DataSource = lstnv;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaNV.Text == "" || NhanVien_BLL.TimNhanVienTheoMa(txtMaNV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.STenNV = txtTenNV.Text;
            nv.SChucVU = txtChucVu.Text;
            if (Nam.Checked == true)
            {
                nv.SGioiTinh1 = "Nam";
            }
            else
            {
                nv.SGioiTinh1 = "Nữ";
            }
            nv.SDienThoai = txtDienThoai.Text;
            nv.SDiaChi = txtDiaChi.Text;
            nv.SNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            if (NhanVien_BLL.SuaNhanVien(nv) == true)
            {
                HienThiDSNhanVienDatagrid();
                MessageBox.Show("Đã cập nhập nhan vien viên.");
            }
            else
            {
                MessageBox.Show("Không cập nhập được.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtChucVu.ResetText();
            txtDiaChi.ResetText();
            txtDienThoai.ResetText();
            txtTim.ResetText();
            dtpNgaySinh.ResetText();
            Nam.ResetText();
            Nu.ResetText();
            txtMaNV.Focus();

            List<NhanVien_DTO> lstNhanVien = NhanVien_BLL.LayDSNhanVien();
            dataGridViewNV.DataSource = lstNhanVien;
            
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
