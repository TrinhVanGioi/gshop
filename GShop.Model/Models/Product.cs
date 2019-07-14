using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GShop.Model.Abstract;
using System.Xml.Linq;

namespace GShop.Model.Models
{
    [Table("Products")]
    public class Product: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { set; get; }
        [Required]
        public string Name { set; get; }
        public string Alias { set; get; }
        public int Image { set; get; }
        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategrory ProductCategrory { set; get; }
    }
}