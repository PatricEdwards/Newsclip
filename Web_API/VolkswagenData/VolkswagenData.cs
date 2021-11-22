using System;
using System.Collections.Generic;

namespace Web_API
{
    public interface IVolkswagenData
    {
        List<Models.Vehicle> GetVehicles();

        Models.Vehicle GetVehicle(string Name);

        Boolean AddVehicle(Models.Vehicle iVehicle);

        Boolean RemoveVehicle(string Name);

        Boolean EditVehicle(Models.Vehicle iVehicle);

    }
}
