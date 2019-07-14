using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GShop.Data.Infratructure
{
    public class DbFactory: Disponsable,IDbFactory
    {
        private GShopDbContext dbContext;
        public GShopDbContext Init()
        {
            return dbContext ?? (dbContext = new GShopDbContext());
        }
        protected override void DisposeCore()
        {
            base.DisposeCore();
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
