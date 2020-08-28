using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Client_Stock_StockDetails_ForDistribution.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Client_Stock_StockDetails_ForDistribution.Update, Client_Stock_StockDetails_ForDistributionCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Client_Stock_StockDetails_ForDistribution> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Client_Stock_StockDetails_ForDistribution> _repository;
        public async Task<Client_Stock_StockDetails_ForDistributionCommandVM> Handle(Commands.Client_Stock_StockDetails_ForDistribution.Update request, CancellationToken cancellationToken)
        {
            var response = new Client_Stock_StockDetails_ForDistributionCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateClient_Stock_StockDetails_ForDistribution(request.StockID, request.StockDetailsID, request.PopID, request.Client_Stock_StockDetails_ForDistributionID, request.CustomerID, request.EmployeeID, request.DistributionReasonID, request.OldStockID, request.OldStockDetailsID, request.OldSectionID, request.OldProductStatusID, request.Remarks);

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
