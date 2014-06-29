using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AltaCancha.Models;
using System.Device.Location;

namespace AltaCancha.Controllers
{
    public class ClubController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET api/Club
        public IHttpActionResult GetClubs(string name = null, double latitude = 100, double longitude = 100, string datetime = null)
        {
            var clubs = db.Clubs.Include("OpenTimes").Include("Amenities").Include("Courts.FloorType").Include("Courts.Type").Include("Photos").AsQueryable<Club>();

            if (datetime != null)
            {
                DateTime fechaHora = Convert.ToDateTime(datetime);
                clubs.Where(p => p.Courts.All(o => o.ScheduledMatches.Any(x => x.Date != fechaHora.Date && x.Hour != fechaHora.Hour))).AsQueryable();

            }

            if (name != null)
            {
                clubs = clubs.Where(c => c.Name.Contains(name));

            }

            if (latitude != 100 && longitude != 100)
            {
                var clubsFiltrados = new List<Club>();

                foreach (var cl in clubs)
                {
                    if (cl.EsMenorQueDosKm(latitude, longitude) < 2000)
                        clubsFiltrados.Add(cl);
                }
                clubs = clubsFiltrados.AsQueryable<Club>();
            }


            if (clubs == null)
            {
                return NotFound();
            }
            return Ok(clubs.ToList());

        }
        // GET api/Club/5
        [ResponseType(typeof(Club))]
        public IHttpActionResult GetClub(int id)
        {
            Club club = db.Clubs.Find(id);
            if (club == null)
            {
                return NotFound();
            }

            return Ok(club);
        }

        // PUT api/Club/5
        //public IHttpActionResult PutClub(int id, Club club)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != club.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(club).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ClubExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST api/Club
        //[ResponseType(typeof(Club))]
        //public IHttpActionResult PostClub(Club club)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Clubs.Add(club);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = club.Id }, club);
        //}

        //// DELETE api/Club/5
        //[ResponseType(typeof(Club))]
        //public IHttpActionResult DeleteClub(int id)
        //{
        //    Club club = db.Clubs.Find(id);
        //    if (club == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Clubs.Remove(club);
        //    db.SaveChanges();

        //    return Ok(club);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool ClubExists(int id)
        //{
        //    return db.Clubs.Count(e => e.Id == id) > 0;
        //}
    }
}