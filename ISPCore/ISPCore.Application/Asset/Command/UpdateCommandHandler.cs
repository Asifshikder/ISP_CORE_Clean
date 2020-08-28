using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Asset.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Asset.Update, AssetCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Asset> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Asset> _repository;
        public async Task<AssetCommandVM> Handle(Commands.Asset.Update request, CancellationToken cancellationToken)
        {
            var response = new AssetCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateAsset(request.AssetName, request.AssetTypeID, request.AssetValue, request.PurchaseDate, request.SerialNumber, request.WarrentyStartDate, request.WarrentyEndDate);

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
