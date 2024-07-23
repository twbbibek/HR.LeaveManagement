using AutoMapper;
using HR.Leavemanagement.Application.DTOs.LeaveAllocation;
using HR.Leavemanagement.Application.DTOs.LeaveRequest;
using HR.Leavemanagement.Application.DTOs.LeaveType;
using HR.Management.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leavemanagement.Application.Profiles
{
    public class MappingProfile : Profile
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
