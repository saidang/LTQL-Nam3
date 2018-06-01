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
    public partial class frm_NhaCungCap : Form
    {
        public frm_NhaCungCap()
        {
            InitializeComponent();
        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiDSNhaCCLenDatagrid();
        }
        private void HienThiDSNhaCCLenDatagrid()
        {
            List<NhaCC_DTO> lstNhaCC = NhaCC_BLL.LayDSNhaCC();
            dataGridViewNCC.DataSource = lstNhaCC;
            dataGridViewNCC.Columns["SMaNCC"].HeaderText = "Mã số";
            dataGridViewNCC.Columns["STenNCC"].HeaderText = "Tên";
            dataGridViewNCC.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dataGridViewNCC.Columns["SDienThoai"].HeaderText = "Điện Thoại";
            dataGridViewNCC.Columns["SGhiChu"].HeaderText = "Ghi Chú";

            dataGridViewNCC.Columns["SMaNCC"].Width = 70;
            dataGridViewNCC.Columns["STenNCC"].Width = 120;
            dataGridViewNCC.Columns["SDiaChi"].Width = 70;
            dataGridViewNCC.Columns["SDienThoai"].Width = 200;
            dataGridViewNCC.Columns["SGhiChu"].Width = 200;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

           // Kiểm tra mã ncc có bị trùng không
            if (NhaCC_BLL.TimNhaCCTheoMa(txtMaNCC.Text) != null)
            {
                MessageBox.Show("Mã nhà cung cấp đã tồn tại!");
                return;
            }
            
            NhaCC_DTO cc = new NhaCC_DTO();
            cc.SMaNCC = txtMaNCC.Text;
            cc.STenNCC = txtTenNCC.Text;
            cc.SDiaChi = txtDiachi.Text;
            cc.SDienThoai = txtDienThoai.Text;
            cc.SGhiChu = txtGhiChu.Text;
            if (NhaCC_BLL.ThemNhaCC(cc) == false)
            {
                MessageBox.Show("Không thêm được nhà cung cấp.");
                return;
            }
            HienThiDSNhaCCLenDatagrid();
            MessageBox.Show("Đã thêm thành công nhà cung cấp.");
        }

        private void dataGridViewNCC_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dataGridViewNCC.SelectedRows[0];
            txtMaNCC.Text = r.Cells["SMaNCC"].Value.ToString();
            txtTenNCC.Text = r.Cells["STenNCC"].Value.ToString();
            txtDiachi.Text = r.Cells["SDiaChi"].Value.ToString();
            txtDienThoai.Text = r.Cells["SDienThoai"].Value.ToString(); 
            txtGhiChu.Text = r.Cells["SGhiChu"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaNCC.Text == "" || NhaCC_BLL.TimNhaCCTheoMa(txtMaNCC.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhà cung cấp!");
                return;
            }
            NhaCC_DTO cc = new NhaCC_DTO();
            cc.SMaNCC = txtMaNCC.Text;
            cc.STenNCC = txtTenNCC.Text;
            cc.SDiaChi = txtDiachi.Text;
            cc.SDienThoai = txtDienThoai.Text;
            cc.SGhiChu = txtGhiChu.Text;

            if (NhaCC_BLL.XoaNhaCC(cc) == true)
            {
                HienThiDSNhaCCLenDatagrid();
                MessageBox.Show("Đã xóa thành công nhà cung cấp được chọn.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaNCC.Text == "" || NhaCC_BLL.TimNhaCCTheoMa(txtMaNCC.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhà cung cấp!");
                return;
            }
            NhaCC_DTO cc = new NhaCC_DTO();
            cc.SMaNCC = txtMaNCC.Text;
            cc.STenNCC = txtTenNCC.Text;
            cc.SDiaChi = txtDiachi.Text;
            cc.SDienThoai = txtDienThoai.Text;
            cc.SGhiChu = txtGhiChu.Text;

            if (NhaCC_BLL.SuaNhaCC(cc) == true)
            {
                HienThiDSNhaCCLenDatagrid();
                MessageBox.Show("Đã cập nhật thông tin nhà cung cấp thành công.");
            }
            else
            {
                MessageBox.Show("Không cập nhật được thông tin nhà cung cấp.");
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string ten = txtTim.Text;
            List<NhaCC_DTO> lstcc = NhaCC_BLL.TimNCCTheoTen(ten);
            if (lstcc == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dataGridViewNCC.DataSource = lstcc;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtDiachi.ResetText();
            txtGhiChu.ResetText();
            txtDienThoai.ResetText();
            txtMaNCC.Focus();
            List<NhaCC_DTO> lstNhaCC = NhaCC_BLL.LayDSNhaCC();
            dataGridViewNCC.DataSource = lstNhaCC;
        }
    }
}
