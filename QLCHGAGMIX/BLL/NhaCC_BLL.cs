using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
  public  class NhaCC_BLL
    {
        //Lấy DS nhaCc
        public static List<NhaCC_DTO> LayDSNhaCC()
        {
            return NhaCC_DAL.LayDSNhaCC();
        }

        //Lấy một nCC
        public static NhaCC_DTO TimNhaCCTheoMa(string ma)
        {
            return NhaCC_DAL.TimNhaCCTheoMa(ma);
        }

        //Thêm 1 ncc
        public static bool ThemNhaCC(NhaCC_DTO cc)
        {
            return NhaCC_DAL.ThemNhaCC(cc);
        }

        //Sửa 1 nhÀ CC
        public static bool SuaNhaCC(NhaCC_DTO cc)
        {
            return NhaCC_DAL.SuaNhaCC(cc);
        }

        //Xóa 1 nhaCC
        public static bool XoaNhaCC(NhaCC_DTO cc)
        {
            return NhaCC_DAL.XoaNhaCC(cc);
        }

        //Tìm danh sáchNhaCC
        public static List<NhaCC_DTO> TimNCCTheoTen(string ten)
        {
            return NhaCC_DAL.TimNCCTheoTen(ten);
        }
        //lấy nhà cung cap theo mã
      

        
    }
}
