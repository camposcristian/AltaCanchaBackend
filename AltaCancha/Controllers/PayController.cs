using AltaCancha.Models;
using BitPayAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNet.Identity;
using System.Web.Http;
using AltaCancha.Results;
using System.Web.Http.Description;

namespace AltaCancha.Controllers
{
    [Authorize]
    public class PayController : ApiController
    {
        // POST: api/Pay
        [ResponseType(typeof(Invoice))]
        public IHttpActionResult Post(PayModel payModel)
        {
            using (var db = new ApplicationDbContext())
            {
                var selfUser = db.Users.Find(User.Identity.GetUserId());
                var booking = db.Bookings.Include("Match.Court").FirstOrDefault(p=>p.Id==payModel.BookId);

                if (selfUser == null || selfUser.Id != booking.User.Id)
                {
                    return StatusCode(HttpStatusCode.Unauthorized);
                }

                double price = Convert.ToInt32(booking.Match.Court.Price);
                BitPay bp = new BitPay("RIlRZwnapjwEcBcKrB6b631V3GTRCZ2yKpRtUOg6OPc");
                return Ok(bp.createInvoice(price, "ARS"));
            }


        }

    }
}
