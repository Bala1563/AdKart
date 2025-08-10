using AdKartDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdKartInfrastructure
{
    public class AdKartDbContext : DbContext
    {
        public AdKartDbContext(DbContextOptions<AdKartDbContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> Roles { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<CoinsContainer> CoinsContainers { get; set; }
        public virtual DbSet<TransientCoinsContainer> TransientCoinsContainers { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<AdWatch> AdWatches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region User Table
            // Making Phone Number Unique in DataBase
            modelBuilder.Entity<User>()
                .HasIndex(u => u.PhoneNumber)
                .IsUnique();

            // Navigation Properties
            modelBuilder.Entity<User>()
                .HasMany(u => u.AdWatches)
                .WithOne(a => a.CreatedByUser)
                .HasForeignKey(a => a.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Carts)
                .WithOne(c => c.CreatedByUser)
                .HasForeignKey(c => c.CreatedBy)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.CreatedByUser)
                .HasForeignKey(o => o.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Transactions)
                .WithOne(t => t.CreatedByUser)
                .HasForeignKey(t => t.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // To Handle the Self-Referencing Foreign Keys (CreatedBy, UpdatedBy)
            modelBuilder.Entity<User>()
                .HasOne(u => u.CreatedByUser)
                .WithMany()
                .HasForeignKey(u => u.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(u => u.UpdatedByUser)
                .WithMany()
                .HasForeignKey(u => u.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region User Role Table
            modelBuilder.Entity<UserRole>()
                .HasIndex(r => r.Role)
                .IsUnique();

            // CreatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<UserRole>()
                .HasOne(r => r.CreatedByUser)
                .WithMany()
                .HasForeignKey(r => r.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<UserRole>()
                .HasOne(r => r.UpdatedByUser)
                .WithMany()
                .HasForeignKey(r => r.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Town Table
            modelBuilder.Entity<Town>()
                .HasIndex(t => t.Name)
                .IsUnique();

            // Navigation Property
            modelBuilder.Entity<Town>()
                .HasMany(t => t.Users)
                .WithOne(u => u.Town)
                .HasForeignKey(u => u.TownId)
                .OnDelete(DeleteBehavior.Restrict);

            // CreatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Town>()
                .HasOne(t => t.CreatedByUser)
                .WithMany()
                .HasForeignKey(t => t.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Town>()
                .HasOne(t => t.UpdatedByUser)
                .WithMany()
                .HasForeignKey(t => t.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Category Table
            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

            // Navigation Property
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Shops)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // CreatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Category>()
                .HasOne(c => c.CreatedByUser)
                .WithMany()
                .HasForeignKey(c => c.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Category>()
                .HasOne(c => c.UpdatedByUser)
                .WithMany()
                .HasForeignKey(c => c.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Shop Table
           // CreatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Shop>()
                .HasOne(s => s.CreatedByUser)
                .WithMany()
                .HasForeignKey(s => s.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Shop>()
                .HasOne(s => s.UpdatedByUser)
                .WithMany()
                .HasForeignKey(s => s.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // Prevents deletion of a User (Owner) while it still has related Shops.
            modelBuilder.Entity<Shop>()
                .HasOne(s => s.Owner)
                .WithMany()
                .HasForeignKey(s => s.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Navigation Property
            modelBuilder.Entity<Shop>()
                .HasMany(s => s.Products)
                .WithOne(p => p.Shop)
                .HasForeignKey(p => p.ShopId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Shop>()
                .HasMany(s => s.Carts)
                .WithOne(c => c.Shop)
                .HasForeignKey(c => c.ShopId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Shop>()
                .HasMany(s => s.Orders)
                .WithOne(o => o.Shop)
                .HasForeignKey(o => o.ShopId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Product Table
            // CreatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Product>()
                .HasOne(p => p.CreatedByUser)
                .WithMany()
                .HasForeignKey(p => p.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Product>()
                .HasOne(p => p.UpdatedByUser)
                .WithMany()
                .HasForeignKey(p => p.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .Property(p => p.MeasuringType)
                .HasConversion<string>();
            #endregion

            #region Cart Table
            // Navigation Property
            modelBuilder.Entity<Cart>()
                .HasMany(c => c.CartItems)
                .WithOne(c => c.Cart)
                .HasForeignKey(c => c.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.UpdatedByUser)
                .WithMany()
                .HasForeignKey(c => c.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // Converting Enum to String for Database storage.
            modelBuilder.Entity<Cart>()
                .Property(c => c.Status)
                .HasConversion<string>();
            #endregion

            #region CartItem Table
            // CreatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<CartItem>()
                .HasOne(c => c.CreatedByUser)
                .WithMany()
                .HasForeignKey(c => c.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<CartItem>()
                .HasOne(c => c.UpdatedByUser)
                .WithMany()
                .HasForeignKey(c => c.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // All CartItems related to a Product should be deleted before the Product is deleted.
            modelBuilder.Entity<CartItem>()
                .HasOne(c => c.Product)
                .WithMany()
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Order Table
            // Nagivation Property
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(o => o.Order)
                .HasForeignKey(o => o.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Order>()
                .HasOne(o => o.UpdatedByUser)
                .WithMany()
                .HasForeignKey(o => o.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .Property(o => o.Status)
                .HasConversion<string>();
            #endregion

            #region OrderItem Table
            // CreatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.CreatedByUser)
                .WithMany()
                .HasForeignKey(o => o.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.UpdatedByUser)
                .WithMany()
                .HasForeignKey(o => o.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // All OrderItems related to a Product should be deleted before the Product is deleted.
            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Product)
                .WithMany()
                .HasForeignKey(o => o.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderItem>()
                .Property(o => o.Status)
                .HasConversion<string>();
            #endregion

            #region CoinsContainer Table
            modelBuilder.Entity<CoinsContainer>()
                .HasOne(c => c.CreatedByUser)
                .WithMany()
                .HasForeignKey(c => c.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CoinsContainer>()
                .HasOne(c => c.UpdatedByUser)
                .WithMany()
                .HasForeignKey(c => c.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region TransientCoinsContainer Table
            modelBuilder.Entity<TransientCoinsContainer>()
                .HasOne(c => c.CreatedByUser)
                .WithMany()
                .HasForeignKey(c => c.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransientCoinsContainer>()
                .HasOne(c => c.UpdatedByUser)
                .WithMany()
                .HasForeignKey(c => c.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Transaction Table
            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.UpdatedByUser)
                .WithMany()
                .HasForeignKey(t => t.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Transaction>()
                .Property(t => t.Type)
                .HasConversion<string>();
            
            modelBuilder.Entity<Transaction>()
                .Property(t => t.From)
                .HasConversion<string>();
            
            modelBuilder.Entity<Transaction>()
                .Property(t => t.To)
                .HasConversion<string>();
            #endregion

            #region Advertisement Table
            // CreatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Advertisement>()
                .HasOne(a => a.CreatedByUser)
                .WithMany()
                .HasForeignKey(a => a.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // Navigation Properties
            modelBuilder.Entity<Advertisement>()
                .HasMany(a => a.AdWatches)
                .WithOne(a => a.Advertisement)
                .HasForeignKey(a => a.AdId)
                .OnDelete(DeleteBehavior.Restrict);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Advertisement>()
                .HasOne(a => a.UpdatedByUser)
                .WithMany()
                .HasForeignKey(a => a.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region AdWatch Table
            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<AdWatch>()
                .HasOne(a => a.UpdatedByUser)
                .WithMany()
                .HasForeignKey(a => a.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region Seed Data
            UserRole admin = new UserRole
            {
                Id = Guid.NewGuid(),
                Role = "Admin",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
            };

            UserRole shopOwner = new UserRole
            {
                Id = Guid.NewGuid(),
                Role = "ShopOwner",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
            };

            UserRole customer = new UserRole
            {
                Id = Guid.NewGuid(),
                Role = "Customer",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now
            };

            Town town = new Town
            {
                Id = Guid.NewGuid(),
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                Name = "Narasaraopet"
            };
            modelBuilder.Entity<UserRole>().HasData(admin, shopOwner, customer);
            modelBuilder.Entity<Town>().HasData(town);

            modelBuilder.Entity<CoinsContainer>().HasData(
                new CoinsContainer
                {
                    Id = Guid.NewGuid(),
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    TownId = town.Id,
                    Coins = 0
                }
            );

            modelBuilder.Entity<TransientCoinsContainer>().HasData(
                new TransientCoinsContainer
                {
                    Id = Guid.NewGuid(),
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    TownId = town.Id,
                    Coins = 0
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Bala Venkata Rama Sai",
                    LastName = "Immadisetty",
                    PhoneNumber = "7382755402",
                    Email = "ibvramasai1563@gmail.com",
                    PasswordHash = "1234567890",
                    Address = "Barampet",
                    TownId = town.Id,
                    UserRoleId = admin.Id,
                    ProfilePic = "Pic1",
                    Coins = 0,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now
                }
            );
            #endregion
        }
    }
}