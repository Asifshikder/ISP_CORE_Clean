using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Brand.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Brand.Create, BrandCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Brand> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Brand> _repository;

        public async Task<BrandCommandVM> Handle(Commands.Brand.Create request, CancellationToken cancellationToken)
        {
            var response = new BrandCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Brand(request.BrandName);
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
