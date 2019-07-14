using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {        
        [Key]
        public string ID { set; get; }
        [Required]
        public string name { set; get; }
    }
}