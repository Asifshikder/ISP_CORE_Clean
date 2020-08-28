using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Departement.Command
{
    public static class Commands
    {
        public static class Departement
        {
            public class Create : IRequest<DepartementCommandVM>
            {
                public string DepartementName { get; set; }
            }

            public class Update : IRequest<DepartementCommandVM>
            {
                public int Id { get; set; }
                public string DepartementName { get; set; }
            }

            public class MarkAsDelete : IRequest<DepartementCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
