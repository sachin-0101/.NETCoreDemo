using Microsoft.EntityFrameworkCore;
using DNC_Demo_WebAPIBasics.Models;

namespace DNC_Demo_WebAPIBasics.Data
{
    public class DNC_DbContext : DbContext
    {
        public DNC_DbContext(DbContextOptions<DNC_DbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("tblProducts");
            base.OnModelCreating(modelBuilder);
        }
    }
}
