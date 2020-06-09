using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetCourse.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Person> Person { get; set; }

        public DbSet<Car> Car { get; set; }

        public DbSet<Color> Color { get; set; }

        public DbSet<CarColor> CarColors { get; set; }
    }
}