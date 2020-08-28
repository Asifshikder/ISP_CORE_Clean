using ISPCore.Application.Employee.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Employee.Queries
{
    public static class Queries
    {
        public class GetEmployeeList : IRequest<List<EmployeeVM>>
        {
        }
        public class GetEmployee : IRequest<EmployeeVM>
        {
            public int Id { get; set; }
        }
    }
}
