using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Package.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Package.Create, PackageCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Package> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Package> _repository;

        public async Task<PackageCommandVM> Handle(Commands.Package.Create request, CancellationToken cancellationToken)
        {
            var response = new PackageCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Package(request.PackageName,request.IPPoolID,request.MikrotikID,request.LocalAddress,request.OldPackageName
                    ,request.PackagePrice,request.BandWith);
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
