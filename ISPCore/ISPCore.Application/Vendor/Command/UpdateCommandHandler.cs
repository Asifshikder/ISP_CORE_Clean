using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Vendor.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Vendor.Update, VendorCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Vendor> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Vendor> _repository;
        public async Task<VendorCommandVM> Handle(Commands.Vendor.Update request, CancellationToken cancellationToken)
        {
            var response = new VendorCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateVendor(request.VendorName, request.VendorAddress, request.CompanyName, request.VendorLogoName, request.VendorImageOriginal, request.VendorImagePath, request.VendorContactPerson, request.VendorEmail);

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
