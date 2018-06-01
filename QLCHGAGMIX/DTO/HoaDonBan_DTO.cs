using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HoaDonBan_DTO
    {
        private string sMaHD;

        public string SMaHD
        {
            get { return sMaHD; }
            set { sMaHD = value; }
        }
        private string sMaNV;

        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }
        private DateTime sNgayBan;

        public DateTime SNgayBan
        {
            get { return sNgayBan; }
            set { sNgayBan = value; }
        }
        private string sMaKH;

        public string SMaKH
        {
            get { return sMaKH; }
            set { sMaKH = value; }
        }
        private int sSoLuong;

        public int SSoLuong
        {
            get { return sSoLuong; }
            set { sSoLuong = value; }
        }
        private float sTongTien;

        public float STongTien
        {
            get { return sTongTien; }
            set { sTongTien = value; }
        }
        private string sTenKH;

        public string STenKH
        {
            get { return sTenKH; }
            set { sTenKH = value; }
        }
        private string sTenNV;

        public string STenNV
        {
            get { return sTenNV; }
            set { sTenNV = value; }
        }

    }
}
