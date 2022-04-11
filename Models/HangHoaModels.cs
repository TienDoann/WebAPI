using System;

namespace WebAPI.Models
{
    public class HangHoaModels
    {
        public string TenHH { get; set; }
        public int DonGia { get; set; }
        public byte GiamGia { get; set; }
        public int LoaiMonAn { get; set; }
    }
    public class HangHoaMV : HangHoaModels
    {
        public Guid MaHH { get; set; }
    }
    public class HangHoaModel
    {
        public Guid MaHH { get; set; }
        public string TenHH { get; set; }
        public int DonGia { get; set; }
        public byte GiamGia { get; set; }
        public int LoaiMonAn { get; set; }

        
    }

}
