using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public string name { set; get; }
        [Required]
        public string ULR { set; get; }
        public int? DisplayOder { get; set; }
        [Required]
        public string GroupID { get; set; }
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }
        [Required]
        public string Target { get; set; }
        [Required]
        public bool Status { get; set; }
        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}