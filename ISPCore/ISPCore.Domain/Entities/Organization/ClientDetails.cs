using ISPCore.Domain.Entities;
using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISPCore.Domain.Entities
{
    public class ClientDetails : BaseEntity, IHasId<int>, IAggregateRoot
    {
        //public int ClientDetailsID { get; set; }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Occupation { get; set; }
        public string SocialCommunicationURL { get; set; }
        public string Remarks { get; set; }
        public string BoxNumber { get; set; }
        public string PopDetails { get; set; }
        public string RequireCable { get; set; }
        public string Reference { get; set; }
        public string NationalID { get; set; }
        public DateTime? ConnectionFeesProvidedDate { get; set; }
        public string ClientSurvey { get; set; }
        public DateTime? ConnectionDate { get; set; }
        public int? ClientPriority { get; set; }
        public string MacAddress { get; set; }
        public string SMSCommunication { get; set; }
        public int? IsNewClient { get; set; }
        public DateTime? NewClientRequestDate { get; set; }
        public DateTime? NewClientApproximateConnectionStartDate { get; set; }
        public int? ZoneID { get; set; }
        public virtual Zone Zone { get; set; }
        public int? ConnectionTypeID { get; set; }
        public int? CableTypeID { get; set; }
        public virtual CableType CableType { get; set; }
        public int? PackageID { get; set; }
        public virtual Package Package { get; set; }
        public int? SecurityQuestionID { get; set; }
        public virtual SecurityQuestion SecurityQuestion { get; set; }
        public string SecurityQuestionAnswer { get; set; }
        public int? EmployeeID { get; set; }/// <summary>
                                            /// this is only for new client and the field is assign to which employee...:D
                                            /// </summary>
        public virtual Employee Employee { get; set; }
        public int? RoleID { get; set; }
        public virtual Role Role { get; set; }
        public int? UserRightPermissionID { get; set; }
        public virtual UserRightPermission UserRightPermission { get; set; }
        public int? MikrotikID { get; set; }
        public virtual Mikrotik Mikrotik { get; set; }
        public string IP { get; set; }
        public string Mac { get; set; }
        public int? ResellerID { get; set; }
        public virtual Reseller Reseller { get; set; }
        public bool IsPriorityClient { get; set; }

        public int ApproxPaymentDate { get; set; }

        public double ProfileUpdatePercentage { get; set; }
        public int StatusThisMonth { get; set; }
        public int StatusNextMonth { get; set; }
        public DateTime LineStatusWillActiveInThisDate { get; set; }

        public byte[] ClientOwnImageBytes { get; set; }
        public string ClientOwnImageBytesPaths { get; set; }
        public byte[] ClientNIDImageBytes { get; set; }
        public string ClientNIDImageBytesPaths { get; set; }


        public int PackageThisMonth { get; set; }
        public int PackageNextMonth { get; set; }


        public DateTime? NextApproxPaymentFullDate { get; set; } //this the Client Payment Full Date
        //public DateTime NextGenerateDate { get; set; }    //this is the next bill generate time

        public string RunningCycle { get; set; }
        public int ClientLineStatusID { get; set; }
        public int Status { get; set; }
        public double PermanentDiscount { get; set; }

        public ClientDetails() { }

        public ClientDetails(string name,string loginName,string password,string email,string address, string contactNumber,string occupation,string socialCommunicationURL,string remarks,string boxNumber,string popDetails,string requireCable, string references, string nationalID,
            DateTime? connectionFeesProvidedDate,string clientSurvey,DateTime? connectionDate, int? clientPriority,string macAddress,string smsCommunication,int? isNewClient,DateTime? newClientRequestDate,DateTime? newClientApproximateConnectionStartDate,int? zoneID,int? connectionType,int? cableType,int? packageID,
            int? securityQuestionID, string securityQuestionAns, int? employeeID,int? roleID, int? userRightPermissionID, int? mikrotikID,string iP,string mac, int? resellerID, bool isPriorityClient, int approxPaymentDate, double profileUpdatePercentage, int statusThisMonth, int statusNextMonth , DateTime lineStatusWillActiveInThisDate ,
              byte[] clientOwnImageBytes, string clientOwnImageBytesPaths,byte[] clientNIDImageBytes , string clientNIDImageBytesPaths ,int packageThisMonth ,int packageNextMonth,DateTime? nextApproxPaymentFullDate ,string runningCycle , int clientLineStatusID , double permanentDiscount)
        {
            Name = name;
            LoginName = loginName;
            Password = password;
            Email = email;
            Address = address;
            ContactNumber = contactNumber;
            Occupation = occupation;
            SocialCommunicationURL = socialCommunicationURL;
            Remarks = remarks;
            BoxNumber = boxNumber;
            PopDetails = popDetails;
            RequireCable = requireCable;
            Reference = references;
            NationalID = nationalID;
            ConnectionFeesProvidedDate = connectionFeesProvidedDate;
            ClientSurvey = clientSurvey;
            ConnectionDate = connectionDate;
            ClientPriority = clientPriority;
            MacAddress = macAddress;
            SMSCommunication = smsCommunication;
            IsNewClient = isNewClient;
            NewClientRequestDate = newClientRequestDate;
            NewClientApproximateConnectionStartDate = newClientApproximateConnectionStartDate;
            ZoneID = zoneID;
            ConnectionTypeID = connectionType;
            CableTypeID = cableType;
            PackageID = packageID;
            SecurityQuestionID = securityQuestionID;
            SecurityQuestionAnswer = securityQuestionAns;
            EmployeeID = employeeID;
            RoleID = roleID;
            UserRightPermissionID = userRightPermissionID;
            MikrotikID = mikrotikID;
            IP = iP;
            Mac = mac;
            ResellerID = resellerID;
            IsPriorityClient = isPriorityClient;
            ApproxPaymentDate = approxPaymentDate;
            ProfileUpdatePercentage = profileUpdatePercentage;
            StatusThisMonth = statusThisMonth;
            StatusNextMonth = statusNextMonth;
            LineStatusWillActiveInThisDate = lineStatusWillActiveInThisDate;
            ClientOwnImageBytes = clientOwnImageBytes;
            ClientOwnImageBytesPaths = clientOwnImageBytesPaths;
            ClientNIDImageBytes = clientNIDImageBytes;
            ClientNIDImageBytesPaths = clientNIDImageBytesPaths;
            PackageThisMonth = packageThisMonth;
            PackageNextMonth = packageNextMonth;
            NextApproxPaymentFullDate = nextApproxPaymentFullDate;
            RunningCycle = runningCycle;
            ClientLineStatusID = clientLineStatusID;
            PermanentDiscount = permanentDiscount;
        }

        public void UpdateClientDetails(string name, string loginName, string password, string email, string address, string contactNumber, string occupation, string socialCommunicationURL, string remarks, string boxNumber, string popDetails, string requireCable, string references, string nationalID,
            DateTime? connectionFeesProvidedDate, string clientSurvey, DateTime? connectionDate, int? clientPriority, string macAddress, string smsCommunication, int? isNewClient, DateTime? newClientRequestDate, DateTime? newClientApproximateConnectionStartDate, int? zoneID, int? connectionType, int? cableType, int? packageID,
            int? securityQuestionID, string securityQuestionAns, int? employeeID, int? roleID, int? userRightPermissionID, int? mikrotikID, string iP, string mac, int? resellerID, bool isPriorityClient, int approxPaymentDate, double profileUpdatePercentage, int statusThisMonth, int statusNextMonth, DateTime lineStatusWillActiveInThisDate,
              byte[] clientOwnImageBytes, string clientOwnImageBytesPaths, byte[] clientNIDImageBytes, string clientNIDImageBytesPaths, int packageThisMonth, int packageNextMonth, DateTime? nextApproxPaymentFullDate, string runningCycle, int clientLineStatusID, double permanentDiscount)
        {
            Name = name;
            LoginName = loginName;
            Password = password;
            Email = email;
            Address = address;
            ContactNumber = contactNumber;
            Occupation = occupation;
            SocialCommunicationURL = socialCommunicationURL;
            Remarks = remarks;
            BoxNumber = boxNumber;
            PopDetails = popDetails;
            RequireCable = requireCable;
            Reference = references;
            NationalID = nationalID;
            ConnectionFeesProvidedDate = connectionFeesProvidedDate;
            ClientSurvey = clientSurvey;
            ConnectionDate = connectionDate;
            ClientPriority = clientPriority;
            MacAddress = macAddress;
            SMSCommunication = smsCommunication;
            IsNewClient = isNewClient;
            NewClientRequestDate = newClientRequestDate;
            NewClientApproximateConnectionStartDate = newClientApproximateConnectionStartDate;
            ZoneID = zoneID;
            ConnectionTypeID = connectionType;
            CableTypeID = cableType;
            PackageID = packageID;
            SecurityQuestionID = securityQuestionID;
            SecurityQuestionAnswer = securityQuestionAns;
            EmployeeID = employeeID;
            RoleID = roleID;
            UserRightPermissionID = userRightPermissionID;
            MikrotikID = mikrotikID;
            IP = iP;
            Mac = mac;
            ResellerID = resellerID;
            IsPriorityClient = isPriorityClient;
            ApproxPaymentDate = approxPaymentDate;
            ProfileUpdatePercentage = profileUpdatePercentage;
            StatusThisMonth = statusThisMonth;
            StatusNextMonth = statusNextMonth;
            LineStatusWillActiveInThisDate = lineStatusWillActiveInThisDate;
            ClientOwnImageBytes = clientOwnImageBytes;
            ClientOwnImageBytesPaths = clientOwnImageBytesPaths;
            ClientNIDImageBytes = clientNIDImageBytes;
            ClientNIDImageBytesPaths = clientNIDImageBytesPaths;
            PackageThisMonth = packageThisMonth;
            PackageNextMonth = packageNextMonth;
            NextApproxPaymentFullDate = nextApproxPaymentFullDate;
            RunningCycle = runningCycle;
            ClientLineStatusID = clientLineStatusID;
            PermanentDiscount = permanentDiscount;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}