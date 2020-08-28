using ISPCore.Application.LeaveSalaryType.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.LeaveSalaryType.Queries
{
    public static class Queries
    {
        public class GetLeaveSalaryTypeList : IRequest<List<LeaveSalaryTypeVM>>
        {
        }
        public class GetLeaveSalaryType : IRequest<LeaveSalaryTypeVM>
        {
            public int Id { get; set; }
        }
    }
}
