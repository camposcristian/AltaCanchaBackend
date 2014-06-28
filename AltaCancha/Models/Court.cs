﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltaCancha.Models
{
    public class Court
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public FloorType FloorType { get; set; }
        public SizeType Type { get; set; }
        public List<Photos> Photos { get; set; }

    }
}
