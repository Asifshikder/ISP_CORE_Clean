using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Stock.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Stock.Create, StockCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Stock> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Stock> _repository;

        public async Task<StockCommandVM> Handle(Commands.Stock.Create request, CancellationToken cancellationToken)
        {
            var response = new StockCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Stock(request.ItemID,request.Quantity);
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
