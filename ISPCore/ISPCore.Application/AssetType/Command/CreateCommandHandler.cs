using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AssetType.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.AssetType.Create, AssetTypeCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.AssetType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AssetType> _repository;

        public async Task<AssetTypeCommandVM> Handle(Commands.AssetType.Create request, CancellationToken cancellationToken)
        {
            var response = new AssetTypeCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.AssetType(request.AssetTypeName);
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
