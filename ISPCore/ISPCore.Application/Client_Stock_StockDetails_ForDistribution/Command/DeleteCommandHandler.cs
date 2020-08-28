using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Client_Stock_StockDetails_ForDistribution.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Client_Stock_StockDetails_ForDistribution.MarkAsDelete, Client_Stock_StockDetails_ForDistributionCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Client_Stock_StockDetails_ForDistribution> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Client_Stock_StockDetails_ForDistribution> _repository;
        public async Task<Client_Stock_StockDetails_ForDistributionCommandVM> Handle(Commands.Client_Stock_StockDetails_ForDistribution.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new Client_Stock_StockDetails_ForDistributionCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.MarkAsDelete();

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
