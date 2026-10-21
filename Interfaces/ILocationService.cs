using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface ILocationService
    {
        bool createLocation(Location location);
        bool updateLocation(Location location);
        bool removeLocation(int locationID);
        Location getLocationById(int locationID);
        IEnumerable<Location> getAllLocations();
    }
}
