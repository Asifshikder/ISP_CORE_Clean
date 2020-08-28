using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.StockDetails.Command
{
    public static class Commands
    {
        public static class StockDetails
        {
            public class Create : IRequest<StockDetailsCommandVM>
            {

                public int StockID { get; set; }
                public int? BrandID { get; set; }
                public int SectionID { get; set; }
                public int? SupplierID { get; set; }
                public string SupplierInvoice { get; set; }
                public string Serial { get; set; }
                public string BarCode { get; set; }
                public int ProductStatusID { get; set; }
                public bool WarrentyProduct { get; set; }
            }

            public class Update : IRequest<StockDetailsCommandVM>
            {
                public int Id { get; set; }
                public int StockID { get; set; }
                public int? BrandID { get; set; }
                public int SectionID { get; set; }
                public int? SupplierID { get; set; }
                public string SupplierInvoice { get; set; }
                public string Serial { get; set; }
                public string BarCode { get; set; }
                public int ProductStatusID { get; set; }
                public bool WarrentyProduct { get; set; }
            }

            public class MarkAsDelete : IRequest<StockDetailsCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
