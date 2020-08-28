using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Distribution_Transaction.Command
{
    public static class Commands
    {
        public static class Distribution_Transaction
        {
            public class Create : IRequest<Distribution_TransactionCommandVM>
            {
                public int StockDetailsID { get; set; }
                public int SectionID { get; set; }
                public int ProductStatusID { get; set; }
                public string ItemName { get; set; }
                public string BrandName { get; set; }
                public string Serial { get; set; }
                public string ClientName { get; set; }
                public string EmployeeName { get; set; }
                public string SectionName { get; set; }
                public string ProductStatus { get; set; }
            }

            public class Update : IRequest<Distribution_TransactionCommandVM>
            {
                public int Id { get; set; }
                public int StockDetailsID { get; set; }
                public int SectionID { get; set; }
                public int ProductStatusID { get; set; }
                public string ItemName { get; set; }
                public string BrandName { get; set; }
                public string Serial { get; set; }
                public string ClientName { get; set; }
                public string EmployeeName { get; set; }
                public string SectionName { get; set; }
                public string ProductStatus { get; set; }
            }

            public class MarkAsDelete : IRequest<Distribution_TransactionCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
