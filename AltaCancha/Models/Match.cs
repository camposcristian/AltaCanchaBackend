using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltaCancha.Models
{
    public class Match
    {
        public int Id { get; set; }
        public Court Court { get; set; }
        public DateTime DateTimeIn { get; set; }
        public DateTime DateTimeOut { get; set; }
        public List<Player> Players { get; set; }
    }
}
