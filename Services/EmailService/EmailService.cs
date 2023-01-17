using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Entities;
using Services.CitiesServices;

namespace Services.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;
        private readonly ICitiesServices _citiesServices;

        public EmailService(IConfiguration configuration, ICitiesServices citiesServices)
        {
            _configuration = configuration;
            _citiesServices = citiesServices;
        }

        public void SendEmail(InformationDTO information)
        {
            var fromAddress = new MailAddress(_configuration["mailFrom".ToString()]);
            var toAddress = new MailAddress(_configuration["mailTo".ToString()]);
            string fromPassword = _configuration["mailPassword".ToString()];
            StringBuilder body = new StringBuilder();
            body.Append(_configuration["mailBody"].ToString());
            body.Replace("{persona}", information.Name);
            body.Replace("{email}", information.Email);
            body.Replace("{ciudad}", _citiesServices.GetCitiesById(information.IdCity).Name);
            body.Replace("{fecha}", information.Date.ToString());

            var smtp = new SmtpClient
            {
                Host = "smtp.example.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = "Nuevo registro",
                Body = body.ToString(),
            })
            {
                smtp.Send(message);
            }
        }
    }
}
