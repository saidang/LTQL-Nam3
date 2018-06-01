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
    public partial class frm_Hang : Form
    {
        public frm_Hang()
        {
            InitializeComponent();
        }

        private void frm_Hang_Load(object sender, EventArgs e)
        {
            HienThiNhaCCLenCombobox();
            HienThiDSHangDatagrid();
            
            
           
        }
        private void HienThiNhaCCLenCombobox()
        {
            List<NhaCC_DTO> lstNhaCC = NhaCC_BLL.LayDSNhaCC();
            cboNhaCC.DataSource = lstNhaCC;

            cboNhaCC.DisplayMember = "STenNCC";
            cboNhaCC.ValueMember = "SMaNCC";

        }
        
       
       
        private void HienThiDSHangDatagrid()
        {

            List<Hang_DTO> lstHang = Hang_BLL.LayDSHang();
            dataGridViewH.DataSource = lstHang;



            dataGridViewH.Columns["SMaHang"].HeaderText = "Mã hàng";
            dataGridViewH.Columns["STenHang"].HeaderText = "Tên hàng";
            dataGridViewH.Columns["SMaNCC"].HeaderText = "nhà cung cấp";
            dataGridViewH.Columns["SSoLuong"].HeaderText = "Số Lượng";
            dataGridViewH.Columns["SDonGiaNhap"].HeaderText = "Đơn Giá Nhập";
            dataGridViewH.Columns["SDonGiaBan"].HeaderText = "Đơn Giá Bán";
            dataGridViewH.Columns["STenNCC"].HeaderText = "Tên nhà cung cấp";





            dataGridViewH.Columns["SMaHang"].Width = 70;
            dataGridViewH.Columns["STenHang"].Width = 200;
            dataGridViewH.Columns["SMaNCC"].Width = 100;
            dataGridViewH.Columns["SSoLuong"].Width = 100;
            dataGridViewH.Columns["SDonGiaNhap"].Width = 100;
            dataGridViewH.Columns["SDonGiaBan"].Width = 100;
            dataGridViewH.Columns["STenNCC"].Width = 200;


            // mới bổ sung thêm
            // Hiển thị tên chức vụ tương ứng


        }

       

        private void dataGridViewH_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dataGridViewH.SelectedRows[0];
            txtMaHang.Text = r.Cells["SMaHang"].Value.ToString();
            txtTenHang.Text = r.Cells["STenHang"].Value.ToString();
            cboNhaCC.Text = r.Cells["STenNCC"].Value.ToString();
            numSL.Text = r.Cells["SSoLuong"].Value.ToString();
            txtGiaNhap.Text = r.Cells["SDonGiaNhap"].Value.ToString();
            txtGiaBan.Text = r.Cells["SDonGiaBan"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
              // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaHang.Text == "" || txtTenHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã giảng viên có bị trùng không
            if (Hang_BLL.TimHangTheoMa(txtMaHang.Text) != null)
            {
                MessageBox.Show("Mã hàng  đã tồn tại!");
                return;
            }

            Hang_DTO h= new Hang_DTO();
            h.SMaHang = txtMaHang.Text;
            h.STenHang = txtTenHang.Text;
            h.SMaNCC = cboNhaCC.SelectedValue.ToString();
            h.SSoLuong=int.Parse(numSL.Text.ToString());
            h.SDonGiaNhap=float.Parse(txtGiaNhap.Text.ToString());
            h.SDonGiaBan=float.Parse(txtGiaBan.Text.ToString());

            if (Hang_BLL.ThemHang(h) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
         
            HienThiDSHangDatagrid();

            MessageBox.Show("Đã thêm hàng thành công.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
              // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaHang.Text == "" || txtTenHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            

            Hang_DTO h = new Hang_DTO();
            h.SMaHang = txtMaHang.Text;
            h.STenHang = txtTenHang.Text;
            h.SMaNCC = cboNhaCC.SelectedValue.ToString();
            h.SSoLuong = int.Parse(numSL.Text.ToString());
            h.SDonGiaNhap = float.Parse(txtGiaNhap.Text.ToString());
            h.SDonGiaBan = float.Parse(txtGiaBan.Text.ToString());

            if (Hang_BLL.XoaHang(h) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiDSHangDatagrid();

            MessageBox.Show("Đã xóa hàng thành công.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaHang.Text == "" || Hang_BLL.TimHangTheoMa(txtMaHang.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã hàng!");
                return;
            }
            Hang_DTO h = new Hang_DTO();
            h.SMaHang = txtMaHang.Text;
            h.STenHang = txtTenHang.Text;
            h.SMaNCC = cboNhaCC.SelectedValue.ToString();
            h.SSoLuong = int.Parse(numSL.Text.ToString());
            h.SDonGiaNhap = float.Parse(txtGiaNhap.Text.ToString());
            h.SDonGiaBan = float.Parse(txtGiaBan.Text.ToString());

            if (Hang_BLL.SuaHang(h) == true)
            {
                HienThiDSHangDatagrid();
                MessageBox.Show("Đã cập nhật thông tin hàng thành công.");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
          

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            List<Hang_DTO> lstl = Hang_BLL.TimHangTheoTen(ten);
            if (lstl == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dataGridViewH.DataSource = lstl;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMaHang.ResetText();
            txtTenHang.ResetText();
            numSL.ResetText();
            txtGiaNhap.ResetText();
            txtGiaBan.ResetText();
            txtMaHang.Focus();
            List<Hang_DTO> lstHang = Hang_BLL.LayDSHang();
            dataGridViewH.DataSource = lstHang;
           
        }
      /* private void ht(){
            string tenchucvu;
            DataGridViewColumn clTenNCC = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            clTenNCC.CellTemplate = cell;
            clTenNCC.Name = "tenncc";
            clTenNCC.HeaderText = "Tên Nhà CC";
            clTenNCC.Width = 150;
            dataGridViewH.Columns.Add(clTenNCC);
            for (int i = 0; i < dataGridViewH.RowCount; i++)
            {
                tenchucvu = NhaCC_BLL.LayTenNCCTheoMa (dataGridViewH.Rows[i].Cells["SMaNCC"].Value.ToString());
                dataGridViewH.Rows[i].Cells["tenncc"].Value = tenchucvu;
            }*/
        }
}
