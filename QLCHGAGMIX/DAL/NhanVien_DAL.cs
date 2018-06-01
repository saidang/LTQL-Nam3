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
    public class NhanVien_DAL
    {
            static SqlConnection con;

            // Lấy danh sách tất cả nhân viên
            public static List<NhanVien_DTO> LayDSNhanVien()
            {
                string sTruyVan;
                sTruyVan = "select * from nhanvien";
                con = DataProvider.MoKetNoi();
                DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhanVien_DTO nv = new NhanVien_DTO();
                    nv.SMaNV = dt.Rows[i]["manv"].ToString();
                    nv.STenNV = dt.Rows[i]["tennv"].ToString();
                    nv.SChucVU = dt.Rows[i]["chucvu"].ToString();
                    nv.SGioiTinh1 = dt.Rows[i]["gioitinh"].ToString();
                    nv.SDiaChi = dt.Rows[i]["diachi"].ToString();
                    nv.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                    nv.SNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());

                    lstNhanVien.Add(nv);
                }
          
                return lstNhanVien;
            }
        // Lấy thông tin giảng viên có mã ma, trả về null nếu không thấy
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from NhanVien where manv='{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = dt.Rows[0]["manv"].ToString();
            nv.STenNV = dt.Rows[0]["tennv"].ToString();
            nv.SChucVU = dt.Rows[0]["chucvu"].ToString();
            nv.SGioiTinh1 = dt.Rows[0]["gioitinh"].ToString();
            nv.SDiaChi = dt.Rows[0]["diachi"].ToString();
            nv.SDienThoai = dt.Rows[0]["dienthoai"].ToString();

            nv.SNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            DataProvider.DongKetNoi(con);
            return nv;
        }
        // Thêm giảng viên
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"insert into nhanvien values('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", nv.SMaNV, nv.STenNV,nv.SChucVU, nv.SGioiTinh1, nv.SDiaChi,nv.SDienThoai,nv.SNgaySinh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        // Sửa giảng viên
        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
           
            string sTruyVan = string.Format(@"update nhanvien set tennv=N'{0}',chucvu=N'{1}' ,gioitinh=N'{2}',diachi=N'{3}',dienthoai=N'{4}',ngaysinh=N'{5}' where manv='{6}'", nv.STenNV, nv.SChucVU, nv.SGioiTinh1, nv.SDiaChi, nv.SDienThoai, nv.SNgaySinh, nv.SMaNV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }



        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"delete from nhanvien where manv='{0}'", nv.SMaNV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static List<NhanVien_DTO> TimNVTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where tennv like '%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.STenNV = dt.Rows[i]["tennv"].ToString();
                nv.SChucVU = dt.Rows[i]["chucvu"].ToString();
                nv.SGioiTinh1 = dt.Rows[i]["gioitinh"].ToString();
                nv.SDiaChi = dt.Rows[i]["diachi"].ToString();
                nv.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                nv.SNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien; 
        }
    }
}
