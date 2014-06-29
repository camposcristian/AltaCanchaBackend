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
    public class MatchController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET api/Match
        public IQueryable<Match> GetMatch()
        {
            return db.Match.Where(a => a.Players.Any(p => p.User.Id == User.Identity.GetUserId())).OrderByDescending(p => p.DateTimeIn);
        }

        //// GET api/Match/5
        [ResponseType(typeof(Match))]
        public IHttpActionResult GetMatch(int id)
        {
            Match match = db.Match.Find(id);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }

        // PUT api/Match/5
        public IHttpActionResult PutMatch(int idMatch, string state)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newState = db.State.FirstOrDefault(x => x.Name == state);
            var match = db.Match.Find(idMatch);

            if (match == null)
                return NotFound();

            foreach (var player in match.Players)
            {
                if (player.User.Id == User.Identity.GetUserId())
                {
                    player.State = newState;
                    break;
                }
            }

            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        //// POST api/Match
        //[ResponseType(typeof(Match))]
        //public IHttpActionResult PostMatch(Match match)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Match.Add(match);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = match.Id }, match);
        //}

        //// DELETE api/Match/5
        //[ResponseType(typeof(Match))]
        //public IHttpActionResult DeleteMatch(int id)
        //{
        //    Match match = db.Match.Find(id);
        //    if (match == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Match.Remove(match);
        //    db.SaveChanges();

        //    return Ok(match);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        private bool MatchExists(int id)
        {
            return db.Match.Count(e => e.Id == id) > 0;
        }
    }
}