using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Deposit.Command
{
    public static class Commands
    {
        public static class Deposit
        {
            public class Create : IRequest<DepositCommandVM>
            {
                public string Descriptions { get; set; }
                public byte[] DescriptionFileByte { get; set; }
                public string DescriptionFilePath { get; set; }
                public int HeadID { get; set; }
                public double Amount { get; set; }
                public DateTime PaymentDate { get; set; }
                public int CompanyID { get; set; }
                public int AccountListID { get; set; }
                public int PayerID { get; set; }
                public int PaymentByID { get; set; }
                public int DepositStatus { get; set; }
                public string References { get; set; }
                public int ResellerID { get; set; }
                public int Status { get; private set; }
            }

            public class Update : IRequest<DepositCommandVM>
            {
                public int Id { get; set; }
                public string Descriptions { get; set; }
                public byte[] DescriptionFileByte { get; set; }
                public string DescriptionFilePath { get; set; }
                public int HeadID { get; set; }
                public double Amount { get; set; }
                public DateTime PaymentDate { get; set; }
                public int CompanyID { get; set; }
                public int AccountListID { get; set; }
                public int PayerID { get; set; }
                public int PaymentByID { get; set; }
                public int DepositStatus { get; set; }
                public string References { get; set; }
                public int ResellerID { get; set; }
                public int Status { get; private set; }
            }

            public class MarkAsDelete : IRequest<DepositCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
