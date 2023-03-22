using System;

namespace CuongqShop.Data.infrastructure
{
    public interface IDbFactory : IDisposable
    {
        CuongqShopDbContext Init();
    }
}