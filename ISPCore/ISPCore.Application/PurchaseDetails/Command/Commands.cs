using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PurchaseDetails.Command
{
    public static class Commands
    {
        public static class PurchaseDetails
        {
            public class Create : IRequest<PurchaseDetailsCommandVM>
            {
                public int PurchaseID { get; set; }
                public int ItemID { get; set; }
                public double Quantity { get; set; }
                public double Price { get; set; }
                public double Tax { get; set; }
                public bool HasWarrenty { get; set; }
                public DateTime? WarrentyStart { get; set; }
                public DateTime? WarrentyEnd { get; set; }
                public string Serial { get; set; }
            }

            public class Update : IRequest<PurchaseDetailsCommandVM>
            {
                public int Id { get; set; }
                public int PurchaseID { get; set; }
                public int ItemID { get; set; }
                public double Quantity { get; set; }
                public double Price { get; set; }
                public double Tax { get; set; }
                public bool HasWarrenty { get; set; }
                public DateTime? WarrentyStart { get; set; }
                public DateTime? WarrentyEnd { get; set; }
                public string Serial { get; set; }
            }

            public class MarkAsDelete : IRequest<PurchaseDetailsCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
