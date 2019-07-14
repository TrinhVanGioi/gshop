using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GShop.Model.Abstract;

namespace GShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategrory: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public string Description { set; get; }
        public int? Parent { set; get; }
        public int? DisplayOder { set; get; } 
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }
        
        public virtual IEnumerable<Product> Products { set; get; }
    }
}
