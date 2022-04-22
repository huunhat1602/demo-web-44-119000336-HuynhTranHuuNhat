using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TINTUC.Models
{
    public class News
    {
         public int ID { get; set; }

        [StringLength(200, MinimumLength = 50)]
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public String ImageUrl { get; set; } = string.Empty;
        [StringLength(500, MinimumLength = 100)]
        [Required]
        public string Content { get; set; } = string.Empty;
        
        [Required]
        public string Author{ get; set; } = string.Empty;

        public int CreatedAt { get; set; }
    }
}