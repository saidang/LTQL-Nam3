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
    public partial class frm_HoaDonBan : Form
    {
        public frm_HoaDonBan()
        {
            InitializeComponent();
        }

        private void frm_HoaDonBan_Load(object sender, EventArgs e)
        {
            HienThiDSHoaDonBanDatagrid();
            HienThiKHLenCombobox();
            HienThiNVLenCombobox();
          
        
        }

        private void HienThiKHLenCombobox()
        {
            List<KhachHang_DTO> lstNhaCC = KhachHang_BLL.LayDSKhachHang();
            cboMaKH.DataSource = lstNhaCC;

            cboMaKH.DisplayMember = "STenKH";
            cboMaKH.ValueMember = "SMaKH";

        }

        private void HienThiNVLenCombobox()
        {
            List<NhanVien_DTO> lstNhaCC = NhanVien_BLL.LayDSNhanVien();
            cboMaNV.DataSource = lstNhaCC;

            cboMaNV.DisplayMember = "STenNV";
            cboMaNV.ValueMember = "SMaNV";

        }
       
        private void HienThiDSHoaDonBanDatagrid()
        {

            List<HoaDonBan_DTO> lstNhanVien = HoaDonBan_BLL.LayDSHoaDonBan();
            dataGridViewHDB.DataSource = lstNhanVien;

            dataGridViewHDB.Columns["SMaHD"].HeaderText = "Mã HD";
            dataGridViewHDB.Columns["SMaNV"].HeaderText = "Mã Nhân Viên";
            dataGridViewHDB.Columns["SNgayBan"].HeaderText = "Ngày Bán";
            dataGridViewHDB.Columns["SMaKH"].HeaderText = "Mã Khách Hàng";
            dataGridViewHDB.Columns["SSoLuong"].HeaderText = "Số Lượng";
            dataGridViewHDB.Columns["STongTien"].HeaderText = "Tổng Tiền";



            dataGridViewHDB.Columns["SMaHD"].Width = 70;
            dataGridViewHDB.Columns["SMaNV"].Width = 100;
            dataGridViewHDB.Columns["SNgayBan"].Width = 100;
            dataGridViewHDB.Columns["SMaKH"].Width = 50;
            dataGridViewHDB.Columns["SSoLuong"].Width = 100;
            dataGridViewHDB.Columns["STongTien"].Width = 100;
           


        }

      

        private void dataGridViewHDB_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dataGridViewHDB.SelectedRows[0];

            txtMaHD.Text = r.Cells["SMaHD"].Value.ToString();
            cboMaNV.Text = r.Cells["STenNV"].Value.ToString();
            dtpNgayBan.Text = r.Cells["SNgayBan"].Value.ToString();
            cboMaKH.Text = r.Cells["STenKH"].Value.ToString();
            nbrSoLuong.Text = r.Cells["SSoLuong"].Value.ToString();
            txtTongTien.Text = r.Cells["STongTien"].Value.ToString();
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaHD.Text == "" || txtTongTien.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã hdb có bị trùng không
            if (HoaDonBan_BLL.TimHDBTheoMa(txtMaHD.Text) != null)
            {
                MessageBox.Show("Mã hóa đơn bán đã tồn tại!");
                return;
            }

            HoaDonBan_DTO hdb = new HoaDonBan_DTO();
            hdb.SMaHD = txtMaHD.Text;
            hdb.SMaNV = cboMaNV.SelectedValue.ToString();
            hdb.SNgayBan = DateTime.Parse(dtpNgayBan.Text);
            hdb.SMaKH = cboMaKH.SelectedValue.ToString();
            hdb.SSoLuong=int.Parse( nbrSoLuong.Text.ToString());
            hdb.STongTien=float.Parse(txtTongTien.Text.ToString());
               
            if (HoaDonBan_BLL.ThemHDB(hdb) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSHoaDonBanDatagrid();
            MessageBox.Show("Đã thêm hóa đơn bán thành công.");
        
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaHD.Text == "" || HoaDonBan_BLL.TimHDBTheoMa(txtMaHD.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã hóa đơn!");
                return;
            }
            HoaDonBan_DTO hdb = new HoaDonBan_DTO();
            hdb.SMaHD = txtMaHD.Text;
            hdb.SMaNV = cboMaNV.SelectedValue.ToString();
            hdb.SNgayBan = DateTime.Parse(dtpNgayBan.Text);
            hdb.SMaKH = cboMaKH.SelectedValue.ToString();
            hdb.SSoLuong = int.Parse(nbrSoLuong.Text.ToString());
            hdb.STongTien = float.Parse(txtTongTien.Text.ToString());
               

            if (HoaDonBan_BLL.SuaHDB(hdb) == true)
            {
                HienThiDSHoaDonBanDatagrid();
                MessageBox.Show("Đã cập nhật thông tin hóa đơn.");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
               // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaHD.Text == "" || HoaDonBan_BLL.TimHDBTheoMa(txtMaHD.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã hóa đơn!");
                return;
            }

           
             HoaDonBan_DTO hdb = new HoaDonBan_DTO();
            hdb.SMaHD = txtMaHD.Text;
            hdb.SMaNV = cboMaNV.SelectedValue.ToString();
            hdb.SNgayBan = DateTime.Parse(dtpNgayBan.Text);
            hdb.SMaKH = cboMaKH.SelectedValue.ToString();
            hdb.SSoLuong = int.Parse(nbrSoLuong.Text.ToString());
            hdb.STongTien = float.Parse(txtTongTien.Text.ToString());

            if (HoaDonBan_BLL.XoaHDB(hdb) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }

            HienThiDSHoaDonBanDatagrid();
           
            MessageBox.Show("Đã xoa hóa đơn thành công.");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            List<HoaDonBan_DTO> lstl = HoaDonBan_BLL.TimHDBTheoTen(ten);
            if (lstl == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
             dataGridViewHDB.DataSource = lstl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtMaHD.Focus();
            List<HoaDonBan_DTO> lstNhanVien = HoaDonBan_BLL.LayDSHoaDonBan();
            dataGridViewHDB.DataSource = lstNhanVien;
        }
        

       
    }
}
