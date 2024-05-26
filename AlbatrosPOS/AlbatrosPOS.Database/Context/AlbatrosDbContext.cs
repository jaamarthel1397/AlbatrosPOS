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

        /// <summary>
        /// Represents the addresses table.
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Represents the clients table.
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// Represents the order headers table.
        /// </summary>
        public DbSet<OrderHeader> OrderHeaders { get; set; }

        /// <summary>
        /// Represents the order details table.
        /// </summary>
        public DbSet<OrderDetail> OrderDetails { get; set; }

        /// <summary>
        /// Represents the users table.
        /// </summary>
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Product
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

            //Client
            modelBuilder.Entity<Client>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Client>()
                .Property(p => p.Id)
                .HasMaxLength(50);

            modelBuilder.Entity<Client>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Client>()
                .Property(p => p.Name)
                .HasMaxLength(100);

            modelBuilder.Entity<Client>()
                .HasMany(x => x.Addresses)
                .WithOne(y => y.Client)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.Restrict);


            //Address

            modelBuilder.Entity<Address>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Address>()
                .Property(p => p.Id)
                .HasMaxLength(50);

            modelBuilder.Entity<Address>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Address>()
                .Property(p => p.Description)
                .HasMaxLength(500);

            modelBuilder.Entity<Address>()
                .Property(p => p.ClientId)
                .HasMaxLength(50);

            //Order Header
            modelBuilder.Entity<OrderHeader>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<OrderHeader>()
                .Property(p => p.Id)
                .HasMaxLength(50);

            modelBuilder.Entity<OrderHeader>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<OrderHeader>()
                .Property(p => p.AddressId)
                .HasMaxLength(50);

            modelBuilder.Entity<OrderHeader>()
                .Property(p => p.ClientId)
                .HasMaxLength(50);

            modelBuilder.Entity<OrderHeader>()
                .HasMany(x => x.Details)
                .WithOne(y => y.Header)
                .HasForeignKey(x => x.HeaderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderHeader>()
                .HasOne(x => x.Client)
                .WithMany(y => y.Orders)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            //Order detail
            modelBuilder.Entity<OrderDetail>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<OrderDetail>()
                .Property(p => p.Id)
                .HasMaxLength(50);

            modelBuilder.Entity<OrderDetail>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<OrderDetail>()
                .Property(p => p.HeaderId)
                .HasMaxLength(50);

            modelBuilder.Entity<OrderDetail>()
                .Property(p => p.ProductId)
                .HasMaxLength(50);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(x => x.Product)
                .WithMany(y => y.Orders)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .Property(p => p.Username)
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .HasKey(p => p.Username);

            modelBuilder.Entity<User>()
                .Property(p => p.Password)
                .HasMaxLength(1000);
        }
    }
}
