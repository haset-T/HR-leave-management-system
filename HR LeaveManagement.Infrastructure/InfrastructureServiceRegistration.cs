using HR.Leave_management_system.Application.Models;
using HR_LeaveManagement.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace HR_LeaveManagement.Infrastructure
{
    public static  class InfrastructureServiceRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSetting"));
            services.AddTransient<EmailSender, EmailSender>();

            return services;
        }
    }
}
