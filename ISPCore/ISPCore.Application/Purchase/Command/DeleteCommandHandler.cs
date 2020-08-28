using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Purchase.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Purchase.MarkAsDelete, PurchaseCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Purchase> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Purchase> _repository;
        public async Task<PurchaseCommandVM> Handle(Commands.Purchase.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new PurchaseCommandVM
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
