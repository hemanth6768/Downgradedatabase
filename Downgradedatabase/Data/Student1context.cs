using Downgradedatabase.Model;
using Microsoft.EntityFrameworkCore;

namespace Downgradedatabase.Data
{
    public class Student1context:DbContext
    {
        public Student1context(DbContextOptions<Student1context> options):base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
        }


        public DbSet<Student1> student1 { get; set; }
    }
}
