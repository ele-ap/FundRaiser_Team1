using Microsoft.EntityFrameworkCore;

namespace FundRaiser_Team1.Models
{
    public class FundRaiserDbContext: DbContext
    {
        public DbSet<Creator> Creator { get; set; }
        public DbSet<Backer> Backer { get; set; }
        public DbSet<CreatorAndBacker> CreatorAndBacker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=FundRaiserDB;User= sa; password= admin!@#123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Creator>().ToTable("Creator");
            modelBuilder.Entity<Backer>().ToTable("Backer");
            modelBuilder.Entity<CreatorAndBacker>().ToTable("CreatorAndBacker");

            modelBuilder.Entity<Creator>()
                .HasIndex(creator => creator.Email)
                .IsUnique();

            modelBuilder.Entity<Backer>()
                .HasIndex(backer => backer.Email)
                .IsUnique();

            modelBuilder.Entity<CreatorAndBacker>()
                .HasIndex(creatorbacker => creatorbacker.Email)
                .IsUnique();
        }

    }
}
