using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class NhaCC_DTO
    {
        private string sMaNCC;

        public string SMaNCC
        {
            get { return sMaNCC; }
            set { sMaNCC = value; }
        }
        private string sTenNCC;

        public string STenNCC
        {
            get { return sTenNCC; }
            set { sTenNCC = value; }
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
        private string sGhiChu;

        public string SGhiChu
        {
            get { return sGhiChu; }
            set { sGhiChu = value; }
        }


    }
}
