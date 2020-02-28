using IdentityMVC.Models;
using System.Threading.Tasks;

namespace IdentityMVC.Services
{
    public interface IEmailService
    {
        Task SendMailAsync(EmailMessage emailMessage, string internalEmail = null);
    }
}