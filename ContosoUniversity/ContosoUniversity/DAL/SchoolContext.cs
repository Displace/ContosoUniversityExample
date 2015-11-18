//Notes: The main class that coordinates Entity Framework functionality 
//for a given data model is the database context class. You create this 
//class by deriving from the System.Data.Entity.DbContext class.
using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Prevents table names from being pluralized
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}