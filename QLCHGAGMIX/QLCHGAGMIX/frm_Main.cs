using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BLL;
using DTO;

namespace QLCHGAGMIX
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        public bool bDangNhap;
        public NguoiDung_DTO NguoiDung;
        DangNhap fDN;

        frm_HoaDonNhapHang fhdnh = null;
        frm_HoaDonBan fhdb = null;
        frm_ChiTietHoaDon fcthd = null;
        frm_Hang fH = null;
        frm_NhanVien fNV=null;
        frm_NhaCungCap fCC=null;
        frm_KhachHang fKH = null;
        frm_bcNhanVien fBCNV = null;
        frm_bcCTHD fbccthd = null;
        frm_bc_NhapKho fnk = null;
        TT tt = null;
        HD hd = null;
      


        private void frm_Main_Load(object sender, EventArgs e)
        {

           
            HienThiMenu();
           
           
        }
        private void HienThiMenu()
        {
            i_htDangNhap.Enabled = !bDangNhap;
            i_dangxuat.Enabled = bDangNhap;
            //i_nghiepvu.Enabled = bDangNhap; 

            if (bDangNhap == true)
            {
                // Hiển thị trạng thái đăng nhập
                sttTTNguoiDung.Text = "Người dùng: " + NguoiDung.STen;
                sttTTThoiGian.Text = "Thời điểm đăng nhập: " + DateTime.Now;
                // Hiển thị menu theo quyền, ví dụ: 
                //  1. quantri: sử dụng tất cả menu
                //  2. nhanvien: không sử dụng các menu: Danh mục, Nghiệp vụ       
                int iQuyen;
                if (NguoiDung == null)
                {
                    iQuyen = 0;
                }
                else
                {
                    iQuyen = int.Parse(NguoiDung.IQuyen.ToString());
                }
                switch (iQuyen)
                {
                    case 1:
                        i_NhanVien.Enabled = true;
                        btnNhanVien.Enabled = true;

                        i_nhaCungcap.Enabled = true;
                        btnNhaCungCap.Enabled = true;

                        i_khcachhang.Enabled = true;
                        btnKhachHang.Enabled = true;

                        i_hang.Enabled = true;
                        btnHang.Enabled = true;

                        i_hoadonnhap.Enabled = true;
                        btnhdb.Enabled = true;

                        i_hoadonban.Enabled = true;
                        btnChitiethoadon.Enabled = true;

                        i_chitiethoadon.Enabled = true;
                        btnhoadonnhap.Enabled = true;

                        i_bcnhanvien.Enabled = true;
                        btnbcnhanvien.Enabled = true;

                        i_bcchitiehoadon.Enabled = true;
                        btnbccthd.Enabled = true;

                        btndangxuat.Enabled = true;
                         btnTroGiup.Enabled = true;
                         btnThongTinPhanMem.Enabled = true;


                        danhMụcToolStripMenuItem.Enabled = true;
                        i_nghiepvu.Enabled = true;


                        báoCáoToolStripMenuItem.Enabled = true;

                         i_bcnhanvien.Enabled = true;
                        btnbcnhanvien.Enabled = true;

                        i_bcchitiehoadon.Enabled = true;
                        btnbccthd.Enabled = true;
                        toolStripButton1.Enabled = true;
                            phiếuNhậpKhoToolStripMenuItem.Enabled=true;

                        break;
                    case 2:
                        i_NhanVien.Enabled = false;
                        btnNhanVien.Enabled = false;

                        i_nhaCungcap.Enabled = true;
                        btnNhaCungCap.Enabled = true;

                        i_khcachhang.Enabled = true;
                        btnKhachHang.Enabled = true;

                        i_hang.Enabled = true;
                        btnHang.Enabled = true;

                        i_hoadonnhap.Enabled = true;
                        btnhdb.Enabled = true;

                        i_hoadonban.Enabled = true;
                        btnChitiethoadon.Enabled = true;

                        i_chitiethoadon.Enabled = true;
                        btnhoadonnhap.Enabled = true;


                        i_bcnhanvien.Enabled = false;
                        btnbcnhanvien.Enabled = false;

                        i_dangxuat.Enabled = true;
                        btndangxuat.Enabled = true;

                        i_bcchitiehoadon.Enabled = false;
                        btnbccthd.Enabled = false;


                        danhMụcToolStripMenuItem.Enabled = true;
                        i_nghiepvu.Enabled = true;
                        báoCáoToolStripMenuItem.Enabled = true;












                        toolStripButton1.Enabled = true;
                        phiếuNhậpKhoToolStripMenuItem.Enabled = true;

                       // i_bcnhanvien.Enabled = true;
                        //btnbcnhanvien.Enabled = true;

                        i_bcchitiehoadon.Enabled = true;
                        btnbccthd.Enabled = true;

                        i_dangxuat.Enabled = true;
                        btndangxuat.Enabled = true;
                        
                        break;
                    default:

                        break;
                }
            }
            else
            {
                sttTTNguoiDung.Text = "Chưa đăng nhập";
                sttTTThoiGian.Text = "";

                i_NhanVien.Enabled = false;
                btnNhanVien.Enabled = false;

                i_nhaCungcap.Enabled = false;
                btnNhaCungCap.Enabled = false;

                i_khcachhang.Enabled = false;
                btnKhachHang.Enabled = false;

                i_hang.Enabled = false;
                btnHang.Enabled = false;


                i_hoadonnhap.Enabled = false;
                btnhdb.Enabled = false;

                i_hoadonban.Enabled = false;
                btnChitiethoadon.Enabled = false;

                i_chitiethoadon.Enabled = false;
                btnhoadonnhap.Enabled = false;

                i_bcnhanvien.Enabled = false;
                btnbcnhanvien.Enabled = false;

                i_bcchitiehoadon.Enabled = false;
                btnbccthd.Enabled = false;



                toolStripButton1.Enabled = false;
                phiếuNhậpKhoToolStripMenuItem.Enabled = false;

               // btnTroGiup.Enabled = false;
               // btnThongTinPhanMem.Enabled = false;

                i_dangxuat.Enabled = false;
                btndangxuat.Enabled = false;

                trợGiúpToolStripMenuItem.Enabled = true;
              
            }

        }


       

        private void i_htDangNhap_Click(object sender, EventArgs e)
        {

            fDN = new DangNhap();
            if (fDN.ShowDialog() == DialogResult.OK)
            {

                string sTen = fDN.txtTen.Text; 
                string sMatKhau = fDN.txtMatKhau.Text; 
                NguoiDung = new NguoiDung_DTO();
                NguoiDung = NguoiDung_BLL.LayNguoiDung(sTen, sMatKhau);
                if (NguoiDung != null)
                {
                    bDangNhap = true;
                }
            }
            else
            {
                bDangNhap = false;
            }
            HienThiMenu();
        }

        private void i_NhanVien_Click(object sender, EventArgs e)
        {
            if (fNV == null || fNV.IsDisposed)
            {
                fNV = new frm_NhanVien();
                fNV.MdiParent = this;
                fNV.Show();
            }
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            // Đóng tất cả form đang mở       
            foreach (Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
            // Đăng xuất và thiết lập lại menu         
            bDangNhap = false;
            HienThiMenu(); 
        }

       

        private void i_khcachhang_Click(object sender, EventArgs e)
        {
            if (fKH == null || fKH.IsDisposed)
            {
                fKH = new frm_KhachHang();
                fKH.MdiParent = this;
                fKH.Show();
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            i_khcachhang_Click(sender, e);
        }

        private void i_hang_Click(object sender, EventArgs e)
        {
            if (fH == null || fH.IsDisposed)
            {
                fH = new frm_Hang();
                fH.MdiParent = this;
                fH.Show();
            }
        }

        private void i_hoadonnhap_Click(object sender, EventArgs e)
        {
            if (fhdnh == null || fhdnh.IsDisposed)
            {
                fhdnh = new frm_HoaDonNhapHang();
                fhdnh.MdiParent = this;
                fhdnh.Show();
            }
        }

        private void i_hoadonban_Click(object sender, EventArgs e)
        {
            if (fhdb == null || fhdb.IsDisposed)
            {
                fhdb = new frm_HoaDonBan();
                fhdb.MdiParent = this;
                fhdb.Show();
            }
        }

        private void i_chitiethoadon_Click(object sender, EventArgs e)
        {
            if (fcthd == null || fcthd.IsDisposed)
            {
                fcthd = new frm_ChiTietHoaDon();
                fcthd.MdiParent = this;
                fcthd.Show();
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            i_NhanVien_Click( sender,  e);
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            i_hang_Click( sender,  e);
        }

        private void i_bcnhanvien_Click(object sender, EventArgs e)
        {
            if (fBCNV == null || fBCNV.IsDisposed)
            {
                fBCNV = new frm_bcNhanVien();
                fBCNV.MdiParent = this;
                fBCNV.Show();
            }  
        }

        private void i_bcchitiehoadon_Click(object sender, EventArgs e)
        {
            if (fbccthd == null || fbccthd.IsDisposed)
            {
                fbccthd = new frm_bcCTHD();
                fbccthd.MdiParent = this;
                fbccthd.Show();
            }  
        }

        private void nghiệpVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnbccthd_Click(object sender, EventArgs e)
        {
            i_bcchitiehoadon_Click(sender, e);
        }

       

        private void btnhdb_Click(object sender, EventArgs e)
        {
            i_hoadonban_Click(sender, e);
        }

        private void btnbcnhanvien_Click(object sender, EventArgs e)
        {
            i_bcnhanvien_Click(sender, e);
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            i_htDangNhap_Click(sender, e);
        }

        private void i__Click(object sender, EventArgs e)
        {
            // Đóng tất cả form đang mở       
            foreach (Form f in this.MdiChildren)         
            {      if (!f.IsDisposed)                
                f.Close();          
            }            
            // Đăng xuất và thiết lập lại menu         
            bDangNhap = false;           
            HienThiMenu(); 
        }

       

       

        private void btnhoadonnhap_Click(object sender, EventArgs e)
        {
            i_hoadonnhap_Click(sender, e);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            i_nhaCungcap_Click(sender, e);
        }

        private void i_nhaCungcap_Click(object sender, EventArgs e)
        {

            if (fCC == null || fCC.IsDisposed)
            {
                fCC = new frm_NhaCungCap();
                fCC.MdiParent = this;
                fCC.Show();
            } 
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnChitiethoadon_Click(object sender, EventArgs e)
        {
            i_chitiethoadon_Click(sender, e);
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            hướngDẫnSửDụngToolStripMenuItem_Click(sender, e);
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fnk == null || fnk.IsDisposed)
            {
                fnk= new frm_bc_NhapKho();
                fnk.MdiParent = this;
                fnk.Show();
            } 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            phiếuNhậpKhoToolStripMenuItem_Click(sender, e);
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tt == null || tt.IsDisposed)
            {
                tt = new TT();
                tt.MdiParent = this;
                tt.Show();
            } 
        }

        private void btnThongTinPhanMem_Click(object sender, EventArgs e)
        {
            thôngTinPhầnMềmToolStripMenuItem_Click(sender, e);
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (hd == null || hd.IsDisposed)
            {
                hd = new HD();
                hd.MdiParent = this;
                hd.Show();
            } 
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Bạn Có Muốn Thoát?", "Trả Lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(tl ==DialogResult.OK)
                    Application.Exit();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
    }
}
