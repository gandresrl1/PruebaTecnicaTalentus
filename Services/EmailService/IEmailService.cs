using Entities;

namespace Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(InformationDTO information);
    }
}