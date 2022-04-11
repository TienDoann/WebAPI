using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public enum TinhTrangHD
    {
        New = 0, Payment = 1, Completed = 2, Cancel = 3
    }
    public class HoaDonModels
    {
        public Guid MaHD { get; set; }
        [Required]
        public DateTime NgayDat { get; set; }
        public DateTime? NgayGiao { get; set; }
        public TinhTrangHD TinhTrangHD { get; set; }
        public string NguoiNhan { get; set; }
        public string DiaChiNhanHang { get; set; }
        public int SDT { get; set; }
    }
}
