using HR.Leavemanagement.Application.DTOs;
using HR.Leavemanagement.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leavemanagement.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestDetailRequest : IRequest<List<LeaveRequestDto>>
    {
        public int Id { get; set; }
    }
}
