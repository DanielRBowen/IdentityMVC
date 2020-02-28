using IdentityMVC.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMVC.Services
{
    public class EmailService : IEmailService
    {
        private readonly ILogger _logger;

        public EmailService(ILogger<IEmailService> logger)
        {
            _logger = logger;
        }

        public async Task SendMailAsync(EmailMessage emailMessage, string internalEmail = null)
        {

        }
    }
}
