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
   public class CTHD_DAL
    {
       static SqlConnection con;
        // Lấy danh sách tất cả nhân viên
        public static List<CTHD_DTO> LayDSCTHD()
        {
            //select n.*,c.tenncc from hang n, nhacungcap c where n.mancc=c.mancc
            string sTruyVan = @"select n.*,h.tenh from cthd n, hang h where n.mah=h.mah";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<CTHD_DTO> lstCTHD = new List<DTO.CTHD_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CTHD_DTO cthd = new CTHD_DTO();
                cthd.SMaHD = dt.Rows[i]["mahd"].ToString();
                cthd.SMaHang = dt.Rows[i]["mah" ].ToString();
                cthd.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                cthd.SDonGia = float.Parse(dt.Rows[i]["dongia"].ToString());
                cthd.SGiamGia = dt.Rows[i]["giamgia"].ToString();
                cthd.STenHang = dt.Rows[i]["tenh"].ToString();
                lstCTHD.Add(cthd);
            }
            DataProvider.DongKetNoi(con);
            return lstCTHD;
        }
        public static bool ThemCTHD(CTHD_DTO cthd  )
        {
            string sTruyVan = string.Format(@"insert into cthd values('{0}',N'{1}','{2}','{3}',N'{4}')", cthd.SMaHD, cthd.SMaHang, cthd.SSoLuong, cthd.SDonGia ,cthd.SGiamGia);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaCTHD(CTHD_DTO cthd)
        {
            //(@"update hdnhang set mancc=N'{0}', manv='{1}', sotien='{2}', datra=N'{3}', conno=N'{4}' where shhd='{5}'", hd.SMaNCC, hd.SMaNV, hd.SSoTien, hd.SDaTra, hd.SConNo, hd.SSHHD);
            string sTruyVan = string.Format(@"update cthd set mah='{0}', soluong='{1}', dongia='{2}', giamgia=N'{3}' where mahd='{4}'",cthd.SMaHang,  cthd.SSoLuong, cthd.SDonGia, cthd.SGiamGia, cthd.SMaHD);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }
        public static bool XoaCTHD(CTHD_DTO cthd)
        {
            string sTruyVan = string.Format(@"delete from cthd where mahd=N'{0}'", cthd.SMaHD);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
