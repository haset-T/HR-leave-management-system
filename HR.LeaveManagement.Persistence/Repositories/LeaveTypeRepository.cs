using HR.Leave_management_system.Application.DTOs.LeaveRequest;
using HR.Leave_management_system.Application.Contracts.Persistence;
using HR.Leave_management_system.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveTypeRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;

        }
    

        public Task<bool> Exists(LeaveRequestDto id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Task<LeaveType> leaveType)
        {
            throw new NotImplementedException();
        }
    }
}
