using CuonqShop.Model.Models;
using System.Data.Entity;

namespace CuongqShop.Data
{
    public class CuongqShopDbContext : DbContext
    {
        public CuongqShopDbContext() : base("Data Source=BANHBAOTHAPCAM\\SQL2019; Initial Catalog=CuongqShop; Integrated Security=True; MultipleActiveResultSets=True; User ID=Qcuong103;Password=10032000;")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        public DbSet<Error> Errors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}