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
        public IHttpActionResult GetClubs(string name = null)
        {
            if(name == null)
                
                return Ok(db.Clubs.Include("OpenTimes").Include("Amenities").Include("Courts.FloorType").Include("Courts.Type").Include("Photos").ToList());

            var clubs = db.Clubs.Include("OpenTimes").Include("Amenities").Include("Courts.FloorType").Include("Courts.Type").Include("Photos").Where(c => c.Name.Contains(name)).ToList();

            if (clubs == null)
            {
                return NotFound();
            }

            return Ok(clubs);
        }

        // GET api/Club
        public IHttpActionResult GetClubs(double latitude, double length)
        {

            var clubs = db.Clubs.Include("OpenTimes").Include("Amenities").Include("Courts.FloorType").Include("Courts.Type").Include("Photos").ToList();
            if (clubs != null)
            {
                var clubsFiltrados = new List<Club>();

                foreach (var cl in clubs)
                {
                    if (cl.EsMenorQueDosKm(latitude, length) < 2000)
                        clubsFiltrados.Add(cl);
                }



                if (clubsFiltrados.Count == 0)
                {
                    return NotFound();
                }

                return Ok(clubsFiltrados);
            }
            return NotFound();
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