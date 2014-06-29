using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltaCancha.Models
{
    public class Player
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public State State { get; set; }
    }
}
