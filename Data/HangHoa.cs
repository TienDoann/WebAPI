using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public Guid MaHH { get; set; }
        [Required]
        [MaxLength (100)]
        public string TenHH { get; set; }
        [Required]
        public int DonGia { get; set; }
        [Range(0, int.MaxValue)]
        public byte GiamGia { get; set; }
        
        public int LoaiMonAn { get; set; }
        [ForeignKey("LoaiMonAn")]


        public ICollection<ChiTietHD> chiTietHDs { get; set; }
        public virtual Loai Id { get; set; }


    }
}
