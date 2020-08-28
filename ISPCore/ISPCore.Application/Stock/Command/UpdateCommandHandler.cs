using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Stock.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Stock.Update, StockCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Stock> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Stock> _repository;
        public async Task<StockCommandVM> Handle(Commands.Stock.Update request, CancellationToken cancellationToken)
        {
            var response = new StockCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateStock(request.ItemID,request.Quantity);

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
