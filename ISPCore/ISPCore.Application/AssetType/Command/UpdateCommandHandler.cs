using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AssetType.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.AssetType.Update, AssetTypeCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.AssetType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AssetType> _repository;
        public async Task<AssetTypeCommandVM> Handle(Commands.AssetType.Update request, CancellationToken cancellationToken)
        {
            var response = new AssetTypeCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateAssetType(request.AssetTypeName);

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
