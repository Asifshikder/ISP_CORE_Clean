using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class BandwithResellerGivenItem : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string ItemName { get; set; }
        public string MeasureUnit { get; set; }
        public string PerUnitCommonPrice { get; set; }

        public int Status { get; private set; }


        public BandwithResellerGivenItem() { }

        public BandwithResellerGivenItem(string itemName,string measureUnit, string perUnitCommonPrice)
        {
            ItemName = itemName;
            MeasureUnit = measureUnit;
            PerUnitCommonPrice = perUnitCommonPrice;
        }

        public void UpdateBandwithResellerGivenItem(string itemName, string measureUnit, string perUnitCommonPrice)
        {
            ItemName = itemName;
            MeasureUnit = measureUnit;
            PerUnitCommonPrice = perUnitCommonPrice;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
