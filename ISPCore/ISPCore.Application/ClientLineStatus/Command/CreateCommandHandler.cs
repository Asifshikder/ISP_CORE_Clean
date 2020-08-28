using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientLineStatus.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ClientLineStatus.Create, ClientLineStatusCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ClientLineStatus> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ClientLineStatus> _repository;

        public async Task<ClientLineStatusCommandVM> Handle(Commands.ClientLineStatus.Create request, CancellationToken cancellationToken)
        {
            var response = new ClientLineStatusCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ClientLineStatus(request.ClientDetailsID,request.PackageID,request.LineStatusID,request.LineStatusFromWhichMonth,request.StatusChangeReason,request.LineStatusChangeDate,request.EmployeeID,request.ResellerID,request.MikrotikID,request.IsLineStatusApplied,request.LineStatusWillActiveInThisDate,request.StatusFromNow,request.StatusThisMonth,request.StatusNextMonth,request.PackageThisMonth,request.PackageNextMonth);
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
