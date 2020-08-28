using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Client_Stock_StockDetails.Command
{
    public static class Commands
    {
        public static class Client_Stock_StockDetails
        {
            public class Create : IRequest<Client_Stock_StockDetailsCommandVM>
            {
                public int StockID { get; set; }
                public int StockDetailsID { get; set; }
                public int ItemID { get; set; }
                public string ItemName { get; set; }
                public int BrandID { get; set; }
                public string BrandName { get; set; }
                public int SupplierID { get; set; }
                public string SupplierName { get; set; }
                public string SupplierInvoice { get; set; }
                public string Serial { get; set; }
                public bool WarrentyProduct { get; set; }
            }

            public class Update : IRequest<Client_Stock_StockDetailsCommandVM>
            {
                public int Id { get; set; }
                public int StockID { get; set; }
                public int StockDetailsID { get; set; }
                public int ItemID { get; set; }
                public string ItemName { get; set; }
                public int BrandID { get; set; }
                public string BrandName { get; set; }
                public int SupplierID { get; set; }
                public string SupplierName { get; set; }
                public string SupplierInvoice { get; set; }
                public string Serial { get; set; }
                public bool WarrentyProduct { get; set; }
            }

            public class MarkAsDelete : IRequest<Client_Stock_StockDetailsCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
