using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class DirectProductSectionChangeFromWorkingToOthers : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int DirectProductSectionChangeFromWorkingToOthersID { get; set; }
        public int Id { get; private set; }
        public string ClientName { get; set; }
        public string TakenEmployee { get; set; }
        public int StockDetailsID { get; set; }
        public virtual StockDetails StockDetails { get; set; }
        public int FromSection { get; set; }
        public int ToSection { get; set; }
        public string WhoChanged { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public int Status { get; private set; }

        public DirectProductSectionChangeFromWorkingToOthers() { }

        public DirectProductSectionChangeFromWorkingToOthers(string clientName,string takenEmployee,int stockDetailsID,int fromSection,
            int toSection,string whoChanged, DateTime changeDateTime)
        {
            ClientName = clientName;
            TakenEmployee = takenEmployee;
            StockDetailsID = stockDetailsID;
            FromSection = fromSection;
            ToSection = toSection;
            WhoChanged = whoChanged;
            ChangeDateTime = changeDateTime;

        }

        public void UpdateDirectProductSectionChangeFromWorkingToOthers(string clientName, string takenEmployee, int stockDetailsID, int fromSection,
            int toSection, string whoChanged, DateTime changeDateTime)
        {
            ClientName = clientName;
            TakenEmployee = takenEmployee;
            StockDetailsID = stockDetailsID;
            FromSection = fromSection;
            ToSection = toSection;
            WhoChanged = whoChanged;
            ChangeDateTime = changeDateTime;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}