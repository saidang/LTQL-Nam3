using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
  public class KhachHang_DAL
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<KhachHang_DTO> LayDSKhachHang()
        {
            string sTruyVan;
            sTruyVan = "select * from khachhang";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKhachHang = new List<DTO.KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.SMaKH = dt.Rows[i]["makh"].ToString();
                kh.STenKH = dt.Rows[i]["tenkh"].ToString();
                kh.SDiaChi = dt.Rows[i]["diachi"].ToString();
                kh.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                lstKhachHang.Add(kh);
            }

            return lstKhachHang;
        }

        // Thêm giảng viên
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"insert into khachhang values('{0}',N'{1}',N'{2}',N'{3}')", kh.SMaKH, kh.STenKH, kh.SDiaChi, kh.SDienThoai);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa giảng viên
        public static bool XoaKhachHang(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"delete from khachhang where makh='{0}'", kh.SMaKH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        // Sửa khách hàng
        public static bool SuaKhachHang(KhachHang_DTO kh)
        {

            string sTruyVan = string.Format(@"update khachhang set tenkh=N'{0}',diachi=N'{1}',dienthoai=N'{2}' where makh='{3}'", kh.STenKH, kh.SDiaChi, kh.SDienThoai, kh.SMaKH);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }
        // Tìm  Khách hàng theo tên, trả về null nếu không thấy
        public static List<KhachHang_DTO> TimKHTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from khachhang where tenkh like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<KhachHang_DTO> lstKhachHang = new List<DTO.KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.SMaKH = dt.Rows[i]["makh"].ToString();
                kh.STenKH = dt.Rows[i]["tenkh"].ToString();
                kh.SDiaChi = dt.Rows[i]["diachi"].ToString();
                kh.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                lstKhachHang.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }

    }
}
