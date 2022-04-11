using System;
using System.Collections.Generic;

namespace WebAPI.Data
{
    public enum TinhTrangHD
    {
        New  = 0, Payment =1, Completed = 2, Cancel =3
    }
    public class HoaDon
    {
        public Guid MaHD { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime? NgayGiao { get; set; }
        public TinhTrangHD TinhTrangHD { get; set; }
        public string NguoiNhan { get; set; }
        public string DiaChiNhanHang { get; set; }
        public int SDT { get; set; }

        public ICollection<ChiTietHD>chiTietHDs { get; set; }

        public HoaDon()
        {
            chiTietHDs = new HashSet<ChiTietHD>();
        }
    }
}
