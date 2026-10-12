using HR.Leave_management_system.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Domain
{
   public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set;}
        public int DefaultDays { get; set; }

    }
}
