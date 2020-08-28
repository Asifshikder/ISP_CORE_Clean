using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ProductStatus.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ProductStatus.Create, ProductStatusCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ProductStatus> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ProductStatus> _repository;

        public async Task<ProductStatusCommandVM> Handle(Commands.ProductStatus.Create request, CancellationToken cancellationToken)
        {
            var response = new ProductStatusCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ProductStatus(request.ProductStatusName);
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
