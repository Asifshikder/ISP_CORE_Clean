using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Supplier.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Supplier.Create, SupplierCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Supplier> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Supplier> _repository;

        public async Task<SupplierCommandVM> Handle(Commands.Supplier.Create request, CancellationToken cancellationToken)
        {
            var response = new SupplierCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Supplier(request.SupplierName,request.SupplierAddress);
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
