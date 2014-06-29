using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AltaCancha.Models
{
    public class BookingMatchModel
    {
        public Double Payment { get; set; }
        public int CourtId { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateTimeIn { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateTimeOut { get; set; }
        public List<String> Players { get; set; }

    }
}