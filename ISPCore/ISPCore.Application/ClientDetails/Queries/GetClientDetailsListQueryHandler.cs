using Dapper;
using ISPCore.Application.ClientDetails.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientDetails.Queries
{
    public class GetClientDetailsListQueryHandler : IRequestHandler<Queries.GetClientDetailsList, List<ClientDetailsVM>>
    {
        public GetClientDetailsListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public async Task<List<ClientDetailsVM>> Handle(Queries.GetClientDetailsList request, CancellationToken cancellationToken)
        {
            var query = $"select Id,Name,LoginName,Password,Email,Address,ContactNumber,Occupation,SocialCommunicationURL,Remarks,BoxNumber,PopDetails,RequireCable,Reference,NationalID,ConnectionFeesProvidedDate,ClientSurvey,ConnectionDate,ClientPriority,MacAddress,SMSCommunication,IsNewClient,NewClientRequestDate,NewClientApproximateConnectionStartDate,ZoneID,ConnectionTypeID,CableTypeID,PackageID,SecurityQuestionID,SecurityQuestionAnswer,EmployeeID,RoleID,UserRightPermissionID,MikrotikID,IP,Mac,ResellerID,IsPriorityClient,ApproxPaymentDate,ProfileUpdatePercentage,StatusThisMonth,StatusNextMonth,LineStatusWillActiveInThisDate,ClientOwnImageBytes,ClientOwnImageBytesPaths,ClientNIDImageBytes,ClientNIDImageBytesPaths,PackageThisMonth,PackageNextMonth,NextApproxPaymentFullDate,RunningCycle,ClientLineStatusID,PermanentDiscount"+"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<ClientDetailsVM>(query);
            return data.ToList();
        }
    }
}
