using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuongqShop.Data.infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactoty;
        private CuongqShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactoty)
        {
            this.dbFactoty = dbFactoty;
        }

        public CuongqShopDbContext DbContext { 
            get { return dbContext ?? (dbFactoty.Init()); } 
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
