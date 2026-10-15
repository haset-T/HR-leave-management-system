using HR.Leave_management_system.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Domain
{
    public class LeaveRequest: BaseDomainEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool cancelled { get; set; }
    }
}
