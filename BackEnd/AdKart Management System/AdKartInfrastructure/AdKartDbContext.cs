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
                .HasOne(t => t.CreatedByUser)
                .WithMany()
                .HasForeignKey(t => t.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // UpdatedBy relationship (prevent cascade delete)
            modelBuilder.Entity<UserRole>()
                .HasOne(t => t.UpdatedByUser)
                .WithMany()
                .HasForeignKey(t => t.UpdatedBy)
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
