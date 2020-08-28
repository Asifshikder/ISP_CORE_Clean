using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Distribution.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Distribution.Update, DistributionCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Distribution> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Distribution> _repository;
        public async Task<DistributionCommandVM> Handle(Commands.Distribution.Update request, CancellationToken cancellationToken)
        {
            var response = new DistributionCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateDistribution(request.EmployeeID, request.StockDetailsID, request.PopID, request.BoxID, request.ClientDetailsID, request.DistributionReasonID, request.IndicatorStatus, request.Remarks);

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
