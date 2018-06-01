using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class Hang_BLL
    {
        //Lấy DS giảng viên
        public static List<Hang_DTO> LayDSHang()
        {
            return Hang_DAL.LayDSHang();
        }
        //Thêm 1 san pham
        public static bool ThemHang(Hang_DTO h)
        {
            return Hang_DAL.ThemHang(h);
        }
        //Xóa 1 san pham
        public static bool XoaHang(Hang_DTO h)
        {
            return Hang_DAL.XoaHang(h);
        }
        //Sửa 1 sản phẩm
        public static bool SuaHang(Hang_DTO h)
        {
            return Hang_DAL.SuaHang(h);
        }
        //Lấy DS nhân viên theo tên
      

        //Lấy một nhân viên theo mã
        public static Hang_DTO TimHangTheoMa(string ma)
        {
            return Hang_DAL.TimHangTheoMa(ma);
        }
        public static List<Hang_DTO> TimHangTheoTen(string ten)
        {
            return Hang_DAL.TimHangTheoTen(ten);
        }
        //Lấy một nhân viên theo mã chức vụ
        public static List<Hang_DTO> TimDSHTheoMaNCC(string ma)
        {
            return Hang_DAL.TimDSHTheoMaNCC(ma);
        }
    }
      
}
