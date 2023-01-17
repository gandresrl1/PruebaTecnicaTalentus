using AutoMapper;
using DAL.ModelDB;
using Entities;

namespace PruebaTecnicaTalentus.API
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<City, CityDTO>().ReverseMap();
        }
    }
}
