using Microsoft.EntityFrameworkCore;

namespace FundRaiser_Team1.Models
{
    public class FundRaiserDbContext: DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Package> Package { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=FundRaiserDB;User= sa; password= admin!@#123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
            .HasMany(a => a.Projects)
            .WithMany(p => p.Users)
            .UsingEntity<ProjectUser>(
            ap => ap.HasOne<Project>().WithMany(),
            ap => ap.HasOne<User>().WithMany()
            )
            .Property(ap => ap.Category);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Package>().ToTable("Package");


            modelBuilder.Entity<User>()
                .HasIndex(user => user.Email)
                .IsUnique();

            

        }

    }
}
