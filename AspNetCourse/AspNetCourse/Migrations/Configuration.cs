namespace AspNetCourse.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetCourse.Models.ApplicationDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AspNetCourse.Models.ApplicationDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Person.AddOrUpdate(x => x.id, new Models.Person()
            {
                id = 0,
                name = "Christofer",
                birthdate = new DateTime(1996,10,05),
                age = 22
            });

            context.Color.AddOrUpdate(x => x.idColor, new Models.Color()
            {
                idColor = 0,
                name = "Blue"
            });

            context.Car.AddOrUpdate(x => x.registrationNumber, new Models.Car() 
            {
                registrationNumber = 11111,
                year = 2000,
                idOwner = 0
            });

            context.CarColors.AddOrUpdate(x => x.idCar, new Models.CarColor()
            {
                idCar = 11111,
                idColor = 0
            });
        }
    }
}
