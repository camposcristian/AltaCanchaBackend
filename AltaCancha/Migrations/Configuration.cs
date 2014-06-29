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
            AutomaticMigrationDataLossAllowed = true;
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

            var amenity1 = new Amenity { Id = 1, Name = "Wifi" };
            var amenity2 = new Amenity { Id = 2, Name = "Buffete"};
            var amenity3 = new Amenity { Id = 3, Name = "Vestuarios"};

            context.Amenities.AddOrUpdate(
    p => p.Id,
    amenity1,
    amenity2,
    amenity3
    );



            /******* FLOORTYPE  *********/

            var floor1 = new FloorType { Id = 1, Name = "Cesped" };
            var floor2 = new FloorType { Id = 2, Name = "Caucho" };
            var floor3 = new FloorType { Id = 3, Name = "Cemento" };

            context.FloorTypes.AddOrUpdate(
                p => p.Id,
                floor1,
                floor2,
                floor3
                );

            /******* SIZETYPE  *********/

            var size1 = new SizeType { Id = 1, Name = "futbol 5" };
            var size2 = new SizeType { Id = 2, Name = "futbol 7" };
            var size3 = new SizeType { Id = 3, Name = "futbol 11" };

            context.Type.AddOrUpdate(
                p => p.Id,
                size1,
                size2,
                size3
                );

            /******* OPENTIME  *********/

            var time0 = new OpenTime { Id = 0, DayOfWeek = "lunes", TimeIn = "8:30", TimeOut = "22:00" };
            var time1 = new OpenTime { Id = 1, DayOfWeek = "martes", TimeIn = "8:30", TimeOut = "22:00" };
            var time2 = new OpenTime { Id = 2, DayOfWeek = "miercoles", TimeIn = "8:30", TimeOut = "22:00" };
            var time3 = new OpenTime { Id = 3, DayOfWeek = "jueves", TimeIn = "8:30", TimeOut = "22:00" };
            var time4 = new OpenTime { Id = 4, DayOfWeek = "viernes", TimeIn = "8:30", TimeOut = "22:00" };
            var time5 = new OpenTime { Id = 5, DayOfWeek = "sabado", TimeIn = "10:00", TimeOut = "19:00" };
            var time6 = new OpenTime { Id = 6, DayOfWeek = "domingo", TimeIn = "8:30", TimeOut = "22:00" };

            var time01 = new OpenTime { Id = 7, DayOfWeek = "lunes", TimeIn = "8:30", TimeOut = "22:00" };
            var time11 = new OpenTime { Id = 8, DayOfWeek = "martes", TimeIn = "8:30", TimeOut = "22:00" };
            var time21 = new OpenTime { Id = 9, DayOfWeek = "miercoles", TimeIn = "8:30", TimeOut = "22:00" };
            var time31 = new OpenTime { Id = 10, DayOfWeek = "jueves", TimeIn = "8:30", TimeOut = "22:00" };
            var time41 = new OpenTime { Id = 11, DayOfWeek = "viernes", TimeIn = "8:30", TimeOut = "22:00" };
            var time51 = new OpenTime { Id = 12, DayOfWeek = "sabado", TimeIn = "10:00", TimeOut = "19:00" };
            var time61 = new OpenTime { Id = 13, DayOfWeek = "domingo", TimeIn = "8:30", TimeOut = "22:00" };

            var time02 = new OpenTime { Id = 14, DayOfWeek = "lunes", TimeIn = "8:30", TimeOut = "22:00" };
            var time12 = new OpenTime { Id = 15, DayOfWeek = "martes", TimeIn = "8:30", TimeOut = "22:00" };
            var time22 = new OpenTime { Id = 16, DayOfWeek = "miercoles", TimeIn = "8:30", TimeOut = "22:00" };
            var time32 = new OpenTime { Id = 17, DayOfWeek = "jueves", TimeIn = "8:30", TimeOut = "22:00" };
            var time42 = new OpenTime { Id = 18, DayOfWeek = "viernes", TimeIn = "8:30", TimeOut = "22:00" };
            var time52 = new OpenTime { Id = 19, DayOfWeek = "sabado", TimeIn = "10:00", TimeOut = "19:00" };
            var time62 = new OpenTime { Id = 20, DayOfWeek = "domingo", TimeIn = "8:30", TimeOut = "22:00" };

            var time03 = new OpenTime { Id = 21, DayOfWeek = "lunes", TimeIn = "8:30", TimeOut = "22:00" };
            var time13 = new OpenTime { Id = 22, DayOfWeek = "martes", TimeIn = "8:30", TimeOut = "22:00" };
            var time23 = new OpenTime { Id = 23, DayOfWeek = "miercoles", TimeIn = "8:30", TimeOut = "22:00" };
            var time33 = new OpenTime { Id = 24, DayOfWeek = "jueves", TimeIn = "8:30", TimeOut = "22:00" };
            var time43 = new OpenTime { Id = 25, DayOfWeek = "viernes", TimeIn = "8:30", TimeOut = "22:00" };
            var time53 = new OpenTime { Id = 26, DayOfWeek = "sabado", TimeIn = "10:00", TimeOut = "19:00" };
            var time63 = new OpenTime { Id = 27, DayOfWeek = "domingo", TimeIn = "8:30", TimeOut = "22:00" };


            context.OpenTimes.AddOrUpdate(
                p => p.Id,
                time0,
                time1,
                time2,
                time3,
                time4,
                time5,
                time6,
                time01,
                time11,
                time21,
                time31,
                time41,
                time51,
                time61,
                time02,
                time12,
                time22,
                time32,
                time42,
                time52,
                time62,
                time03,
                time13,
                time23,
                time33,
                time43,
                time53,
                time63
                );

            /******* COURTS  *********/

            var court1 = new Court { Id = 1, Name = "Cancha 1", Description = "Primera Cancha del complejo", Price = 350, FloorType = floor1, Type = size1, Photos = new List<Photos> { } };
            var court2 = new Court { Id = 2, Name = "Cancha 2", Description = "Segunda Cancha del complejo", Price = 400, FloorType = floor2, Type = size2, Photos = new List<Photos> { } };
            var court3 = new Court { Id = 3, Name = "Cancha Swing", Description = "Buena cancha para f5", Price = 450, FloorType = floor3, Type = size1, Photos = new List<Photos> { } };
            var court4 = new Court { Id = 4, Name = "Cancha Grande", Description = "Otra cancha para f5", Price = 400, FloorType = floor3, Type = size1, Photos = new List<Photos> { } };
            var court5 = new Court { Id = 5, Name = "Cancha para 11", Description = "Cancha profesional", Price = 1000, FloorType = floor1, Type = size3, Photos = new List<Photos> { } };
            var court6 = new Court { Id = 6, Name = "Cancha 1", Description = "Primera Cancha", Price = 500, FloorType = floor2, Type = size2, Photos = new List<Photos> { } };
            var court7 = new Court { Id = 7, Name = "Cancha 2", Description = "Segunda Cancha", Price = 450, FloorType = floor2, Type = size1, Photos = new List<Photos> { } };
            var court8 = new Court { Id = 8, Name = "Cancha 3", Description = "Tercera Cancha", Price = 400, FloorType = floor1, Type = size1, Photos = new List<Photos> { } };
            var court9 = new Court { Id = 9, Name = "Cancha 1", Description = "La mejor Cancha", Price = 450, FloorType = floor3, Type = size2, Photos = new List<Photos> { } };

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


            /***** PHOTOS *****/
            var headerPh1 = new Photos { Id = 1, Src = "http://i.imgur.com/ifFj23S.jpg", Description = "Header Photo from Serrano Corner" };
            var headerPh2 = new Photos { Id = 2, Src = "http://i.imgur.com/vvlqJg0.jpg", Description = "Header Photo from Bethania" };
            var headerPh3 = new Photos { Id = 3, Src = "http://i.imgur.com/xdk0cbw.jpg", Description = "Header Photo from Madero" };
            var headerPh4 = new Photos { Id = 4, Src = "http://i.imgur.com/rb2wxcR.jpg", Description = "Header Photo from Barracas" };

            var photo1 = new Photos { Id = 5, Src = "http://i.imgur.com/rG0ffMj.jpg", Description = "Photo 5" };
            var photo2 = new Photos { Id = 6, Src = "http://i.imgur.com/9wLLibs.jpg", Description = "Photo 6" };
            var photo3 = new Photos { Id = 7, Src = "http://i.imgur.com/hcnkBNL.jpg", Description = "Photo 7" };
            var photo4 = new Photos { Id = 8, Src = "http://i.imgur.com/tj2WUtU.jpg", Description = "Photo 8" };
            var photo5 = new Photos { Id = 9, Src = "http://i.imgur.com/wMtbPzt.jpg", Description = "Photo 9" };
            var photo6 = new Photos { Id = 10, Src = "http://i.imgur.com/j8Kqwur.jpg", Description = "Photo 10" };
            var photo7 = new Photos { Id = 11, Src = "http://i.imgur.com/ws2AbJs.jpg", Description = "Photo 11" };
            var photo8 = new Photos { Id = 12, Src = "http://i.imgur.com/WH1Kf2M.jpg", Description = "Photo 12" };
            var photo9 = new Photos { Id = 13, Src = "http://i.imgur.com/kzCHvjw.jpg", Description = "Photo 13" };
            var photo10 = new Photos { Id = 14, Src = "http://i.imgur.com/CGb1Nx9.jpg", Description = "Photo 14" };
            var photo11 = new Photos { Id = 15, Src = "http://i.imgur.com/8dDTh6H.jpg", Description = "Photo 15" };
            var photo12 = new Photos { Id = 16, Src = "http://i.imgur.com/mxqZTW1.jpg", Description = "Photo 16" };


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
                    HeaderPhoto = headerPh1,
                    Photos = new List<Photos> { photo1, photo2, photo3 }
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
                Amenities = new List<Amenity> {  },
                OpenTimes = new List<OpenTime> { time01, time11, time21, time31, time41, time51, time61 },
                HeaderPhoto = headerPh2,
                Photos = new List<Photos> { photo4, photo5, photo6 }
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
                Courts = new List<Court> { court5, court7 },
                Amenities = new List<Amenity> { amenity2,},
                OpenTimes = new List<OpenTime> { time02, time12, time22, time32, time42, time52, time62 },
                HeaderPhoto = headerPh3,
                Photos = new List<Photos> { photo7, photo8, photo9 }
            };

            var club4 = new Club
            {
                Id = 4,
                Name = "Open Barracas",
                Address = "Barracas 241",
                Phone = "4862-9392/ 9386/ 4865-4057",
                Email = "",
                Latitude = -34.655133,
                Length = -58.376949,
                Zone = "Barracas",
                State = "Ciudad Autonoma de Buenos Aires",
                Country = "Argentina",
                Rating = 2.1,
                Courts = new List<Court> { court8, court9 },
                Amenities = new List<Amenity> { amenity3 },
                OpenTimes = new List<OpenTime> { time03, time13, time23, time33, time43, time53, time63 },
                HeaderPhoto = headerPh4,
                Photos = new List<Photos> {  photo10, photo11, photo12}
            };

                      
            context.Clubs.AddOrUpdate(
               p => p.Id,
               club1,
               club2,
               club3,
               club4
               );



            /******* STATE  *********/

            var state1 = new State { Id = 1, Name = "No Pago" };
            var state2 = new State { Id = 2, Name = "Reservado" };
            var state3 = new State { Id = 3, Name = "Pago" };

            var state4 = new State { Id = 4, Name = "En espera" };
            var state5 = new State { Id = 5, Name = "Asistire" };
            var state6 = new State { Id = 6, Name = "En duda" };
            var state7 = new State { Id = 7, Name = "No asistire" };

            context.State.AddOrUpdate(
                p => p.Id,
                state1,
                state2,
                state3,
                state4,
                state5,
                state6,
                state7
                );

        }
    }
}
