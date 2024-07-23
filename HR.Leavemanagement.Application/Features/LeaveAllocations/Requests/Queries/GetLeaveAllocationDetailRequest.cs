using HR.Leavemanagement.Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leavemanagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest :  IRequest<List<LeaveAllocationDto>>
    {
        public int Id { get; set; }
    }
}
