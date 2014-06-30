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
        public List<Match> GetMatch()
        {
            string currentUserId = User.Identity.GetUserId();
            ApplicationUser currentUser = db.Users.FirstOrDefault(x => x.Id == currentUserId);
            List<Match> matches = db.Match.Include("Players.State").Include("Court.Photos").Where(a => a.Players.Any(p => p.User.Id == currentUser.Id)).OrderByDescending(p => p.DateTimeIn).ToList();
            return matches;
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
            var match = db.Match.Include("Players.User").FirstOrDefault(p => p.Id == idMatch);

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

        // POST api/Match
        [ResponseType(typeof(Match))]
        public IHttpActionResult PostMatch(List<string> FbIds, int MatchId )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var state = db.State.Find(4);
            var match = db.Match.Find(MatchId);

            foreach(var fbId in FbIds)
            {
                var usr = db.Users.FirstOrDefault(p => p.FbId == fbId);
                if(usr != null)
                {
                    match.Players.Add(new Player { User = usr, State = state });
                }
            }
            
            db.SaveChanges();

            return Ok();
        }

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