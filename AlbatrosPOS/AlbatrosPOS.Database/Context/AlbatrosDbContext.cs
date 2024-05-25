using AlbatrosPOS.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbatrosPOS.Database.Context
{
    /// <summary>
    /// A class that handles database connection and actions.
    /// </summary>
    public class AlbatrosDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlbatrosDbContext"/> class.
        /// </summary>
        /// <param name="options">The options for connection.</param>
        public AlbatrosDbContext(DbContextOptions<AlbatrosDbContext> options) : base(options)
        {   
        }

        /// <summary>
        /// Represents the products table.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Product>()
                .Property(p => p.Id)
                .HasMaxLength(50);

            modelBuilder.Entity<Product>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .HasMaxLength(200);
        }
    }
}
