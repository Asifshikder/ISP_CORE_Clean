using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Client_Stock_StockDetails_ForDistribution : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public int StockID { get; set; }
        public int StockDetailsID { get; set; }
        public int? PopID { get; set; }
        public int? Client_Stock_StockDetails_ForDistributionID { get; set; }
        public int? CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public int DistributionReasonID { get; set; }
        public int? OldStockID { get; set; }
        public int? OldStockDetailsID { get; set; }
        public int? OldSectionID { get; set; }
        public int? OldProductStatusID { get; set; }
        public string Remarks { get; set; }

        public int Status { get; private set; }


        public Client_Stock_StockDetails_ForDistribution() { }

        public Client_Stock_StockDetails_ForDistribution( int stockID,int stockDetailsID ,int? popID, int? client_Stock_StockDetails_ForDistributionID, int? customerID,
            int employeeID,int distributionReasonID , int? oldStockID,int? oldStockDetailsID,int? oldSectionID, int? oldProductStatusID ,string remarks)
        {

            StockID = stockID;
            StockDetailsID = stockDetailsID;
            PopID = popID;
            Client_Stock_StockDetails_ForDistributionID = client_Stock_StockDetails_ForDistributionID;
            CustomerID = customerID;
            EmployeeID = employeeID;
            DistributionReasonID = distributionReasonID;
            OldStockID = oldStockID;
            OldSectionID = oldSectionID;
            OldStockDetailsID = oldStockDetailsID;
            OldProductStatusID = oldProductStatusID;
            Remarks = remarks;
        }

        public void UpdateClient_Stock_StockDetails_ForDistribution(int stockID, int stockDetailsID, int? popID, int? client_Stock_StockDetails_ForDistributionID, int? CcustomerID,
            int employeeID, int distributionReasonID, int? oldStockID, int? oldStockDetailsID, int? oldSectionID, int? oldProductStatusID, string remarks)
        {

            StockID = stockID;
            StockDetailsID = stockDetailsID;
            PopID = popID;
            Client_Stock_StockDetails_ForDistributionID = client_Stock_StockDetails_ForDistributionID;
            CustomerID = CustomerID;
            EmployeeID = employeeID;
            DistributionReasonID = distributionReasonID;
            OldStockID = oldStockID;
            OldSectionID = oldSectionID;
            OldStockDetailsID = oldStockDetailsID;
            OldProductStatusID = oldProductStatusID;
            Remarks = remarks;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
