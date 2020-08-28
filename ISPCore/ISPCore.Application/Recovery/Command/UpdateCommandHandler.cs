using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Recovery.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Recovery.Update, RecoveryCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Recovery> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Recovery> _repository;
        public async Task<RecoveryCommandVM> Handle(Commands.Recovery.Update request, CancellationToken cancellationToken)
        {
            var response = new RecoveryCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateRecovery(request.EmployeeID, request.DistributionReasonID, request.DistributionID, request.StockDetailsID, request.PopID, request.BoxID, request.ClientDetailsID, request.RecoveryDate, request.IndicatorStatus);

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
