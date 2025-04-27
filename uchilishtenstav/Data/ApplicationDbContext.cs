using System.Data.Entity;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

namespace stav.Data
{
    public class ApplicationDbContext : DbContext
    {
       // public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         //   : base(options)
        //{
       // }

        // Your DbSets here
        public DbSet<Property> Properties { get; set; }
        public DbSet<Person> People { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            // Configure your relationships here
           //modelBuilder.Entity<Person>()
                //.HasOne(p => p.RelatedProperty)
                //.WithMany(p => p.People)
                //.HasForeignKey(p => p.RelatedPropertyID)
                //.OnDelete(DeleteBehavior.NoAction);
       // }
    }
}