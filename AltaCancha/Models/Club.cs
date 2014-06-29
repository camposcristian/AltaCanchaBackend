using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Device.Location;
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
        public double Rating { get; set; }
        public Photos HeaderPhoto { get; set; }
        public virtual List<Photos> Photos { get; set; }
        public virtual List<Court> Courts { get; set; }
        public virtual List<Amenity> Amenities { get; set; }
        public virtual List<OpenTime> OpenTimes { get; set; }

        public virtual double EsMenorQueDosKm(double latitude, double length)
        {
            var sCoord = new GeoCoordinate(latitude, length);
            var eCoord = new GeoCoordinate(this.Latitude, this.Length);

            return sCoord.GetDistanceTo(eCoord);
        }

    }
}