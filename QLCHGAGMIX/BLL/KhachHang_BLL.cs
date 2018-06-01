using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using DAL;
    using DTO;

namespace BLL
{
    public class KhachHang_BLL
    {
        //Lấy DS giảng viên
        public static List<KhachHang_DTO> LayDSKhachHang()
        {
            return KhachHang_DAL.LayDSKhachHang();
        }
        //Thêm 1 giảng viên
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAL.ThemKhachHang(kh);
        }
        //Xóa 1 Khách Hàng
        public static bool XoaKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAL.XoaKhachHang(kh);
        }
        //Sửa 1 Khách Hàng
        public static bool SuaKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAL.SuaKhachHang(kh);
        }
        public static List<KhachHang_DTO> TimKHTheoTen(string ten)
        {
            return KhachHang_DAL.TimKHTheoTen(ten);
        }
    }
}
