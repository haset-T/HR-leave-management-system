using AutoMapper;
using HR.Leave_management_system.Application.DTOs.LeaveAllocation;
using HR.Leave_management_system.Application.DTOs.LeaveRequest;
using HR.Leave_management_system.Application.DTOs.LeaveType;
using HR.Leave_management_system.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();

        }
    }
}
