using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HoaDonNhapHang_DTO
    {
        private string sSHHD;

        public string SSHHD
        {
            get { return sSHHD; }
            set { sSHHD = value; }
        }
        private string sMaNCC;

        public string SMaNCC
        {
            get { return sMaNCC; }
            set { sMaNCC = value; }
        }
        private string sMaNV;

        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }
        private float sSoTien;

        public float SSoTien
        {
            get { return sSoTien; }
            set { sSoTien = value; }
        }
        private string sDaTra;

        public string SDaTra
        {
            get { return sDaTra; }
            set { sDaTra = value; }
        }
        private string sConNo;

        public string SConNo
        {
            get { return sConNo; }
            set { sConNo = value; }
            
        }
        private string sTenNV;

        public string STenNV
        {
            get { return sTenNV; }
            set { sTenNV = value; }
        }
        private string sTenNCC;

        public string STenNCC
        {
            get { return sTenNCC; }
            set { sTenNCC = value; }
        }
    }
}
