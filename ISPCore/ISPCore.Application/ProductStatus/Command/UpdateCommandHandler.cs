using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ProductStatus.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ProductStatus.Update, ProductStatusCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ProductStatus> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ProductStatus> _repository;
        public async Task<ProductStatusCommandVM> Handle(Commands.ProductStatus.Update request, CancellationToken cancellationToken)
        {
            var response = new ProductStatusCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateProductStatus(request.ProductStatusName);

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
