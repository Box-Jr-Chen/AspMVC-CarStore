namespace project.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using project.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<project.Models.MobileContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(project.Models.MobileContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Cars.AddOrUpdate(c => c.Id,
                new Car { Id = 1001, Brand = "Mercedes", Name = "AMG S63", Price = 145695, ImageUrl = "Mercedes_AMG_S63.jpg", Category = "轎車", Year = 2017, SoldNumber = 120 },
                new Car { Id = 1002, Brand = "Audi", Name = "S8", Price = 116875, ImageUrl = "Audi_S8.jpg", Category = "轎車", Year = 2016, SoldNumber = 200 },
                new Car { Id = 1003, Brand = "BMW", Name = "M3", Price = 66495, ImageUrl = "BMW_M3.jpg", Category = "轎車", Year = 2016, SoldNumber = 85 },
                new Car { Id = 1004, Brand = "AlfaRomeo", Name = "Giulia Quadrifoglio", Price = 73595, ImageUrl = "AlfaRomeo_GiuliaQuadrifoglio.jpg", Category = "轎車", Year = 2015, SoldNumber = 62 },
                new Car { Id = 1005, Brand = "Mercedes", Name = "GLS Class", Price = 68045, ImageUrl = "MercedesBenz_GLS.jpg", Category = "SUV", Year = 2014, SoldNumber = 250 },
                new Car { Id = 1006, Brand = "Porsche", Name = "Cayenne", Price = 60650, ImageUrl = "Porsche_Cayenne.jpg", Category = "SUV", Year = 2017, SoldNumber = 160 },
                new Car { Id = 1007, Brand = "Honda", Name = "CR-V", Price = 24985, ImageUrl = "Honda_CRV.jpg", Category = "SUV", Year = 2017, SoldNumber = 1200 },
                new Car { Id = 1008, Brand = "Bugatti", Name = "Chiron", Price = 2998000, ImageUrl = "Bugatti_Chiron.jpg", Category = "跑車", Year = 2017, SoldNumber = 10 },
                new Car { Id = 1009, Brand = "Lamborghini", Name = "Huracan", Price = 203295, ImageUrl = "Lamborghini_Huracan.jpg", Category = "跑車", Year = 2015, SoldNumber = 30 },
                new Car { Id = 1010, Brand = "Porsche", Name = "718 Boxster", Price = 57050, ImageUrl = "Porsche_718Boxster.jpg", Category = "跑車", Year = 2014, SoldNumber = 49 }
);

        }
    }
}
