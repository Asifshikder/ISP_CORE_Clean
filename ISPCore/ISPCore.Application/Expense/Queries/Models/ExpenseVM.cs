﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Expense.Queries.Models
{
    public class ExpenseVM
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
        public int ExpenseStatus { get; set; }
        public string References { get; set; }
        public int ResellerID { get; set; }
        public int Status { get; private set; }
    }
}
