using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.VendorType.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.VendorType.Update, VendorTypeCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.VendorType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.VendorType> _repository;
        public async Task<VendorTypeCommandVM> Handle(Commands.VendorType.Update request, CancellationToken cancellationToken)
        {
            var response = new VendorTypeCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateVendorType(request.VendorTypeName);

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
