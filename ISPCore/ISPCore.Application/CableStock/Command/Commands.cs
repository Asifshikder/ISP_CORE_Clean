using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.CableStock.Command
{
    public static class Commands
    {
        public static class CableStock
        {
            public class Create : IRequest<CableStockCommandVM>
            {
                public int CableTypeID { get; set; }
                public int? BrandID { get; set; }
                public int? SupplierID { get; set; }
                public string SupplierInvoice { get; set; }
                public int FromReading { get; set; }
                public int ToReading { get; set; }
                public int CableUnitID { get; set; }
                public string CableBoxName { get; set; }
                public int CableQuantity { get; set; }
                public int UsedQuantityFromThisBox { get; set; }
                public int? TotallyUsed { get; set; }
                public int EmployeeID { get; set; }
                public int IndicatorStatus { get; set; }
            }

            public class Update : IRequest<CableStockCommandVM>
            {
                public int Id { get; set; }
                public int CableTypeID { get; set; }
                public int? BrandID { get; set; }
                public int? SupplierID { get; set; }
                public string SupplierInvoice { get; set; }
                public int FromReading { get; set; }
                public int ToReading { get; set; }
                public int CableUnitID { get; set; }
                public string CableBoxName { get; set; }
                public int CableQuantity { get; set; }
                public int UsedQuantityFromThisBox { get; set; }
                public int? TotallyUsed { get; set; }
                public int EmployeeID { get; set; }
                public int IndicatorStatus { get; set; }
            }

            public class MarkAsDelete : IRequest<CableStockCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
