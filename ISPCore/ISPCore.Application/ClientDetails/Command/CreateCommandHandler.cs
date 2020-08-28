using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientDetails.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ClientDetails.Create, ClientDetailsCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ClientDetails> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ClientDetails> _repository;

        public async Task<ClientDetailsCommandVM> Handle(Commands.ClientDetails.Create request, CancellationToken cancellationToken)
        {
            var response = new ClientDetailsCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ClientDetails(request.Name, request.LoginName, request.Password, request.Email, request.Address, request.ContactNumber, request.Occupation, request.SocialCommunicationURL, request.Remarks, request.BoxNumber, request.PopDetails, request.RequireCable, request.Reference, request.NationalID, request.ConnectionFeesProvidedDate, request.ClientSurvey, request.ConnectionDate, request.ClientPriority, request.MacAddress, request.SMSCommunication, request.IsNewClient, request.NewClientRequestDate, request.NewClientApproximateConnectionStartDate, request.ZoneID, request.ConnectionTypeID, request.CableTypeID, request.PackageID, request.SecurityQuestionID, request.SecurityQuestionAnswer, request.EmployeeID, request.RoleID, request.UserRightPermissionID, request.MikrotikID, request.IP, request.Mac, request.ResellerID, request.IsPriorityClient, request.ApproxPaymentDate, request.ProfileUpdatePercentage, request.StatusThisMonth, request.StatusNextMonth, request.LineStatusWillActiveInThisDate,
                    request.ClientOwnImageBytes, request.ClientOwnImageBytesPaths, request.ClientNIDImageBytes, request.ClientNIDImageBytesPaths,request.PackageThisMonth,request.PackageNextMonth,request.NextApproxPaymentFullDate,request.RunningCycle,request.ClientLineStatusID,request.PermanentDiscount
                    ); ;
                var data = await _repository.AddAsync(entity);

                response.Status = true;
                response.Message = "entity created successfully.";
                response.Id = entity.Id;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
