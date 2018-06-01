using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QLCHGAGMIX
{
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHangLenDatagrid();
        }
        private void HienThiDSKhachHangLenDatagrid()
        {
            List<KhachHang_DTO> lstGiangVien = KhachHang_BLL.LayDSKhachHang();
            dataGridViewKH.DataSource = lstGiangVien;
            dataGridViewKH.Columns["SMaKH"].HeaderText = "Mã số";
            dataGridViewKH.Columns["STenKH"].HeaderText = "Họ tên";
            dataGridViewKH.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dataGridViewKH.Columns["SDienThoai"].HeaderText = "Điện Thoại";

            dataGridViewKH.Columns["SMaKH"].Width = 100;
            dataGridViewKH.Columns["STenKH"].Width = 200;
            dataGridViewKH.Columns["SDiaChi"].Width = 200;
            dataGridViewKH.Columns["SDienThoai"].Width = 200;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

           /* // Kiểm tra mã giảng viên có bị trùng không
            if (GiangVien_BUS.TimGiangVienTheoMa(txtMaGV.Text) != null)
            {
                MessageBox.Show("Mã giảng viên đã tồn tại!");
                return;
            }*/

            KhachHang_DTO kh= new KhachHang_DTO();
            kh.SMaKH = txtMaKH.Text;
             kh.STenKH = txtTenKH.Text;
             kh.SDiaChi = txtDiaChi.Text;
             kh.SDienThoai = txtDienThoai.Text;
            if (KhachHang_BLL.ThemKhachHang(kh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
             HienThiDSKhachHangLenDatagrid();
            MessageBox.Show("Đã thêm Khách Hàng.");
        
        }

        private void dataGridViewKH_Click(object sender, EventArgs e)
        {

            DataGridViewRow r = new DataGridViewRow();
            r = dataGridViewKH.SelectedRows[0];
            txtMaKH.Text = r.Cells["SMaKH"].Value.ToString();
            txtTenKH.Text = r.Cells["STenKH"].Value.ToString();
            txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
            txtDienThoai.Text = r.Cells["SDienThoai"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
               /*  // kiểm tra mã có tồn tại
                if (txtMaGV.Text == "" || GiangVien_BUS.TimGiangVienTheoMa(txtMaGV.Text) == null)
                {
                    MessageBox.Show("Vui lòng chọn mã giảng viên!");
                    return;
                }
                */
                KhachHang_DTO kh = new KhachHang_DTO();
               kh.SMaKH = txtMaKH.Text;
                kh.STenKH = txtTenKH.Text;
               kh.SDiaChi = txtDiaChi.Text;
                kh.SDienThoai = txtDienThoai.Text;

            if (KhachHang_BLL.XoaKhachHang(kh) == true)
            {
                HienThiDSKhachHangLenDatagrid();
                MessageBox.Show("Đã xóa Khách hàng.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            /*  // kiểm tra mã có tồn tại
               if (txtMaGV.Text == "" || GiangVien_BUS.TimGiangVienTheoMa(txtMaGV.Text) == null)
               {
                   MessageBox.Show("Vui lòng chọn mã giảng viên!");
                   return;
               }
               */
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKH = txtMaKH.Text;
            kh.STenKH = txtTenKH.Text;
            kh.SDiaChi = txtDiaChi.Text;
            kh.SDienThoai = txtDienThoai.Text;

            if (KhachHang_BLL.SuaKhachHang(kh) == true)
            {
                HienThiDSKhachHangLenDatagrid();
                MessageBox.Show("Sửa Thành Công.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTim.Text;
            List<KhachHang_DTO> lstnv = KhachHang_BLL.TimKHTheoTen(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dataGridViewKH.DataSource = lstnv;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtDiaChi.ResetText();
            txtDienThoai.ResetText();
            txtMaKH.Focus();
            txtTim.ResetText();
            List<KhachHang_DTO> lstGiangVien = KhachHang_BLL.LayDSKhachHang();
            dataGridViewKH.DataSource = lstGiangVien;
        }

       
    }
}
