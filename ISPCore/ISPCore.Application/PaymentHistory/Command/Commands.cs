﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.PayementHistory.Command
{
    public static class Commands
    {
        public static class PayementHistory
        {
            public class Create : IRequest<PayementHistoryCommandVM>
            {
                public int? TransactionID { get; set; }
                public int ClientDetailsID { get; set; }
                public int? EmployeeID { get; set; }
                public int? ResellerID { get; set; }
                public int CollectByID { get; set; }
                public DateTime PaymentDate { get; set; }
                public float PaidAmount { get; set; }
                public string ResetNo { get; set; }

                public int? AdvancePaymentID { get; set; }
                public int? PaymentByID { get; set; }

                public int? NormalPayment { get; set; }
                public int? DiscountPayment { get; set; }
                public string PaymentFromWhichPage { get; set; }
                public int BillAcceptBy { get; set; }
                public bool AcceptStatus { get; set; }
            }

            public class Update : IRequest<PayementHistoryCommandVM>
            {
                public int Id { get; set; }
                public int? TransactionID { get; set; }
                public int ClientDetailsID { get; set; }
                public int? EmployeeID { get; set; }
                public int? ResellerID { get; set; }
                public int CollectByID { get; set; }
                public DateTime PaymentDate { get; set; }
                public float PaidAmount { get; set; }
                public string ResetNo { get; set; }

                public int? AdvancePaymentID { get; set; }
                public int? PaymentByID { get; set; }

                public int? NormalPayment { get; set; }
                public int? DiscountPayment { get; set; }
                public string PaymentFromWhichPage { get; set; }
                public int BillAcceptBy { get; set; }
                public bool AcceptStatus { get; set; }
            }

            public class MarkAsDelete : IRequest<PayementHistoryCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
