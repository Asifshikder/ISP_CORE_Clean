using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.StockDetails.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.StockDetails.MarkAsDelete, StockDetailsCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.StockDetails> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.StockDetails> _repository;
        public async Task<StockDetailsCommandVM> Handle(Commands.StockDetails.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new StockDetailsCommandVM
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
