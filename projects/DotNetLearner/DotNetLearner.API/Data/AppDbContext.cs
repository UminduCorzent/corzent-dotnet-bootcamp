using DotNetLearner.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetLearner.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
