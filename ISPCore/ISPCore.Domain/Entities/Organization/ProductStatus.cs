using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ProductStatus : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string ProductStatusName { get; private set; }

        public int Status { get; private set; }


        public ProductStatus() { }

        public ProductStatus(string productStatusName)
        {
            ProductStatusName = productStatusName;
        }

        public void UpdateProductStatus(string productStatusName)
        {
            ProductStatusName = productStatusName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
