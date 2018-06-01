using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HoaDonBan_BLL
    {
        //Lấy DS Hoa Đơn Bán
        public static List<HoaDonBan_DTO> LayDSHoaDonBan()
        {
            return HoaDonBan_DAL.LayDSHoaDonBan();
        }

        //Lấy một giảng viên
        public static HoaDonBan_DTO TimHDBTheoMa(string ma)
        {
            return HoaDonBan_DAL.TimHDBTheoMa(ma);
        }
        public static bool ThemHDB(HoaDonBan_DTO hdb)
        {
            return HoaDonBan_DAL.ThemHDB(hdb);
        }
        public static bool SuaHDB(HoaDonBan_DTO hdb)
        {
            return HoaDonBan_DAL.SuaHDB(hdb);
        }
        public static bool XoaHDB(HoaDonBan_DTO hdb)
        {
            return HoaDonBan_DAL.XoaHDB(hdb);
        }
        public static List<HoaDonBan_DTO> TimDSHDBTheoMaNV(string ma)
        {
            return HoaDonBan_DAL.TimDSHDBTheoMaNV(ma);
        }
        public static List<HoaDonBan_DTO> TimHDBTheoTen(string ten)
        {
            return HoaDonBan_DAL.TimHDBTheoTen(ten);
        }
    }
}
