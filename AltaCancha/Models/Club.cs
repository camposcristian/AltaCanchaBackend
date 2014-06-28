﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AltaCancha.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Latitude { get; set; }
        public double Length { get; set; }
        public string Zone { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public float Rating { get; set; }
        public List<Photos> Photos { get; set; }
        public List<Court> Courts { get; set; }
        public List<Amenity> Amenities { get; set; }
        public List<OpenTime> OpenTimes { get; set; }
    }
}