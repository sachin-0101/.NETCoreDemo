using Microsoft.EntityFrameworkCore;
using DNC_Demo_WebAPIBasics.Models;

namespace DNC_Demo_WebAPIBasics.Data
{
    public class DNCDbContext : DbContext
    {
        public DNCDbContext(DbContextOptions<DNCDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            base.OnModelCreating(modelBuilder);
        }
    }
}
