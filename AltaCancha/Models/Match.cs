using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltaCancha.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public Booking Book { get; set; }
        public List<ApplicationUser> Players { get; set; }
    }
}
