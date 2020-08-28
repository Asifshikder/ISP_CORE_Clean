using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Stock.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Stock.MarkAsDelete, StockCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Stock> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Stock> _repository;
        public async Task<StockCommandVM> Handle(Commands.Stock.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new StockCommandVM
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
