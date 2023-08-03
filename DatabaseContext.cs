
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppliedActivity5
{
    

    public class DatabaseContext : DbContext
    {
        private readonly string _databasePath;

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DatabaseContext(string databasePath)
        {
            _databasePath = databasePath;
            Database.EnsureCreated(); // Ensure the database is created and tables are created.
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={_databasePath}");
        }
    }

}
