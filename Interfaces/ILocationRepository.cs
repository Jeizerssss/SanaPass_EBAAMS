using SanaPass_EBAAMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaPass_EBAAMS.Interfaces
{
    public interface ILocationRepository : ICrudRepository<Location, int>
    {
        Location getByName(string lName);
    }
}
