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
   public class HoaDonBan_DAL
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<HoaDonBan_DTO> LayDSHoaDonBan()
        {
            //select n.*,c.tenncc from hang n, nhacungcap c where n.mancc=c.mancc
            //select n.*,n.tennv,kh.tenkh from hoadonban hd, nhanvien n,khachhang kh where hd.manv=n.manv and hd.makh=kh.makh
            //select n.*,c.tenncc, nv.tennv from nhanvien nv, hdnhang n,nhacungcap c where n.mancc=c.mancc and nv.manv=n.manv
            string sTruyVan = @" select n.*,hd.tenkh,nv.tennv from hoadonban n, khachhang hd,nhanvien nv where hd.makh=n.makh and  nv.manv=n.manv";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDonBan_DTO> lstHoaDonBan = new List<DTO.HoaDonBan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonBan_DTO hdb = new HoaDonBan_DTO();
                hdb.SMaHD = dt.Rows[i]["mahd"].ToString();
                hdb.SMaNV = dt.Rows[i]["manv"].ToString();
                hdb.SNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                hdb.SMaKH = dt.Rows[i]["makh"].ToString();
                hdb.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                hdb.STongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());
               hdb.STenNV = dt.Rows[i]["tennv"].ToString();
               hdb.STenKH = dt.Rows[i]["tenkh"].ToString();
               
                lstHoaDonBan.Add(hdb);
            }
            DataProvider.DongKetNoi(con);
            return lstHoaDonBan;
        }
        public static HoaDonBan_DTO TimHDBTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from hoadonban where mahd='{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HoaDonBan_DTO hdb = new HoaDonBan_DTO();
            hdb.SMaHD = dt.Rows[0]["mahd"].ToString();
            hdb.SMaNV = dt.Rows[0]["manv"].ToString();
            hdb.SNgayBan = DateTime.Parse(dt.Rows[0]["ngayban"].ToString());
            hdb.SMaKH = dt.Rows[0]["makh"].ToString();
            hdb.SSoLuong = int.Parse(dt.Rows[0]["soluong"].ToString());
            hdb.STongTien = float.Parse(dt.Rows[0]["tongtien"].ToString());
            DataProvider.DongKetNoi(con);
            return hdb;
        }
        public static bool ThemHDB(HoaDonBan_DTO hdb)
        {
            string sTruyVan = string.Format(@"insert into hoadonban values('{0}','{1}','{2}','{3}','{4}','{5}')", hdb.SMaHD, hdb.SMaNV, hdb.SNgayBan, hdb.SMaKH, hdb.SSoLuong,hdb.STongTien);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaHDB(HoaDonBan_DTO hdb)
        {
            string sTruyVan = string.Format(@"update hoadonban set manv=N'{0}', ngayban='{1}', makh=N'{2}', soluong='{3}', tongtien='{4}' where mahd='{5}'", hdb.SMaNV, hdb.SNgayBan, hdb.SMaKH, hdb.SSoLuong, hdb.STongTien, hdb.SMaHD);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }
        public static bool XoaHDB(HoaDonBan_DTO hdb)
        {
            string sTruyVan = string.Format(@"delete from hoadonban where mahd=N'{0}'", hdb.SMaHD);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static List<HoaDonBan_DTO> TimDSHDBTheoMaNV(string ma)
        {
            //select n.*,hd.tenkh,nv.tennv from hoadonban n, khachhang hd,nhanvien nv where hd.makh=n.makh and  nv.manv=n.manv"
            string sTruyVan = string.Format(@"select n.*,hd.tenkh,nv.tennv from hoadonban n, khachhang hd,nhanvien nv where hd.makh=n.makh and  nv.manv=n.manv and nv.manv='{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<HoaDonBan_DTO> lstHDB = new List<DTO.HoaDonBan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonBan_DTO hdb = new HoaDonBan_DTO();
                hdb.SMaHD = dt.Rows[i]["mahd"].ToString();
                hdb.SMaNV = dt.Rows[i]["manv"].ToString();
                hdb.SNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                hdb.SMaKH = dt.Rows[i]["makh"].ToString();
                hdb.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                hdb.STongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());
                hdb.STenNV = dt.Rows[i]["tennv"].ToString();
                hdb.STenKH = dt.Rows[i]["tenkh"].ToString();
                lstHDB.Add(hdb);
            }
            DataProvider.DongKetNoi(con);
            return lstHDB;
        }
        public static List<HoaDonBan_DTO> TimHDBTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select n.*,hd.tenkh,nv.tennv from hoadonban n, khachhang hd,nhanvien nv where hd.makh=n.makh and  nv.manv=n.manv and tennv like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<HoaDonBan_DTO> lstHDB = new List<DTO.HoaDonBan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                HoaDonBan_DTO hdb = new HoaDonBan_DTO();
                hdb.SMaHD = dt.Rows[i]["mahd"].ToString();
                hdb.SMaNV = dt.Rows[i]["manv"].ToString();
                hdb.SNgayBan = DateTime.Parse(dt.Rows[i]["ngayban"].ToString());
                hdb.SMaKH = dt.Rows[i]["makh"].ToString();
                hdb.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                hdb.STongTien = float.Parse(dt.Rows[i]["tongtien"].ToString());
                hdb.STenNV = dt.Rows[i]["tennv"].ToString();
                hdb.STenKH = dt.Rows[i]["tenkh"].ToString();
                lstHDB.Add(hdb);
            }
            DataProvider.DongKetNoi(con);
            return lstHDB;
        }
    }
}
