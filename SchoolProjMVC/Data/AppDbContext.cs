using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SchoolProjMVC.Models;

namespace SchoolProjMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // DbSets: Teachers, Pupils, Classes and Courses
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Pupil> Pupils { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<Course> Courses { get; set; }  

       
        

        // Add new instances of entities in the method below. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { 
                    FirstName = "Berit", 
                    LastName = "Torstensson" 
                }
            );

            modelBuilder.Entity<Pupil>().HasData(
                new Pupil {
                    FirstName = "Ismet",
                    LastName = "Catovic",
                    BirthDate = new DateTime(1999, 07, 29),
                    Address = "Bäckedalsgatan 69",
                    PostalCode = 52233,
                    Residence = "Tidaholm",
                    Mail = "ismetcatovic@hotmail.se" 
                }
             );

            // Improvement: Made the code more readable.

            modelBuilder.Entity<Pupil>().HasData(new Pupil { FirstName = "Lamija", LastName = "Catovic", BirthDate = new DateTime(1995, 07, 23), Address = "Lundenvägen 37C", PostalCode = 54139, Residence = "Skövde", Mail = "lamijacatovic@hotmail.se" });

            modelBuilder.Entity<Pupil>().HasData(new Pupil { FirstName = "Avdo", LastName = "Pajo", BirthDate = new DateTime(1999, 10, 02), Address = "Torggatan 15C", PostalCode = 59832, Residence = "Hova", Mail = "avdopajo@hotmail.se" });





        }
    }
}
