using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CitiesServices
{
    public interface ICitiesServices
    {
        List<CityDTO> GetCitiesByName(string search);
        CityDTO GetCitiesById(int id);
    }
}
