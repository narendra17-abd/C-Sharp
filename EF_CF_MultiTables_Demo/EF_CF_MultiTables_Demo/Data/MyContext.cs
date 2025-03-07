using EF_CF_MultiTables_Demo.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EF_CF_MultiTables_Demo.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
