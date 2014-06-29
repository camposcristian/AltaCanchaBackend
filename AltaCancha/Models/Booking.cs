using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AltaCancha.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public State State { get; set; }
        public Double Payment { get; set; }
        public ApplicationUser User { get; set; }
        public Match Match { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModDate { get; set; }

    }
}