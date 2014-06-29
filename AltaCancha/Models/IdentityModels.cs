using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AltaCancha.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FbId { get; set; }
        public string FbToken { get; set; }
        public List<Match> Matches { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime CreateDate { get; set; }
        public string Position { get; set; }
        public string GameStyle { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime ModDate { get; set; }
        public bool isActive { get; set; }
        public ApplicationUser()
        {
            CreateDate = DateTime.Now;
            ModDate = DateTime.Now;
            Matches = new List<Match>();
        }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Court> Courts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<FloorType> FloorTypes { get; set; }
        public DbSet<SizeType> Type { get; set; }
        public DbSet<OpenTime> OpenTimes { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Match> Match { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            //Configuration.LazyLoadingEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ApplicationUser>().HasMany(t => t.Matches);
            //modelBuilder.Entity<Match>().HasMany(t => t.Players);
            base.OnModelCreating(modelBuilder);

        }
    }
}