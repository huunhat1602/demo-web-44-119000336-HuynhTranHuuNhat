using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TINTUC.Models
{
    public class Comment
    {
        public int ID { get; set; }
        
        [Required]
        public string Author{ get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;
   
        public int CreatedAt { get; set; }
    }
}