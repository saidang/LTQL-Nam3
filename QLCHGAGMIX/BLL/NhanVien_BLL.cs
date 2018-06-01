using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
   public class NhanVien_BLL
    {
       public static List<NhanVien_DTO> LayDSNhanVien()
       {
           return NhanVien_DAL.LayDSNhanVien();
       }
       public static bool ThemNhanVien(NhanVien_DTO nv)
       {
           return NhanVien_DAL.ThemNhanVien(nv);
       }
       //Lấy một giảng viên
       public static NhanVien_DTO TimNhanVienTheoMa(string ma)
       {
           return NhanVien_DAL.TimNhanVienTheoMa(ma);
       }

       public static bool XoaNhanVien(NhanVien_DTO nv)
       {
           return NhanVien_DAL.XoaNhanVien(nv);
       }

       public static List<NhanVien_DTO> TimNVTheoTen(string ten)
       {
           return NhanVien_DAL.TimNVTheoTen(ten);
       }

       //Sửa 1 giảng viên
       public static bool SuaNhanVien(NhanVien_DTO nv)
       {
           return NhanVien_DAL.SuaNhanVien(nv);
       }

    }
}
