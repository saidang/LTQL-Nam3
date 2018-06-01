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
   public class HoaDonNhapHang_DAL
    {
        static SqlConnection con;

        public static List<HoaDonNhapHang_DTO> LayDSHoaDonNhapHang()
        {


          //  @"select n.*,c.tenncc from hang n, nhacungcap c where n.mancc=c.mancc";
            string sTruyVan;
            sTruyVan = @"select n.*,c.tenncc, nv.tennv from nhanvien nv, hdnhang n,nhacungcap c where n.mancc=c.mancc and nv.manv=n.manv ";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDonNhapHang_DTO> lstHoaDonNhapHang = new List<DTO.HoaDonNhapHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonNhapHang_DTO hd = new HoaDonNhapHang_DTO();
                hd.SSHHD = dt.Rows[i]["shhd"].ToString();
                hd.SMaNCC = dt.Rows[i]["mancc"].ToString();
                hd.SMaNV = dt.Rows[i]["manv"].ToString();
                hd.SSoTien = float.Parse(dt.Rows[i]["sotien"].ToString());
                hd.SDaTra = dt.Rows[i]["datra"].ToString();
                hd.SConNo = dt.Rows[i]["conno"].ToString();
                hd.STenNCC = dt.Rows[i]["tenncc"].ToString();
                hd.STenNV = dt.Rows[i]["tennv"].ToString();

                lstHoaDonNhapHang.Add(hd);
            }
            DataProvider.DongKetNoi(con);
            return lstHoaDonNhapHang;
        }

           //Tìm Hoa đon nhap hang theo ma
        public static HoaDonNhapHang_DTO TimHDNHTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from hdnhang where shhd=N'{0}'",ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HoaDonNhapHang_DTO hd = new HoaDonNhapHang_DTO();
                hd.SSHHD = dt.Rows[0]["shhd"].ToString();
                hd.SMaNCC = dt.Rows[0]["mancc"].ToString();
                hd.SMaNV = dt.Rows[0]["manv"].ToString();
                hd.SSoTien = float.Parse(dt.Rows[0]["sotien"].ToString());
                hd.SDaTra = dt.Rows[0]["datra"].ToString();
                hd.SConNo = dt.Rows[0]["conno"].ToString();
              //  hd.STenNCC = dt.Rows[0]["tenncc"].ToString();
               // hd.STenNV = dt.Rows[0]["tennv"].ToString();

                
                      
            DataProvider.DongKetNoi(con);
            return hd;
        }
        public static List<HoaDonNhapHang_DTO> TimDSHDNHTheoMaNV(string ma)
        {
            string sTruyVan = string.Format(@"select * from hdnhang where manv='{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<HoaDonNhapHang_DTO> lstHDN = new List<DTO.HoaDonNhapHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonNhapHang_DTO hd = new HoaDonNhapHang_DTO();
                hd.SSHHD = dt.Rows[i]["shhd"].ToString();
                hd.SMaNCC = dt.Rows[i]["mancc"].ToString();
                hd.SMaNV = dt.Rows[i]["manv"].ToString();
                hd.SSoTien = float.Parse(dt.Rows[i]["sotien"].ToString());
                hd.SDaTra = dt.Rows[i]["datra"].ToString();
                hd.SConNo = dt.Rows[i]["conno"].ToString();
                //hd.STenNCC = dt.Rows[i]["tenncc"].ToString();
               // hd.STenNV = dt.Rows[i]["tennv"].ToString();
                lstHDN.Add(hd);
            }
            DataProvider.DongKetNoi(con);
            return lstHDN;
        }
        // Thêm hoa dơn nhap
        public static bool ThemHDN(HoaDonNhapHang_DTO hd)
        {
            string sTruyVan = string.Format(@"insert into hdnhang values('{0}',N'{1}',N'{2}','{3}',N'{4}',N'{5}')", hd.SSHHD, hd.SMaNCC, hd.SMaNV, hd.SSoTien, hd.SDaTra, hd.SConNo);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaHDN(HoaDonNhapHang_DTO hd)
        {
            string sTruyVan = string.Format(@"update hdnhang set mancc=N'{0}', manv='{1}', sotien='{2}', datra=N'{3}', conno=N'{4}' where shhd='{5}'", hd.SMaNCC, hd.SMaNV, hd.SSoTien, hd.SDaTra, hd.SConNo, hd.SSHHD);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }
        // Xóa hóa Don Nhap
        public static bool XoaHDN(HoaDonNhapHang_DTO hd)
        {
            string sTruyVan = string.Format(@"delete from hdnhang where shhd=N'{0}'", hd.SSHHD);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static List<HoaDonNhapHang_DTO> TimHDNHTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select n.*,c.tenncc, nv.tennv from nhanvien nv, hdnhang n,nhacungcap c where n.mancc=c.mancc and nv.manv=n.manv and tennv like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<HoaDonNhapHang_DTO> lstHoaDonNhapHang = new List<DTO.HoaDonNhapHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonNhapHang_DTO hd = new HoaDonNhapHang_DTO();
                hd.SSHHD = dt.Rows[i]["shhd"].ToString();
                hd.SMaNCC = dt.Rows[i]["mancc"].ToString();
                hd.SMaNV = dt.Rows[i]["manv"].ToString();
                hd.SSoTien = float.Parse(dt.Rows[i]["sotien"].ToString());
                hd.SDaTra = dt.Rows[i]["datra"].ToString();
                hd.SConNo = dt.Rows[i]["conno"].ToString();
                hd.STenNCC = dt.Rows[i]["tenncc"].ToString();
                hd.STenNV = dt.Rows[i]["tennv"].ToString();

                lstHoaDonNhapHang.Add(hd);
            }
            DataProvider.DongKetNoi(con);
            return lstHoaDonNhapHang;
        }
    }
}
