using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientLineStatus.Command
{
    public static class Commands
    {
        public static class ClientLineStatus
        {
            public class Create : IRequest<ClientLineStatusCommandVM>
            {
                public int ClientDetailsID { get; set; }
                public int? PackageID { get; set; }
                public int LineStatusID { get; set; }
                public int? LineStatusFromWhichMonth { get; set; }
                public string StatusChangeReason { get; set; }
                public DateTime? LineStatusChangeDate { get; set; }
                public int? EmployeeID { get; set; }
                public int? ResellerID { get; set; }
                public int? MikrotikID { get; set; }
                public bool IsLineStatusApplied { get; set; }
                public DateTime? LineStatusWillActiveInThisDate { get; set; }
                public bool StatusFromNow { get; set; }


                public int StatusThisMonth { get; set; }
                public int StatusNextMonth { get; set; }

                public int PackageThisMonth { get; set; }
                public int PackageNextMonth { get; set; }
            }

            public class Update : IRequest<ClientLineStatusCommandVM>
            {
                public int Id { get; set; }
                public int ClientDetailsID { get; set; }
                public int? PackageID { get; set; }
                public int LineStatusID { get; set; }
                public int? LineStatusFromWhichMonth { get; set; }
                public string StatusChangeReason { get; set; }
                public DateTime? LineStatusChangeDate { get; set; }
                public int? EmployeeID { get; set; }
                public int? ResellerID { get; set; }
                public int? MikrotikID { get; set; }
                public bool IsLineStatusApplied { get; set; }
                public DateTime? LineStatusWillActiveInThisDate { get; set; }
                public bool StatusFromNow { get; set; }
                public int StatusThisMonth { get; set; }
                public int StatusNextMonth { get; set; }
                public int PackageThisMonth { get; set; }
                public int PackageNextMonth { get; set; }
            }

            public class MarkAsDelete : IRequest<ClientLineStatusCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
