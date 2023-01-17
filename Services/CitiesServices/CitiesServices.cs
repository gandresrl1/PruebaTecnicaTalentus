using AutoMapper;
using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CitiesServices
{
    public class CitiesServices : ICitiesServices
    {
        private readonly TalentusDB _talentusDB;
        private readonly IMapper _mapper;

        public CitiesServices(TalentusDB talentusDB, IMapper mapper)
        {
            _talentusDB = talentusDB;
            _mapper = mapper;
        }

        public List<CityDTO> GetCitiesByName(string search)
        {
            var listCities = _talentusDB.Cities.Where(_ => _.Name.Contains(search)).ToList();

            return _mapper.Map<List<CityDTO>>(listCities);
        }

        public CityDTO GetCitiesById(int id)
        {
            var city = _talentusDB.Cities.Where(_ => _.CityId == id).FirstOrDefault();

            return _mapper.Map<CityDTO>(city);
        }
    }
}
