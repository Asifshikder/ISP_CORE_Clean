using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Vendor.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Vendor.Create, VendorCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Vendor> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Vendor> _repository;

        public async Task<VendorCommandVM> Handle(Commands.Vendor.Create request, CancellationToken cancellationToken)
        {
            var response = new VendorCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Vendor(request.VendorName,request.VendorAddress,request.CompanyName,request.VendorLogoName,request.VendorImageOriginal,request.VendorImagePath,request.VendorContactPerson,request.VendorEmail);
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
