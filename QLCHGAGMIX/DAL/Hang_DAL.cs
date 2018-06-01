
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
   public class Hang_DAL
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<Hang_DTO> LayDSHang()
        {
            //select n.*,c.tenncc from hang n, nhacungcap c where n.mancc=c.mancc
            string sTruyVan = @"select n.*,c.tenncc from hang n, nhacungcap c where n.mancc=c.mancc";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Hang_DTO> lstHang = new List<DTO.Hang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Hang_DTO h = new Hang_DTO();
                h.SMaHang = dt.Rows[i]["mah"].ToString();
                h.STenHang = dt.Rows[i]["tenh"].ToString();
                h.SMaNCC = dt.Rows[i]["mancc"].ToString();
                h.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                h.SDonGiaNhap = float.Parse(dt.Rows[i]["dongianhap"].ToString());
                h.SDonGiaBan = float.Parse(dt.Rows[i]["dongiaban"].ToString());
                h.STenNCC = dt.Rows[i]["tenncc"].ToString();
                lstHang.Add(h);
            }
            DataProvider.DongKetNoi(con);
            return lstHang;
        }

      
        public static Hang_DTO TimHangTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from hang where mah=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            Hang_DTO h = new Hang_DTO();
            h.SMaHang = dt.Rows[0]["mah"].ToString();
            h.STenHang = dt.Rows[0]["tenh"].ToString();
            h.SMaNCC = dt.Rows[0]["mancc"].ToString();
            h.SSoLuong = int.Parse(dt.Rows[0]["soluong"].ToString());
            h.SDonGiaNhap = float.Parse(dt.Rows[0]["dongianhap"].ToString());
            h.SDonGiaBan = float.Parse(dt.Rows[0]["dongiaban"].ToString());
            //h.STenNCC = dt.Rows[0]["tenncc"].ToString();
            DataProvider.DongKetNoi(con);
            return h;
        }
        // Lấy danh sách các nhân viên có mã chức vụ ma
        public static List<Hang_DTO> LayDSHangTheoMaNhaCC(string ma)
        {
            string sTruyVan = string.Format(@"select * from hang where mancc=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<Hang_DTO> lstHang = new List<DTO.Hang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Hang_DTO h = new Hang_DTO();
                h.SMaHang = dt.Rows[i]["mah"].ToString();
                h.STenHang = dt.Rows[i]["tenh"].ToString();
                h.SMaNCC = dt.Rows[i]["mancc"].ToString();
                h.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                h.SDonGiaNhap = float.Parse(dt.Rows[i]["dongianhap"].ToString());
                h.SDonGiaBan = float.Parse(dt.Rows[i]["dongiaban"].ToString());
                lstHang.Add(h);
            }
            DataProvider.DongKetNoi(con);
            return lstHang;
        }

        // Thêm nhân viên
        public static bool ThemHang(Hang_DTO h)
        {

                            
            string sTruyVan = string.Format(@"insert into hang values(N'{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}')", h.SMaHang, h.STenHang,h.SMaNCC, h.SSoLuong, h.SDonGiaNhap, h.SDonGiaBan);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
           

        }

        // Sửa hàng
        public static bool SuaHang(Hang_DTO h)
        {
                                      //(@"update hdnhang set mancc=N'{0}', manv='{1}', sotien='{2}', datra=N'{3}', conno=N'{4}' where shhd='{5}'", hd.SMaNCC, hd.SMaNV, hd.SSoTien, hd.SDaTra, hd.SConNo, hd.SSHHD);
            string sTruyVan = string.Format(@"update hang set tenh=N'{0}', mancc='{1}', soluong='{2}', dongianhap=N'{3}', dongiaban=N'{4}' where mah='{5}'", h.STenHang ,h.SMaNCC, h.SSoLuong, h.SDonGiaNhap, h.SDonGiaBan, h.SMaHang);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        // Xóa nhân viên
        public static bool XoaHang(Hang_DTO h)
        {
            string sTruyVan = string.Format(@"delete from hang where mah=N'{0}'", h.SMaHang);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static List<Hang_DTO> TimDSHTheoMaNCC(string ma)
        {
            string sTruyVan = string.Format(@"select * from hang where mancc='{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<Hang_DTO> lstH = new List<DTO.Hang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                Hang_DTO h = new Hang_DTO();
                h.SMaHang = dt.Rows[i]["mah"].ToString();
                h.STenHang = dt.Rows[i]["tenh"].ToString();
                h.SMaNCC = dt.Rows[i]["mancc"].ToString();
                h.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                h.SDonGiaNhap = float.Parse(dt.Rows[i]["dongianhap"].ToString());
                h.SDonGiaBan = float.Parse(dt.Rows[i]["dongiaban"].ToString());
                lstH.Add(h);
            }
            DataProvider.DongKetNoi(con);
            return lstH;
        }
        public static List<Hang_DTO> TimHangTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from hang where tenh like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<Hang_DTO> lstH = new List<DTO.Hang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Hang_DTO h = new Hang_DTO();
                h.SMaHang = dt.Rows[i]["mah"].ToString();
                h.STenHang = dt.Rows[i]["tenh"].ToString();
                h.SMaNCC = dt.Rows[i]["mancc"].ToString();
                h.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                h.SDonGiaNhap = float.Parse(dt.Rows[i]["dongianhap"].ToString());
                h.SDonGiaBan = float.Parse(dt.Rows[i]["dongiaban"].ToString());
                lstH.Add(h);
            }
            DataProvider.DongKetNoi(con);
            return lstH;
        }
    }
}
