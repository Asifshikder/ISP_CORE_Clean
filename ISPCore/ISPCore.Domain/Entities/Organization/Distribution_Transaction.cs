using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class Distribution_Transaction : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int Distribution_TransactionID { get; set; }
        public int Id { get; private set; }
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

        public int Status { get; private set; }

        public Distribution_Transaction() { }

        public Distribution_Transaction(int stockDetailsID ,int sectionID, int productStatusID,string itemName , string brandName ,
            string serial , string clientName, string employeeName , string sectionName, string productStatus )
        {
            StockDetailsID = stockDetailsID;
            SectionID = sectionID;
            ProductStatusID = productStatusID;
            ItemName = itemName;
            BrandName = brandName;
            Serial = serial;
            ClientName = clientName;
            EmployeeName = employeeName;
            SectionName = sectionName;
            ProductStatus = productStatus;
        }

        public void UpdateDistribution_Transaction(int stockDetailsID, int sectionID, int productStatusID, string itemName, string brandName,
            string serial, string clientName, string employeeName, string sectionName, string productStatus)
        {
            StockDetailsID = stockDetailsID;
            SectionID = sectionID;
            ProductStatusID = productStatusID;
            ItemName = itemName;
            BrandName = brandName;
            Serial = serial;
            ClientName = clientName;
            EmployeeName = employeeName;
            SectionName = sectionName;
            ProductStatus = productStatus;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}