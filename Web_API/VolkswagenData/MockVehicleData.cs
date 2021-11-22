using System;
using System.Collections.Generic;
using System.Linq;
using Web_API.Models;

namespace Web_API.VolkswagenData
{
   

    public class MockVehicleData : IVolkswagenData
    {
        private List<Vehicle> _vehicles = new List<Vehicle>()
        {
            new Vehicle()
            {
                Name = "Polo Sedan",
                Model = "Trendline",
                Price =  257500.00,
                Count=3
            },
            new Vehicle()
            {
                Name = "Polo Vivo Hatch",
                Model = "Comfortline",
                Price =  246000.00 ,
                Count = 4
            }
        };

        public bool AddVehicle(Vehicle iVehicle)
        {
            _vehicles.Add(iVehicle);
            return true;
        }

        public bool EditVehicle(Vehicle iVehicle)
        {
            var vec = GetVehicle(iVehicle.Name);
            vec.Name = iVehicle.Name;
            vec.Model = iVehicle.Model;
            vec.Price = iVehicle.Price;
            vec.Count = iVehicle.Count;
            return true;

        }

        public Vehicle GetVehicle(string Name)
        {
            return _vehicles.SingleOrDefault(n => n.Name == Name);
        }

        public List<Vehicle> GetVehicles()
        {
            return _vehicles;
        }

        public bool RemoveVehicle(string Name)
        {
            _vehicles.Remove(_vehicles.SingleOrDefault(n => n.Name == Name));
            return true;
        }
    }
}
