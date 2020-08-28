using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Supplier.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Supplier.Update, SupplierCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Supplier> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Supplier> _repository;
        public async Task<SupplierCommandVM> Handle(Commands.Supplier.Update request, CancellationToken cancellationToken)
        {
            var response = new SupplierCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateSupplier(request.SupplierName,request.SupplierAddress);

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
