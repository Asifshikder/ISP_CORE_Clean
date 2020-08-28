using ISPCore.Application.Departement.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Departement.Queries
{
    public static class Queries
    {
        public class GetDepartementList : IRequest<List<DepartementVM>>
        {
        }
        public class GetDepartement : IRequest<DepartementVM>
        {
            public int Id { get; set; }
        }
    }
}
