using AdKartDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdKartInfrastructure
{
    public class AdKartDbContext : DbContext
    {
        public AdKartDbContext(DbContextOptions<AdKartDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> Roles { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Shop> Shops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region User Table
            // Making Phone Number Unique in DataBase
            modelBuilder.Entity<User>()
                .HasIndex(u => u.PhoneNumber)
                .IsUnique();

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

            modelBuilder.Entity<Shop>()
                .HasOne(s => s.Category)
                .WithMany()
                .HasForeignKey(s => s.CategoryId) 
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Shop>()
                .HasOne(s => s.Owner)
                .WithMany()
                .HasForeignKey(s => s.OwnerId)
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

            // This help in deleting all products under a shop, when a shop got deleted
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Shop)
                .WithMany()
                .HasForeignKey(p => p.ShopId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Product>()
                .Property(p => p.MeasuringType)
                .HasConversion<string>();
            #endregion

            #region Cart Table
            // CreatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.CreatedByUser)
                .WithMany()
                .HasForeignKey(c => c.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.UpdatedByUser)
                .WithMany()
                .HasForeignKey(c => c.UpdatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // This help in deleting all products under a shop, when a shop got deleted
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.Shop)
                .WithMany()
                .HasForeignKey(c => c.ShopId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Cart>()
                .Property(c => c.Status)
                .HasConversion<string>();
            #endregion

            //// Seed Data For Users
            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        Id = new Guid(),
            //        FirstName = "Bala Venkata Rama Sai",
            //        LastName = "Immadisetty",
            //        PhoneNumber = "7382755402",
            //        Email = "ibvramasai1563@gmail.com",
            //        PasswordHash = "",
            //        Address = "Barampet",
            //        Town = Town.Narasaraopet,
            //        Role = UserRole.Admin,
            //        ProfilePic = "Pic1",
            //        Coins = 0,
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //    });
        }
    }
}
