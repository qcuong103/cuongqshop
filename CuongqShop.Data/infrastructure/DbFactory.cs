namespace CuongqShop.Data.infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private CuongqShopDbContext dbContext;

        public CuongqShopDbContext Init()
        {
            return dbContext ?? (dbContext = new CuongqShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}