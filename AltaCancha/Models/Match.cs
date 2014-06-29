using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace AltaCancha.Models
{
    public class Match
    {
        public int Id { get; set; }
        public Court Court { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateTimeIn { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateTimeOut { get; set; }
        public List<Player> Players { get; set; }
    }
}
