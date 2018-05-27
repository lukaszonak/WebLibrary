using Microsoft.EntityFrameworkCore;
using WebDataLibrary.Entities;

namespace WebServer.WebDataLibrary
{
    public class DatabaseModel : DbContext
    //public class LibraryDBContext : DbContext
    {
        public DatabaseModel(DbContextOptions options) : base(options)
        {
        }

        protected DatabaseModel()
        {
        }

        public DbSet<Position> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cover> Covers { get; set; }
        public DbSet<Hire> Hiteres { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        /*

               protected override void OnModelCreating(DbModelBuilder modelBuilder)
               {

                   base.OnModelCreating(modelBuilder);
                   modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                   modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


                   modelBuilder.Entity<Position>().HasRequired(x => x.Category).WithMany(x => x.Positions).HasForeignKey(x => x.CategoryId).WillCascadeOnDelete(true);
                   modelBuilder.Entity<Position>().HasRequired(g => g.Availability).WithMany(g => g.Positions).HasForeignKey(g => g.AvailabilityId).WillCascadeOnDelete(true);
                   modelBuilder.Entity<Hire>().HasRequired(c => c.Position).WithMany(c => c.Hires).HasForeignKey(c => c.PositionId).WillCascadeOnDelete(false);
                   modelBuilder.Entity<Cover>().HasRequired(r => r.Position).WithMany(r => r.Covers).HasForeignKey(r => r.MediaId).WillCascadeOnDelete(true);

               }
               */




    }
}
