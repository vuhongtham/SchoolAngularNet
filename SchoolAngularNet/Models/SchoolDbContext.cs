using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolAngularNet.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("name=SchoolDBConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SchoolDbContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}