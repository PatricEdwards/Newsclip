using System;
using System.Collections.Generic;
namespace Web_API.Models

{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public List<Feature> Features { get; set; }
        public double Price { get; set; }

        public int Count { get; set; }

    }
}
