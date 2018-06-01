using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public class HoaDonNhapHang_BLL
    {
        //Lấy DS HDNH
       public static List<HoaDonNhapHang_DTO> LayDSHoaDonNhapHang()
        {
            return HoaDonNhapHang_DAL.LayDSHoaDonNhapHang();
        }
       //Thêm 1 giảng viên
       public static bool ThemHDN(HoaDonNhapHang_DTO hdn)
       {
           return HoaDonNhapHang_DAL.ThemHDN(hdn);
       }
       //
       public static HoaDonNhapHang_DTO TimHDNHTheoMa(string ma)
       {
           return HoaDonNhapHang_DAL.TimHDNHTheoMa(ma);
       }
       //
       public static bool SuaHDN(HoaDonNhapHang_DTO hdn)
       {
           return HoaDonNhapHang_DAL.SuaHDN(hdn);
       }
       //
       public static bool XoaHDN(HoaDonNhapHang_DTO hdn)
       {
           return HoaDonNhapHang_DAL.XoaHDN(hdn);
       }
     
       //Tìm danh sách lịch theo mã giảng viên
       public static List<HoaDonNhapHang_DTO> TimDSHDNHTheoMaNV(string ma)
       {
           return HoaDonNhapHang_DAL.TimDSHDNHTheoMaNV(ma);
       }
       public static List<HoaDonNhapHang_DTO> TimHDNHTheoTen(string ten)
       {
           return HoaDonNhapHang_DAL.TimHDNHTheoTen(ten);
       }
    }
}
