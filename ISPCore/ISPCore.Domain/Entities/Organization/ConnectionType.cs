using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class ConnectionType : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string ConnectionTypeName { get; private set; }

        public int Status { get; private set; }


        public ConnectionType() { }

        public ConnectionType(string connectionTypeName)
        {
            ConnectionTypeName = connectionTypeName;
        }

        public void UpdateConnectionType(string connectionTypeName)
        {
            ConnectionTypeName = connectionTypeName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
