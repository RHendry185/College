namespace LocalTheatreAssessment2_RH.Migrations
{
    using Microsoft.AspNet.Identity;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LocalTheatreAssessment2_RH.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LocalTheatreAssessment2_RH.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var passwordHash = new PasswordHasher();
            String password = passwordHash.HashPassword("Secure123!");
            var author1 = new ApplicationUser
            {
                UserName = "rhendry185@gmail.com",
                PasswordHash = "letmein",
                Email = "rhendry185@gmail.com"
            };
        }
    }
}
