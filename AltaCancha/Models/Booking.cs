﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AltaCancha.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public Club Club { get; set; }
        public Court Court { get; set; }
        public DateTime DateTimeIn { get; set; }
        public DateTime DateTimeOut { get; set; }
        public State State { get; set; }
        public Double Payment { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModDate { get; set; }

    }
}