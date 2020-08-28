using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
   public class Brand : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string BrandName { get; private set; }

        public int Status { get; private set; }


        public Brand() { }

        public Brand(string brandName)
        {
            BrandName = brandName;
        }

        public void UpdateBrand(string brandName)
        {
            BrandName = brandName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
