using AltaCancha.Models;
using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNet.Identity;
using System.Web.Http;

namespace AltaCancha.Controllers
{
    public class FriendController : ApiController
    {
        // GET: api/Friends
        public IDictionary<string, object> Get()
        {
            using (var db = new ApplicationDbContext())
            {
                ApplicationUser user = db.Users.FirstOrDefault(u => u.Id == User.Identity.GetUserId());
                var accessToken = user.FbToken;
                var token = GetExtendedAccessToken(accessToken);
                var client = new FacebookClient(token);
                return client.Get("me/friends?fields=picture.type(normal),first_name,birthday,last_name") as IDictionary<string, object>;
            }

        }
        private string GetExtendedAccessToken(string ShortLivedToken)
        {
            FacebookClient client = new FacebookClient();
            string extendedToken = "";
            try
            {
                dynamic result = client.Get("/oauth/access_token", new
                {
                    grant_type = "fb_exchange_token",
                    client_id = "516972428430807",
                    client_secret = "b3ddcb3388562413d2e8bcd3846c8187",
                    fb_exchange_token = ShortLivedToken
                });
                extendedToken = result.access_token;
            }
            catch
            {
                extendedToken = ShortLivedToken;
            }
            return extendedToken;
        }

        // GET: api/Friends/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Friends
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Friends/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Friends/5
        public void Delete(int id)
        {
        }
    }
}
