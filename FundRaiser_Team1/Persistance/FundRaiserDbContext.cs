using Microsoft.EntityFrameworkCore;

namespace FundRaiser_Team1.Models
{
    public class FundRaiserDbContext: DbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<Package> Package { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=FundRaiserDB;User= sa; password= admin!@#123");
            //optionsBuilder.UseSqlServer("Data Source=VASILISCHATZIS-\\SQLSERVER2019;Initial Catalog=FundRaiserDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Package>().ToTable("Package");


            modelBuilder.Entity<User>()
                .HasIndex(user => user.Email)
                .IsUnique();

            
        }

    }
}
