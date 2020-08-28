using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ProductStatus.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ProductStatus.MarkAsDelete, ProductStatusCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ProductStatus> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ProductStatus> _repository;
        public async Task<ProductStatusCommandVM> Handle(Commands.ProductStatus.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ProductStatusCommandVM
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
