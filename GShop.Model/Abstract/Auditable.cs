using System;
using System.ComponentModel.DataAnnotations;

namespace GShop.Model.Abstract
{
    public abstract class Auditable: IAuditable
    {
        public DateTime? CrateDate { get; set; }
        [MaxLength(256)]
        public string CrateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        [MaxLength(256)]
        public string UpdateBy { get; set; }
        [MaxLength(256)]
        public string MetaKeyword { set; get; }
        [MaxLength(256)]
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}