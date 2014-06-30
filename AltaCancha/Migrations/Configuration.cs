namespace AltaCancha.Migrations
{
    using AltaCancha.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
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

            #region Amenities
            /******* AMENITIES  *********/

            var amenity1 = new Amenity { Id = 1, Name = "Wifi" };
            var amenity2 = new Amenity { Id = 2, Name = "Buffete" };
            var amenity3 = new Amenity { Id = 3, Name = "Vestuarios" };

            context.Amenities.AddOrUpdate(
            p => p.Id,
            amenity1,
            amenity2,
            amenity3
            );

            #endregion

            #region FloorType
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
            #endregion

            #region SizeType
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
            #endregion

            #region Schedule
            /**** SCHEDULE ***/

            var schedule1 = new List<DateTime>();
            schedule1.Add(new DateTime(2014, 6, 30, 15, 0, 0));
            schedule1.Add(new DateTime(2014, 6, 30, 17, 0, 0));
            schedule1.Add(new DateTime(2014, 6, 30, 18, 0, 0));

            var schedule2 = new List<DateTime>();
            schedule2.Add(new DateTime(2014, 6, 30, 11, 0, 0));
            schedule2.Add(new DateTime(2014, 6, 30, 12, 0, 0));
            schedule2.Add(new DateTime(2014, 6, 30, 15, 0, 0));

            var schedule3 = new List<DateTime>();
            schedule3.Add(new DateTime(2014, 6, 30, 15, 0, 0));


            var schedule4 = new List<DateTime>();
            schedule4.Add(new DateTime(2014, 6, 30, 17, 0, 0));
            schedule4.Add(new DateTime(2014, 6, 30, 18, 0, 0));

            var schedule5 = new List<DateTime>();
            schedule5.Add(new DateTime(2014, 6, 30, 15, 0, 0));
            schedule5.Add(new DateTime(2014, 6, 30, 18, 0, 0));

            var schedule6 = new List<DateTime>();
            schedule6.Add(new DateTime(2014, 6, 30, 11, 0, 0));
            schedule6.Add(new DateTime(2014, 6, 30, 12, 0, 0));
            schedule6.Add(new DateTime(2014, 6, 30, 14, 0, 0));

            var schedule7 = new List<DateTime>();
            schedule7.Add(new DateTime(2014, 6, 30, 18, 0, 0));
            schedule7.Add(new DateTime(2014, 6, 30, 19, 0, 0));


            var schedule8 = new List<DateTime>();
            schedule8.Add(new DateTime(2014, 6, 30, 17, 0, 0));
            schedule8.Add(new DateTime(2014, 6, 30, 18, 0, 0));
            schedule8.Add(new DateTime(2014, 6, 30, 19, 0, 0));

            var schedule9 = new List<DateTime>();
            schedule9.Add(new DateTime(2014, 6, 30, 20, 0, 0));
            schedule9.Add(new DateTime(2014, 6, 30, 21, 0, 0));

            var schedule10 = new List<DateTime>();
            schedule10.Add(new DateTime(2014, 6, 30, 16, 0, 0));

            var schedule11 = new List<DateTime>();
            schedule11.Add(new DateTime(2014, 6, 30, 16, 0, 0));
            #endregion



            #region Photos
            /***** PHOTOS *****/
            var headerPh1 = new Photos { Id = 1, Src = "http://i.imgur.com/ifFj23S.jpg", Description = "Header Photo from Serrano Corner" };
            var headerPh2 = new Photos { Id = 2, Src = "http://i.imgur.com/vvlqJg0.jpg", Description = "Header Photo from Bethania" };
            var headerPh3 = new Photos { Id = 3, Src = "http://i.imgur.com/xdk0cbw.jpg", Description = "Header Photo from Madero" };
            var headerPh4 = new Photos { Id = 4, Src = "http://i.imgur.com/rb2wxcR.jpg", Description = "Header Photo from Barracas" };
            var headerPh5 = new Photos { Id = 21, Src = "http://i.imgur.com/KEXs782.jpg", Description = "Header Photo from Liniers" };
            var headerPh6 = new Photos { Id = 22, Src = "http://i.imgur.com/csXtXgD.jpg", Description = "Header Photo from Medrano" };

            var headerPh11 = new Photos { Id = 23, Src = "http://i.imgur.com/ifFj23S.jpg", Description = "Header Photo from Serrano Corner" };
            var headerPh21 = new Photos { Id = 24, Src = "http://i.imgur.com/ifFj23S.jpg", Description = "Header Photo from Bethania" };
            var headerPh31 = new Photos { Id = 25, Src = "http://i.imgur.com/ifFj23S.jpg", Description = "Header Photo from Madero" };
            var headerPh41 = new Photos { Id = 26, Src = "http://i.imgur.com/vvlqJg0.jpg", Description = "Header Photo from Barracas" };
            var headerPh51 = new Photos { Id = 27, Src = "http://i.imgur.com/vvlqJg0.jpg", Description = "Header Photo from Liniers" };
            var headerPh61 = new Photos { Id = 28, Src = "http://i.imgur.com/xdk0cbw.jpg", Description = "Header Photo from Medrano" };
            var headerPh71 = new Photos { Id = 29, Src = "http://i.imgur.com/xdk0cbw.jpg", Description = "Header Photo from Medrano" };
            var headerPh81 = new Photos { Id = 30, Src = "http://i.imgur.com/rb2wxcR.jpg", Description = "Header Photo from Medrano" };
            var headerPh91 = new Photos { Id = 31, Src = "http://i.imgur.com/rb2wxcR.jpg", Description = "Header Photo from Medrano" };
            var headerPh92 = new Photos { Id = 32, Src = "http://i.imgur.com/KEXs782.jpg", Description = "Header Photo from Medrano" };
            var headerPh93 = new Photos { Id = 33, Src = "http://i.imgur.com/csXtXgD.jpg", Description = "Header Photo from Medrano" };
            

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
            var photo13 = new Photos { Id = 17, Src = "http://i.imgur.com/ws2AbJs.jpg", Description = "Photo 17" };
            var photo14 = new Photos { Id = 18, Src = "http://i.imgur.com/hcnkBNL.jpg", Description = "Photo 18" };
            var photo15 = new Photos { Id = 19, Src = "http://i.imgur.com/wMtbPzt.jpg", Description = "Photo 19" };
            var photo16 = new Photos { Id = 20, Src = "http://i.imgur.com/rG0ffMj.jpg", Description = "Photo 20" };

            #endregion


            #region Courts
            /******* COURTS  *********/

            var court1 = new Court { Id = 1, Name = "Cancha 1", Description = "Primera Cancha del complejo", Price = 350, FloorType = floor1, ScheduledMatches = schedule1, Type = size1, Photos = new List<Photos> { headerPh11 } };
            var court2 = new Court { Id = 2, Name = "Cancha 2", Description = "Segunda Cancha del complejo", Price = 400, FloorType = floor2, ScheduledMatches = schedule2, Type = size2, Photos = new List<Photos> { headerPh21 } };
            var court3 = new Court { Id = 3, Name = "Cancha Swing", Description = "Buena cancha para f5", Price = 450, FloorType = floor3, ScheduledMatches = schedule3, Type = size1, Photos = new List<Photos> { headerPh31 } };
            var court4 = new Court { Id = 4, Name = "Cancha Grande", Description = "Otra cancha para f5", Price = 400, FloorType = floor3, ScheduledMatches = schedule4, Type = size1, Photos = new List<Photos> { headerPh41} };
            var court5 = new Court { Id = 5, Name = "Cancha para 11", Description = "Cancha profesional", Price = 1000, FloorType = floor1, ScheduledMatches = schedule5, Type = size3, Photos = new List<Photos> { headerPh61 } };
            var court6 = new Court { Id = 6, Name = "Cancha 1", Description = "Primera Cancha", Price = 500, FloorType = floor2, ScheduledMatches = schedule6, Type = size2, Photos = new List<Photos> { headerPh51 } };
            var court7 = new Court { Id = 7, Name = "Cancha 2", Description = "Segunda Cancha", Price = 450, FloorType = floor2, ScheduledMatches = schedule7, Type = size1, Photos = new List<Photos> { headerPh71 } };
            var court8 = new Court { Id = 8, Name = "Cancha 3", Description = "Tercera Cancha", Price = 400, FloorType = floor1, ScheduledMatches = schedule8, Type = size1, Photos = new List<Photos> { headerPh81 } };
            var court9 = new Court { Id = 9, Name = "Cancha 1", Description = "La mejor Cancha", Price = 450, FloorType = floor3, ScheduledMatches = schedule9, Type = size2, Photos = new List<Photos> { headerPh91 } };
            var court10 = new Court { Id = 10, Name = "Cancha 1", Description = "La mejor Cancha", Price = 450, FloorType = floor3, ScheduledMatches = schedule10, Type = size3, Photos = new List<Photos> { headerPh92 } };
            var court11 = new Court { Id = 11, Name = "Cancha 2", Description = "La mejor Cancha", Price = 500, FloorType = floor1, ScheduledMatches = schedule11, Type = size1, Photos = new List<Photos> { headerPh93 } };


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
                court9,
                court10,
                court11
                );

            #endregion


            #region Clubs
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
                Amenities = new List<Amenity> { },
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
                Amenities = new List<Amenity> { amenity2, },
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
                HeaderPhoto = headerPh4,
                Photos = new List<Photos> { photo10, photo11, photo12 }
            };

            var club5 = new Club
            {
                Id = 5,
                Name = "Open Liniers",
                Address = "Medrano 241",
                Phone = "4862-9392/ 9386/ 4865-4057",
                Email = "",
                Latitude = -34.775133,
                Length = -58.476949,
                Zone = "Liniers",
                State = "Ciudad Autonoma de Buenos Aires",
                Country = "Argentina",
                Rating = 2.5,
                Courts = new List<Court> { court10 },
                Amenities = new List<Amenity> { },
                HeaderPhoto = headerPh5,
                Photos = new List<Photos> { photo13, photo14 }
            };


            var club6 = new Club
            {
                Id = 6,
                Name = "Club BPN",
                Address = "Malabia 241",
                Phone = "4862-9392/ 9386/ 4865-4057",
                Email = "",
                Latitude = -34.775133,
                Length = -58.476949,
                Zone = "Liniers",
                State = "Ciudad Autonoma de Buenos Aires",
                Country = "Argentina",
                Rating = 3.5,
                Courts = new List<Court> { court11},
                Amenities = new List<Amenity> { },
                HeaderPhoto = headerPh6,
                Photos = new List<Photos> { photo15, photo16 }
            };

            context.Clubs.AddOrUpdate(
               p => p.Id,
               club1,
               club2,
               club3,
               club4,
               club5,
               club6
               );
            #endregion

            #region State

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
            #endregion

            #region Users
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            //Create User Test
            UserManager.Create(new ApplicationUser()
            {
                UserName = "admin@admin.com",
                FbId = "123456",
                FbToken = "123456",
                GameStyle = "El mago",
                CreateDate = DateTime.Now,
                Position = "9"
            },"123456");

            UserManager.Create(new ApplicationUser()
            {
                UserName = "admin1@admin.com",
                FbId = "1234567",
                FbToken = "1234567",
                GameStyle = "El mago",
                CreateDate = DateTime.Now,
                Position = "9"
            },"123456");


            //Create User=Admin with password=123456
            var user = new ApplicationUser();
            var adminresult = UserManager.Create(user, "123456");

            base.Seed(context);
            #endregion

        }
    }
}
