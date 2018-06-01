using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   public class NhaCC_DAL
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhà cung cấp
        public static List<NhaCC_DTO> LayDSNhaCC()
        {
            string sTruyVan;
            sTruyVan = "select * from nhacungcap";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhaCC_DTO> lstNhaCC = new List<DTO.NhaCC_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhaCC_DTO cc = new NhaCC_DTO();
                cc.SMaNCC = dt.Rows[i]["mancc"].ToString();
                cc.STenNCC = dt.Rows[i]["tenncc"].ToString();
                cc.SDiaChi = dt.Rows[i]["diachi"].ToString();
                cc.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                cc.SGhiChu = dt.Rows[i]["ghichu"].ToString();
                lstNhaCC.Add(cc);
            }
            DataProvider.DongKetNoi(con);
            return lstNhaCC;
        }

        // Lấy thông tin nhà cc có mã ma, trả về null nếu không thấy
        public static NhaCC_DTO TimNhaCCTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhacungcap where mancc='{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NhaCC_DTO cc = new NhaCC_DTO();
            cc.SMaNCC = dt.Rows[0]["mancc"].ToString();
            cc.STenNCC = dt.Rows[0]["tenncc"].ToString();
            cc.SDiaChi = dt.Rows[0]["diachi"].ToString();
            cc.SDienThoai = dt.Rows[0]["dienthoai"].ToString();
            cc.SGhiChu = dt.Rows[0]["ghichu"].ToString();
           
            DataProvider.DongKetNoi(con);
            return cc;
        }

        // Thêm Nha Cung Cấp
        public static bool ThemNhaCC(NhaCC_DTO cc)
        {
            string sTruyVan = string.Format(@"insert into nhacungcap values('{0}',N'{1}',N'{2}',N'{3}',N'{4}')",cc.SMaNCC, cc.STenNCC, cc.SDiaChi, cc.SDienThoai,cc.SGhiChu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Sửa NhaCC
        public static bool SuaNhaCC(NhaCC_DTO cc)
        {
            string sTruyVan = string.Format(@"update nhacungcap set tenncc=N'{0}', diachi=N'{1}', dienthoai=N'{2}', ghichu=N'{3}' where mancc='{4}'", cc.STenNCC, cc.SDiaChi, cc.SDienThoai, cc.SGhiChu, cc.SMaNCC);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        // Xóa giảng viên
        public static bool XoaNhaCC(NhaCC_DTO cc)
        {
            string sTruyVan = string.Format(@"delete from nhacungcap where mancc='{0}'", cc.SMaNCC);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Tìm ds nha cung cấp theo tên, trả về null nếu không thấy
       
        // lấy tên nhacc theo mã
       
        public static List<NhaCC_DTO> TimNCCTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from nhacungcap where tenncc like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<NhaCC_DTO> lstNhaCC = new List<DTO.NhaCC_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhaCC_DTO cc = new NhaCC_DTO();
                cc.SMaNCC = dt.Rows[i]["mancc"].ToString();
                cc.STenNCC = dt.Rows[i]["tenncc"].ToString();
                cc.SDiaChi = dt.Rows[i]["diachi"].ToString();
                cc.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                cc.SGhiChu = dt.Rows[i]["ghichu"].ToString();
                lstNhaCC.Add(cc);
               
            }
            DataProvider.DongKetNoi(con);
            return lstNhaCC;
        }
    }
}
