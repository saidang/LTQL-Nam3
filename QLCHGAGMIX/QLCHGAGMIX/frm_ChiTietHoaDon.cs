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

namespace QLCHGAGMIX
{
    public partial class frm_ChiTietHoaDon : Form
    {
        public frm_ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void frm_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
               HienThiDSCTHDDatagrid();
               HienThiHDLenCombobox();
               HienThiHangLenCombobox();
        
        }


        private void HienThiHDLenCombobox()
        {
            List<HoaDonBan_DTO> lstNhaCC = HoaDonBan_BLL.LayDSHoaDonBan();
            cboMaHD.DataSource = lstNhaCC;

            cboMaHD.DisplayMember = "SMaHD";
            cboMaHD.ValueMember = "SMaHD";

        }
        private void HienThiHangLenCombobox()
        {
            List<Hang_DTO> lstNhaCC = Hang_BLL.LayDSHang();
            cboMaHang.DataSource = lstNhaCC;

            cboMaHang.DisplayMember = "STenHang";
            cboMaHang.ValueMember = "SMaHang";

        }

        private void HienThiDSCTHDDatagrid()
        {

            List<CTHD_DTO> lstCTHD = CTHD_BLL.LayDSCTHD();
            dataGridViewCTHD.DataSource = lstCTHD;



            dataGridViewCTHD.Columns["SMaHD"].HeaderText = "Mã Hóa Đơn";
            dataGridViewCTHD.Columns["SMaHang"].HeaderText = "Mã Hàng";
            dataGridViewCTHD.Columns["SSoLuong"].HeaderText = "Số Lương";
            dataGridViewCTHD.Columns["SDonGia"].HeaderText = "Đơn Giá Bán";
            dataGridViewCTHD.Columns["SGiamGia"].HeaderText = "Giảm giá";



            dataGridViewCTHD.Columns["SMaHD"].Width = 70;
            dataGridViewCTHD.Columns["SMaHang"].Width = 100;
            dataGridViewCTHD.Columns["SSoLuong"].Width = 100;
            dataGridViewCTHD.Columns["SDonGia"].Width = 150;
            dataGridViewCTHD.Columns["SGiamGia"].Width = 150;
         }

        private void dataGridViewCTHD_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dataGridViewCTHD.SelectedRows[0];

            cboMaHD.Text = r.Cells["SMaHD"].Value.ToString();
            cboMaHang.Text = r.Cells["SMaHang"].Value.ToString();
            numSoLuong.Text = r.Cells["SSoLuong"].Value.ToString();
            txtDonGia.Text = r.Cells["SDonGia"].Value.ToString();
            txtGiamGia.Text = r.Cells["SGiamGia"].Value.ToString();
        }

        private void bthThem_Click(object sender, EventArgs e)
        {
              // Kiểm tra dữ liệu có bị bỏ trống 
            if (numSoLuong.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }


            CTHD_DTO cthd= new CTHD_DTO();
            cthd.SMaHD = cboMaHD.SelectedValue.ToString();
            cthd.SMaHang = cboMaHang.SelectedValue.ToString();
            cthd.SSoLuong = int.Parse(numSoLuong.Text.ToString());
            cthd.SDonGia=float.Parse(txtDonGia.Text.ToString());
            cthd.SGiamGia=txtGiamGia.Text;
            

            if (CTHD_BLL.ThemCTHD(cthd) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
         
            HienThiDSCTHDDatagrid();

            MessageBox.Show("Đã thêm chi tiết hóa đơn thành công.");
        
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (cboMaHD.Text == "" )
            {
                MessageBox.Show("Vui lòng chọn mã chi tiết hóa đơn!");
                return;
            }
            CTHD_DTO cthd = new CTHD_DTO();
            cthd.SMaHD = cboMaHD.SelectedValue.ToString();
            cthd.SMaHang = cboMaHang.SelectedValue.ToString();
            cthd.SSoLuong = int.Parse(numSoLuong.Text.ToString());
            cthd.SDonGia = float.Parse(txtDonGia.Text.ToString());
            cthd.SGiamGia = txtGiamGia.Text;

            if (CTHD_BLL.SuaCTHD(cthd) == true)
            {
                HienThiDSCTHDDatagrid();
                MessageBox.Show("Đã cập nhật thông tin chi tiết hóa đơn.");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
              if (cboMaHD.Text == "" )
            {
                MessageBox.Show("Vui lòng chọn mã chi tiết cần xóa!");
                return;
            }

           
             CTHD_DTO cthd = new CTHD_DTO();
            cthd.SMaHD = cboMaHD.SelectedValue.ToString();
            cthd.SMaHang = cboMaHang.SelectedValue.ToString();
            cthd.SSoLuong = int.Parse(numSoLuong.Text.ToString());
            cthd.SDonGia = float.Parse(txtDonGia.Text.ToString());
            cthd.SGiamGia = txtGiamGia.Text;

            if (CTHD_BLL.XoaCTHD(cthd) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }

            HienThiDSCTHDDatagrid();
           
            MessageBox.Show("Đã xoa thành công.");
          
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            List<CTHD_DTO> lstCTHD = CTHD_BLL.LayDSCTHD();
            dataGridViewCTHD.DataSource = lstCTHD;
        }

       
        

    }
}
