using System;

namespace GShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CrateDate { get; set; }
        string CrateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }

        string MetaKeyword { set; get; }        
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}