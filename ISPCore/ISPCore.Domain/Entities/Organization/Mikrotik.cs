using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class Mikrotik : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int MikrotikID { get; set; }
        public int Id { get; private set; }
        public string MikrotikName { get; set; }
        public string RealIP { get; set; }
        public string MikUserName { get; set; }
        public string MikPassword { get; set; }
        public int APIPort { get; set; }
        public int WebPort { get; set; }

        public int Status { get; private set; }

        public Mikrotik() { }

        public Mikrotik(string mikrotikName,string realIP, string mikUserName, string mikPassword,int aPIPort, int webPort)
        {
            MikrotikName = mikrotikName;
            RealIP = realIP;
            MikUserName = mikUserName;
            MikPassword = mikPassword;
            APIPort = aPIPort;
            WebPort = webPort;
        }

        public void UpdateMikrotik(string mikrotikName, string realIP, string mikUserName, string mikPassword, int aPIPort, int webPort)
        {
            MikrotikName = mikrotikName;
            RealIP = realIP;
            MikUserName = mikUserName;
            MikPassword = mikPassword;
            APIPort = aPIPort;
            WebPort = webPort;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
