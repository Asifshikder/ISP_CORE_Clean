using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientLineStatus.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ClientLineStatus.Update, ClientLineStatusCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ClientLineStatus> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ClientLineStatus> _repository;
        public async Task<ClientLineStatusCommandVM> Handle(Commands.ClientLineStatus.Update request, CancellationToken cancellationToken)
        {
            var response = new ClientLineStatusCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateClientLineStatus(request.ClientDetailsID, request.PackageID, request.LineStatusID, request.LineStatusFromWhichMonth, request.StatusChangeReason, request.LineStatusChangeDate, request.EmployeeID, request.ResellerID, request.MikrotikID, request.IsLineStatusApplied, request.LineStatusWillActiveInThisDate, request.StatusFromNow, request.StatusThisMonth, request.StatusNextMonth, request.PackageThisMonth, request.PackageNextMonth);

                await _repository.UpdateAsync(entity);

                response.Status = true;
                response.Message = "entity updated successfully.";
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
