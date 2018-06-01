
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string sMaNV;

        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }
        private string sTenNV;

        public string STenNV
        {
            get { return sTenNV; }
            set { sTenNV = value; }
        }
        private string sChucVU;

        public string SChucVU
        {
            get { return sChucVU; }
            set { sChucVU = value; }
        }
        private string SGioiTinh;

        public string SGioiTinh1
        {
            get { return SGioiTinh; }
            set { SGioiTinh = value; }
        }
        private string sDiaChi;

        public string SDiaChi
        {
            get { return sDiaChi; }
            set { sDiaChi = value; }
        }
        private string sDienThoai;

        public string SDienThoai
        {
            get { return sDienThoai; }
            set { sDienThoai = value; }
        }
        private DateTime sNgaySinh;

        public DateTime SNgaySinh
        {
            get { return sNgaySinh; }
            set { sNgaySinh = value; }
        }
    }
}
