using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.VendorType.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.VendorType.Create, VendorTypeCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.VendorType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.VendorType> _repository;

        public async Task<VendorTypeCommandVM> Handle(Commands.VendorType.Create request, CancellationToken cancellationToken)
        {
            var response = new VendorTypeCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.VendorType(request.VendorTypeName);
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
