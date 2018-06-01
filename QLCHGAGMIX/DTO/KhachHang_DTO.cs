using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class KhachHang_DTO
    {
        private string sMaKH;

        public string SMaKH
        {
            get { return sMaKH; }
            set { sMaKH = value; }
        }
        private string sTenKH;

        public string STenKH
        {
            get { return sTenKH; }
            set { sTenKH = value; }
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

    }
}
