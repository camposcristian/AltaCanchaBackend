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
using Microsoft.AspNet.Identity;

namespace AltaCancha.Controllers
{
    [Authorize]
    public class BookingController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET api/Booking
        public IQueryable<Booking> GetBookings()
        {
            return db.Bookings;
        }

        // GET api/Booking/5
        [ResponseType(typeof(Booking))]
        public IHttpActionResult GetBooking(int id)
        {
            Booking booking = db.Bookings.Find(id);
            if (booking == null)
            {
                return NotFound();
            }

            return Ok(booking);
        }

        // PUT api/Booking/5
        public IHttpActionResult PutBooking(int id, Booking booking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != booking.Id)
            {
                return BadRequest();
            }

            db.Entry(booking).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Booking
        [ResponseType(typeof(Booking))]
        public IHttpActionResult PostBooking(BookingMatchModel booking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var players = new List<Player>();
            var selfUser = db.Users.Find(User.Identity.GetUserId());

            players.Add(new Player { State = db.State.Find(5), User = selfUser });


            foreach (var playerId in booking.Players)
            {
                players.Add(new Player { State = db.State.Find(4), User = db.Users.FirstOrDefault(x => x.FbId == playerId) });
            }


            Court court = db.Courts.Find(booking.CourtId);
            court.ScheduledMatches.Add(booking.DateTimeIn);

            int paymentState;
            double paymentValue = court.Price;

            if (booking.Payment == 0)
            {
                paymentState = 1;
            }
            else if (booking.Payment == paymentValue)
            {
                paymentState = 3;
            }
            else paymentState = 2;

            Match match = new Match
            {
                Court = court,
                DateTimeIn = booking.DateTimeIn,
                DateTimeOut = booking.DateTimeOut,
                Players = players
            };

            db.Match.Add(match);
            db.SaveChanges();

            Booking newBook = new Booking
            {
                Match = match,
                User = db.Users.Find(User.Identity.GetUserId()),
                Payment = booking.Payment,
                State = db.State.Find(paymentState)
            };

            db.Bookings.Add(newBook);
            db.SaveChanges();

            foreach (var playerId in booking.Players)
            {
                var usr = db.Users.FirstOrDefault(x => x.FbId == playerId);
                usr.Matches.Add(match);
            }

            selfUser.Matches.Add(match);

            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = newBook.Id }, newBook);
        }

        // DELETE api/Booking/5
        [ResponseType(typeof(Booking))]
        public IHttpActionResult DeleteBooking(int id)
        {
            Booking booking = db.Bookings.Find(id);
            if (booking == null)
            {
                return NotFound();
            }

            db.Bookings.Remove(booking);
            db.SaveChanges();

            return Ok(booking);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BookingExists(int id)
        {
            return db.Bookings.Count(e => e.Id == id) > 0;
        }
    }
}