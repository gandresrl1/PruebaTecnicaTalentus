using Microsoft.AspNetCore.Mvc;
using Services.CitiesServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnicaTalentus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICitiesServices _citiesServices;

        public CitiesController(ICitiesServices citiesServices) 
        {
            _citiesServices = citiesServices;
        }

        [HttpGet]
        public ActionResult SearchCities(string search) 
        {
            if (ModelState.IsValid)
            {
                return Ok(_citiesServices.GetCitiesByName(search).ToList());
            }
            return BadRequest(ModelState);
        }
    }
}
