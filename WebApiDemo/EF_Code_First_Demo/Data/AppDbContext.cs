using EF_Code_First_Demo.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace EF_Code_First_Demo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Products> Products { get; set; }
    }
}
