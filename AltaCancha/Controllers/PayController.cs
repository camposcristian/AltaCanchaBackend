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
            if (!User.Identity.IsAuthenticated)
            {
                return StatusCode(HttpStatusCode.Unauthorized);
            }

            else
            {
                using (var db = new ApplicationDbContext())
                {
                    double price = Convert.ToInt32(db.Bookings.Find(payModel.BookId).Match.Court.Price);
                    BitPay bp = new BitPay("RIlRZwnapjwEcBcKrB6b631V3GTRCZ2yKpRtUOg6OPc");
                    return Ok(bp.createInvoice(price, "ARS"));
                }
            }


        }

    }
}
