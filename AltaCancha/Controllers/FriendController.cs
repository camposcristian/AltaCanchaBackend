using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AltaCancha.Controllers
{
    public class FriendController : ApiController
    {
        // GET: api/Friends
        public IEnumerable<string> Get()
        {
            var accessToken = "CAACEdEose0cBAEMrhL35VPGz5qYYGeGXkhTRGiPayK1ZCc4xLQsKuKJihDL6FGflUTx7HWitvCZBrOFKNYAttIIgDh8rH6IdJlS9Ka1rvr1SWW7dT61o2NCR4Als0lR8e0T3lVEy6Hwgw0JeH0NHOdta8I0ZB4HFj8ZBh56IJnG0op7SQXfiqPCffORuDoGls2nZCKPSv8gZDZD";
            var client = new FacebookClient(accessToken);
            dynamic me = client.Get("me");
            string aboutMe = me.about;
            dynamic result = client.Get("me", new { fields = "name,id" });
            return new string[] { me };
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
