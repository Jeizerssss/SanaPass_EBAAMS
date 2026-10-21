using SanaPass_EBAAMS.Interfaces;
using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository ?? throw new ArgumentNullException(nameof(locationRepository));
        }

        public bool createLocation(Location location)
        {
            if (location == null || string.IsNullOrWhiteSpace(location.lName))
                return false;

            return _locationRepository.add(location);
        }

        public bool updateLocation(Location location)
        {
            if (location == null || location.locationID <= 0)
                return false;

            return _locationRepository.update(location);
        }

        public bool removeLocation(int locationID)
        {
            return _locationRepository.delete(locationID);
        }

        public Location getLocationById(int locationID)
        {
            return _locationRepository.getById(locationID);
        }

        public IEnumerable<Location> getAllLocations()
        {
            return _locationRepository.getAll();
        }
    }
}
