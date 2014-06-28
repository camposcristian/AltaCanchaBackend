using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltaCancha.Models
{
    public class OpenTime
    {
        public int Id { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }

    }
}
