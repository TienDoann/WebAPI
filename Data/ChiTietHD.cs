using System;

namespace WebAPI.Data
{
    public class ChiTietHD
    {
        public Guid MaHH { get; set; }
        public Guid MaHD { get; set; }

        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public byte GiamGia { get; set; }

        //relationship
        public HoaDon HoaDon { get; set; }
        public HangHoa HangHoa { get; set; }
    }
}
