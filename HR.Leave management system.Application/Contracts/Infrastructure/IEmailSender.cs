using HR.Leave_management_system.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leave_management_system.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {

        Task<bool> SendEmail(Email email);
    }
}
