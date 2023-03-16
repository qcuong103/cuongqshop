﻿using CuongqShop.Data.infrastructure;
using CuonqShop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace CuongqShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) 
            : base(dbFactory)
        { 
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(c => c.Alias == alias);
        }
    }
}
