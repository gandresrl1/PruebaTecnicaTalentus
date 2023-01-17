using DAL.ModelDB;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.CitiesServices;
using Services.EmailService;

namespace PruebaTecnicaTalentus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailServices;
        private readonly ICitiesServices _citiesServices;

        public EmailController(IEmailService emailServices, ICitiesServices citiesServices)
        {
            _emailServices = emailServices;
            _citiesServices = citiesServices;
        }

        [HttpPost]
        public IActionResult SendMail(InformationDTO information) 
        {
            ValidateCity(information.IdCity);
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }

            _emailServices.SendEmail(information);
            return Ok();
        }

        private void ValidateCity(int CityId)
        {
            if (_citiesServices.GetCitiesById(CityId) is null)
            {
                ModelState.AddModelError("search", $"El id de la ciudad no existe: CityId {CityId}");
            }
        }
    }
}
