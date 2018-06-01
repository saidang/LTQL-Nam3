
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
  public  class CTHD_BLL
    {
        //Lấy DS giảng viên
        public static List<CTHD_DTO> LayDSCTHD()
        {
            return CTHD_DAL.LayDSCTHD();
        }
        //Thêm 1 san pham
        public static bool ThemCTHD(CTHD_DTO cthd)
        {
            return CTHD_DAL.ThemCTHD(cthd);
        }
        public static bool SuaCTHD(CTHD_DTO cthd)
        {
            return CTHD_DAL.SuaCTHD(cthd);
        }
        public static bool XoaCTHD(CTHD_DTO cthd)
        {
            return CTHD_DAL.XoaCTHD(cthd);
        }
    }
}
