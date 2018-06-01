using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Data.SqlClient;


namespace QLCHGAGMIX
{
    public partial class frm_HoaDonNhapHang : Form
    {
        public frm_HoaDonNhapHang()
        {
            InitializeComponent();
        }

        private void frm_HoaDonNhapHang_Load(object sender, EventArgs e)
        {
             HienThiDSHDNLenDatagrid();
             HienThiNhaCCLenCombobox();
             HienThiNhanVienLenCombobox();
            
          
        }
        private void HienThiNhanVienLenCombobox()
        {
            List<NhanVien_DTO> lstChucVu = NhanVien_BLL.LayDSNhanVien();
            cboMANV.DataSource = lstChucVu;
            cboMANV.DisplayMember = "STenNV";
            cboMANV.ValueMember = "SMaNV";
        }
       
          private void HienThiNhaCCLenCombobox()
        {
            List<NhaCC_DTO> lstNhaCC = NhaCC_BLL.LayDSNhaCC();
            cboNCC.DataSource = lstNhaCC;
            cboNCC.DisplayMember = "STenNCC";
            cboNCC.ValueMember = "SMaNCC";
        }
        
         private void HienThiDSHDNLenDatagrid()
        {
            List<HoaDonNhapHang_DTO> lstHoaDonNhapHang =  HoaDonNhapHang_BLL.LayDSHoaDonNhapHang();
           dataGridViewHDNH.DataSource = lstHoaDonNhapHang;

           dataGridViewHDNH.Columns["SSHHD"].HeaderText = "Số hiệu";
           dataGridViewHDNH.Columns["SMaNCC"].HeaderText = "Mã nhà cc";
           dataGridViewHDNH.Columns["SMaNV"].HeaderText = "Mã nhân viên";
           dataGridViewHDNH.Columns["SSoTien"].HeaderText = "Số Tiền";
           dataGridViewHDNH.Columns["SDaTra"].HeaderText = "Đã Trã";
           dataGridViewHDNH.Columns["SConNo"].HeaderText = "Còn Nợ";
           dataGridViewHDNH.Columns["STenNCC"].HeaderText = "Tên NCC";
           dataGridViewHDNH.Columns["STenNV"].HeaderText = "Tên Nhân Viên";

           dataGridViewHDNH.Columns["SSHHD"].Width = 80;
           dataGridViewHDNH.Columns["SMaNCC"].Width = 80;
           dataGridViewHDNH.Columns["SMaNV"].Width = 80;
           dataGridViewHDNH.Columns["SSoTien"].Width = 80;
           dataGridViewHDNH.Columns["SDaTra"].Width = 60;
           dataGridViewHDNH.Columns["SConNo"].Width = 60;
           dataGridViewHDNH.Columns["STenNCC"].Width = 60;
           dataGridViewHDNH.Columns["STenNV"].Width = 60;
           }

         private void dataGridViewHDNH_Click(object sender, EventArgs e)
         {

             DataGridViewRow r = new DataGridViewRow();
             r = dataGridViewHDNH.SelectedRows[0];
             txtSHHD.Text = r.Cells["SSHHD"].Value.ToString();
             cboNCC.SelectedValue = r.Cells["SMaNCC"].Value.ToString();
             cboMANV.SelectedValue = r.Cells["SMaNV"].Value.ToString();
             txtSoTien.Text = r.Cells["SSoTien"].Value.ToString();
             txtDaTra.Text = r.Cells["SDaTra"].Value.ToString();
             txtConNo.Text = r.Cells["SConNo"].Value.ToString();
         }
         //Thêm một nhân viên
         private void btnThem_Click(object sender, EventArgs e)
         {
             // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtSHHD.Text == "" || txtSoTien.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã hóa đon c có bị trùng không
            if (HoaDonNhapHang_BLL.TimHDNHTheoMa(txtSHHD.Text) != null)
            {
                MessageBox.Show("Mã hóa đơn nhập đã tồn tại!");
                return;
            }

            HoaDonNhapHang_DTO hd = new HoaDonNhapHang_DTO();
            hd.SSHHD = txtSHHD.Text;
            hd.SMaNCC = cboNCC.SelectedValue.ToString();
            hd.SMaNV = cboMANV.SelectedValue.ToString();
            hd.SSoTien=int.Parse(txtSoTien.Text.ToString());
            hd.SDaTra=txtDaTra.Text;
            hd.SConNo=txtConNo.Text;
            if (HoaDonNhapHang_BLL.ThemHDN(hd) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSHDNLenDatagrid();
            MessageBox.Show("Đã thêm được một hóa đơn mới thành công.");
        
         }

         //Sửa môt nhân viên
         private void btnSua_Click(object sender, EventArgs e)
         {

             // kiểm tra mã có tồn tại
             if (txtSHHD.Text == ""|| HoaDonNhapHang_BLL.TimHDNHTheoMa(txtSHHD.Text) == null) 
             {
                 MessageBox.Show("Vui lòng chọn mã hóa đơn!");
                 return;
             }
             HoaDonNhapHang_DTO hd = new HoaDonNhapHang_DTO();
             hd.SSHHD = txtSHHD.Text;
             hd.SMaNCC = cboNCC.SelectedValue.ToString();
             hd.SMaNV = cboMANV.SelectedValue.ToString();
             hd.SSoTien = int.Parse(txtSoTien.Text.ToString());
             hd.SDaTra = txtDaTra.Text;
             hd.SConNo = txtConNo.Text;


             if (HoaDonNhapHang_BLL.SuaHDN(hd) == true)
             {
                 HienThiDSHDNLenDatagrid();
                 MessageBox.Show("Đã cập nhật thành công thông tin hóa đơn.");
             }
             else
             {
                 MessageBox.Show("Không cập nhật được thông tin hóa đơn.");
             }
         }
         //Xóa một nhân viên
         private void btnXoa_Click(object sender, EventArgs e)
         {
             // kiểm tra mã có tồn tại
             if (txtSHHD.Text == "" || HoaDonNhapHang_BLL.TimHDNHTheoMa(txtSHHD.Text) == null)
             {
                 MessageBox.Show("Vui lòng chọn mã hóa sô hiệu hóa đơn!");
                 return;
             }
             HoaDonNhapHang_DTO hd = new HoaDonNhapHang_DTO();
             hd.SSHHD = txtSHHD.Text;
             hd.SMaNCC = cboNCC.SelectedValue.ToString();
             hd.SMaNV = cboMANV.SelectedValue.ToString();
             hd.SSoTien = int.Parse(txtSoTien.Text.ToString());
             hd.SDaTra = txtDaTra.Text;
             hd.SConNo = txtConNo.Text;


             if (HoaDonNhapHang_BLL.XoaHDN(hd) == true)
             {
                 HienThiDSHDNLenDatagrid();
                 MessageBox.Show("Đã xóa thành công.");
             }
             else
             {
                 MessageBox.Show("Không xóa được.");
             }
         }
         //Tìm hóa đơn nhập hàng theo mã nhân viên
         private void btnTim_Click(object sender, EventArgs e)
         {
             string ten = txtTim.Text;
             List<HoaDonNhapHang_DTO> lstl = HoaDonNhapHang_BLL.TimHDNHTheoTen(ten);
             if (lstl == null)
             {
                 MessageBox.Show("Không tìm thấy!");
                 return;
             }
             dataGridViewHDNH.DataSource = lstl;
         }

         private void label3_Click(object sender, EventArgs e)
         {

         }

         private void label9_Click(object sender, EventArgs e)
         {

         }

         private void cb_Enter(object sender, EventArgs e)
         {

         }

         private void btnTroLai_Click(object sender, EventArgs e)
         {
             txtSHHD.Focus();
             List<HoaDonNhapHang_DTO> lstHoaDonNhapHang = HoaDonNhapHang_BLL.LayDSHoaDonNhapHang();
             dataGridViewHDNH.DataSource = lstHoaDonNhapHang;
         }

        /* private void btnTim_Click(object sender, EventArgs e)
         {
             string ten = txtTim.Text;
             List<HoaDonNhapHang_DTO> lstHang = HoaDonNhapHang_BLL.TimHDNHTheoMa(ten);
            if (lstHang == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
             dataGridViewHDNH.DataSource = lstHang;*/
        }
         
    }

