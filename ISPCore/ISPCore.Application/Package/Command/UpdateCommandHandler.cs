using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Package.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Package.Update, PackageCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Package> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Package> _repository;
        public async Task<PackageCommandVM> Handle(Commands.Package.Update request, CancellationToken cancellationToken)
        {
            var response = new PackageCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdatePackage(request.PackageName, request.IPPoolID, request.MikrotikID, request.LocalAddress, request.OldPackageName
                    , request.PackagePrice, request.BandWith);

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
