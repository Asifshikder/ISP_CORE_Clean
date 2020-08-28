using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableDistribution.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.CableDistribution.Update, CableDistributionCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.CableDistribution> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.CableDistribution> _repository;
        public async Task<CableDistributionCommandVM> Handle(Commands.CableDistribution.Update request, CancellationToken cancellationToken)
        {
            var response = new CableDistributionCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateCableDistribution(request.ClientDetailsID, request.EmployeeID, request.CableForEmployeeID, request.CableStockID, request.AmountOfCableUsed, request.Purpose, request.CableAssignFromWhere, request.CableIndicatorStatus, request.Remarks);

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
