using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ClientDetails.Queries.Models
{
    public class ClientDetailsVM
    {
        public int Id { get; set; }
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
        public int? ConnectionTypeID { get; set; }
        public int? CableTypeID { get; set; }
        public int? PackageID { get; set; }
        public int? SecurityQuestionID { get; set; }
        public string SecurityQuestionAnswer { get; set; }
        public int? EmployeeID { get; set; }
        public int? RoleID { get; set; }
        public int? UserRightPermissionID { get; set; }
        public int? MikrotikID { get; set; }
        public string IP { get; set; }
        public string Mac { get; set; }
        public int? ResellerID { get; set; }
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
        public double PermanentDiscount { get; set; }
    }
}
