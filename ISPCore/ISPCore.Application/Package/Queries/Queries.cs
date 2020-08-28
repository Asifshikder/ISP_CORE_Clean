using ISPCore.Application.Package.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Package.Queries
{
    public static class Queries
    {
        public class GetPackageList : IRequest<List<PackageVM>>
        {
        }
        public class GetPackage : IRequest<PackageVM>
        {
            public int Id { get; set; }
        }
    }
}
