using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Core.Services.EmailServices
{
    public interface IEmailService
    {
        Task SendEmailAsync(string fromName, string fromEmail, string subject, string message);
    }
}
