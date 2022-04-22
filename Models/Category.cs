using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TINTUC.Models
{
    public class Category
    {
        
        public int ID { get; set; }

        [StringLength(200)]
        [Required]
        public string Name { get; set; } = string.Empty;

    }
}