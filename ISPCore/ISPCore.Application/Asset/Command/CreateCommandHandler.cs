using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Asset.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Asset.Create, AssetCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Asset> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Asset> _repository;

        public async Task<AssetCommandVM> Handle(Commands.Asset.Create request, CancellationToken cancellationToken)
        {
            var response = new AssetCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Asset(request.AssetName,request.AssetTypeID,request.AssetValue,request.PurchaseDate,request.SerialNumber,request.WarrentyStartDate,request.WarrentyEndDate);
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
