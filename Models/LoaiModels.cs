using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class LoaiModels
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

    }
}
