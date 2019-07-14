using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GShop.Data.Infratructure
{
    public interface IDbFactory: IDisposable
    {
        GShopDbContext Init();
    }
}
