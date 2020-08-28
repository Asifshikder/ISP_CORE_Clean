using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.DirectProductSectionChangeFromWorkingToOthers.Command
{
    public static class Commands
    {
        public static class DirectProductSectionChangeFromWorkingToOthers
        {
            public class Create : IRequest<DirectProductSectionChangeFromWorkingToOthersCommandVM>
            {
                public string ClientName { get; set; }
                public string TakenEmployee { get; set; }
                public int StockDetailsID { get; set; }
                public int FromSection { get; set; }
                public int ToSection { get; set; }
                public string WhoChanged { get; set; }
                public DateTime ChangeDateTime { get; set; }
            }

            public class Update : IRequest<DirectProductSectionChangeFromWorkingToOthersCommandVM>
            {
                public int Id { get; set; }
                public string ClientName { get; set; }
                public string TakenEmployee { get; set; }
                public int StockDetailsID { get; set; }
                public int FromSection { get; set; }
                public int ToSection { get; set; }
                public string WhoChanged { get; set; }
                public DateTime ChangeDateTime { get; set; }
            }

            public class MarkAsDelete : IRequest<DirectProductSectionChangeFromWorkingToOthersCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
