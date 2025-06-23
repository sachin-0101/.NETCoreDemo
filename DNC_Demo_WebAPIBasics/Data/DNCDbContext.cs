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
        public DbSet<DNC_Demo_WebAPIBasics.Models.Users> Users { get; set; } = default!;
        public DbSet<DNC_Demo_WebAPIBasics.Models.Categories> Categories { get; set; } = default!;
        public DbSet<DNC_Demo_WebAPIBasics.Models.Customers> Customers { get; set; } = default!;
    }
}
