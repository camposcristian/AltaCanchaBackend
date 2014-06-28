namespace AltaCancha.Migrations
{
    using AltaCancha.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AltaCancha.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AltaCancha.Models.ApplicationDbContext context)
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


            /******* AMENITIES  *********/

            var amenity1 = new Amenity { Id = 1, Name = "Wifi"};
             var amenity2 = new Amenity { Id = 2, Name = "Buffete"};
             var amenity3 = new Amenity { Id = 3, Name = "Vestuarios"};
            
            context.Amenities.AddOrUpdate(
                p => p.Id,
                amenity1,
                amenity2,
                amenity3
                );

            /******* FLOORTYPE  *********/

             var floor1 = new FloorType { Id = 1, Name = "Cesped"};
             var floor2 = new FloorType { Id = 2, Name = "Caucho"};
             var floor3 = new FloorType { Id = 3, Name = "Cemento"};
            
            context.FloorTypes.AddOrUpdate(
                p => p.Id,
                floor1,
                floor2,
                floor3
                );

            /******* SIZETYPE  *********/

             var size1 = new SizeType { Id = 1, Name = "futbol 5"};
             var size2 = new SizeType { Id = 2, Name = "futbol 7"};
             var size3 = new SizeType { Id = 3, Name = "futbol 11"};
            
            context.Type.AddOrUpdate(
                p => p.Id,
                size1,
                size2,
                size3
                );

            /******* OPENTIME  *********/

            var time0 = new OpenTime { Id = 0, DayOfWeek = "lunes", TimeIn = "8:30", TimeOut = "22:00"};
            var time1 = new OpenTime { Id = 1, DayOfWeek = "martes", TimeIn = "8:30", TimeOut = "22:00"};
            var time2 = new OpenTime { Id = 2, DayOfWeek = "miercoles", TimeIn = "8:30", TimeOut = "22:00"};
            var time3 = new OpenTime { Id = 3, DayOfWeek = "jueves", TimeIn = "8:30", TimeOut = "22:00"};
            var time4 = new OpenTime { Id = 4, DayOfWeek = "viernes", TimeIn = "8:30", TimeOut = "22:00"};
            var time5 = new OpenTime { Id = 5, DayOfWeek = "sabado", TimeIn = "10:00", TimeOut = "19:00"};
            var time6 = new OpenTime { Id = 6, DayOfWeek = "domingo", TimeIn = "8:30", TimeOut = "22:00"};

            
            context.OpenTimes.AddOrUpdate(
                p => p.Id,
                time0,
                time1,
                time2,
                time3,
                time4,
                time5,
                time6
                );

         /******* COURTS  *********/

             var court1 = new Court { Id = 1, Name = "Cancha 1", Description = "Primera Cancha del complejo", Price = 350, FloorType = floor1, Type = size1, Photos = new List<Photos> {} };
             var court2 = new Court { Id = 2, Name = "Cancha 2", Description = "Segunda Cancha del complejo", Price = 400, FloorType = floor2, Type = size2, Photos = new List<Photos> {}};
             var court3 = new Court { Id = 3, Name = "Cancha Swing", Description = "Buena cancha para f5", Price = 450, FloorType = floor3, Type = size1, Photos = new List<Photos> {}};
             var court4 = new Court { Id = 1, Name = "Cancha Grande", Description = "Otra cancha para f5", Price = 400, FloorType = floor3, Type = size1, Photos = new List<Photos> {}};
             var court5 = new Court { Id = 2, Name = "Cancha para 11", Description = "Cancha profesional", Price = 1000, FloorType = floor1, Type = size3, Photos = new List<Photos> {}};
             var court6 = new Court { Id = 3, Name = "Cancha 1", Description = "Primera Cancha", Price = 500, FloorType = floor2, Type = size2, Photos = new List<Photos> {}};
             var court7 = new Court { Id = 1, Name = "Cancha 2", Description = "Segunda Cancha", Price = 450, FloorType = floor2, Type = size1, Photos = new List<Photos> {}};
             var court8 = new Court { Id = 2, Name = "Cancha 3", Description = "Tercera Cancha", Price = 400, FloorType = floor1, Type = size1, Photos = new List<Photos> {}};
             var court9 = new Court { Id = 3, Name = "Cancha 1", Description = "La mejor Cancha", Price = 450, FloorType = floor3, Type = size2, Photos = new List<Photos> {}};
            
            context.Courts.AddOrUpdate(
                p => p.Id,
                court1,
                court2,
                court3,
                court4,
                court5,
                court6,
                court7,
                court8,
                court9
                );

            /******* CLUBS  *********/
            var club1 = new Club
                {
                    Id = 1,
                    Name = "Serrano Corner",
                    Address = "Serrano 250",
                    Phone = "4856-7631 / 5771 ",
                    Email = "",
                    Latitude = -34.597677,
                    Length = -58.444068,
                    Zone = "Villa Crespo",
                    State = "Ciudad Autonoma de Buenos Aires",
                    Country = "Argentina",
                    Rating = 3.8,
                    Courts = new List<Court> { court1, court2, court3 },
                    Amenities = new List<Amenity> { amenity1 },
                    OpenTimes = new List<OpenTime> { time0, time1, time2, time3, time4, time5, time6 },
                    Photos = new List<Photos> { }
                };


            var club2 = new Club
            {
                Id = 2,
                Name = "Bethania",
                Address = "Humahuaca 4556",
                Phone = "4865-5027 / 1544459892  ",
                Email = "",
                Latitude = -34.601104,
                Length = -58.429306,
                Zone = "Villa Crespo",
                State = "Ciudad Autonoma de Buenos Aires",
                Country = "Argentina",
                Rating = 4.2,
                Courts = new List<Court> { court4, court6 },
                Amenities = new List<Amenity> { amenity2, amenity3 },
                OpenTimes = new List<OpenTime> { time0, time1, time2, time3, time4, time5, time6 },
                Photos = new List<Photos> { }
            };


            var club3 = new Club
            {
                Id = 3,
                Name = "Futbol Madero",
                Address = "Elvira Rawson de Dellepiane 340",
                Phone = "4314 - 4237 / 4311 - 3980 ",
                Email = "",
                Latitude = -34.568846,
                Length = 58.398492,
                Zone = "Puerto Madero",
                State = "Ciudad Autonoma de Buenos Aires",
                Country = "Argentina",
                Rating = 5,
                Courts = new List<Court> { court3, court4 , court5, court6},
                Amenities = new List<Amenity> { amenity1,amenity2, amenity3 },
                OpenTimes = new List<OpenTime> { time0, time1, time2, time3, time4, time5, time6 },
                Photos = new List<Photos> { }
            };

            var club4 = new Club
            {
                Id = 4,
                Name = "Open Gallo",
                Address = "Gallo 241",
                Phone = "4862-9392/ 9386/ 4865-4057",
                Email = "",
                Latitude = -34.605943,
                Length = -58.414114,
                Zone = "Almagro",
                State = "Ciudad Autonoma de Buenos Aires",
                Country = "Argentina",
                Rating = 2.1,
                Courts = new List<Court> { court8, court9, court7 },
                Amenities = new List<Amenity> { amenity3 },
                OpenTimes = new List<OpenTime> { time0, time1, time2, time3, time4, time5, time6 },
                Photos = new List<Photos> { }
            };


            context.Clubs.AddOrUpdate(
                p => p.Id,
                club1,
                club2,
                club3,
                club4
                );
        }
    }
}
