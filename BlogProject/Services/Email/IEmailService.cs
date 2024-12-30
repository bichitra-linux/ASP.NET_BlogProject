using System.Threading.Tasks;

namespace BlogProject.Services.Email
{
    public interface IEmailService
    {
        Task SendEmail(string email, string subject, string message);
    }
}