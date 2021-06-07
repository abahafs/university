using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace university_app.Models
{
    public class univerDbContext : DbContext
    {
        public univerDbContext() : base("universityConnectionString")
        {

        }

        public DbSet<room> rooms{get; set;}
        public DbSet<student> students { get; set; }
        public DbSet<teacher> teachers { get; set; }
        public DbSet<course> courses { get; set; }

    }
}