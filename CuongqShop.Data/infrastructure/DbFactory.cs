using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuongqShop.Data.infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private CuongqShopDbContext dbContext;

        public CuongqShopDbContext Init()
        {
            return dbContext ?? (dbContext = new CuongqShopDbContext());
        }

        //public CuongqShopDbContext init()
        //{
        //    return dbContext ?? (dbContext = new CuongqShopDbContext());
        //}

        protected override void DisposeCore()
        {
            if (dbContext != null) { dbContext.Dispose(); }
        }
    }
}
