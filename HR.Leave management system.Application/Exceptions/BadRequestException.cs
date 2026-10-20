using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.Execeptions
{
    public class BadRequestException :ApplicationException
    {
        public BadRequestException (string message) : base(message)
        {

        }
    }
}
