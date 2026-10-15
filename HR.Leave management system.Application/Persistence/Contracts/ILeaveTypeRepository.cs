using HR.Leave_management_system.Application.DTOs.LeaveRequest;
using HR.Leave_management_system.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leave_management_system.Application.Persistence.Contracts
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        Task<bool> Exists(LeaveRequestDto id);
        Task Update(Task<LeaveType> leaveType);
    }
}
