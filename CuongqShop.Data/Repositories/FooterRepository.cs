using CuongqShop.Data.infrastructure;
using CuonqShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuongqShop.Data.Repositories
{
    public interface IFooterRepository
    {

    }
    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory){
        }
    }
}
