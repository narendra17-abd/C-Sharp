using Microsoft.EntityFrameworkCore;
using Repo_Pattern.Model;
using System.Collections.Generic;

namespace Repo_Pattern.Data
{
    public class AppDbContext:DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
