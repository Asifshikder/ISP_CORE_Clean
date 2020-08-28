using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.BandwithResellerGivenItem.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.BandwithResellerGivenItem.Update, BandwithResellerGivenItemCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.BandwithResellerGivenItem> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.BandwithResellerGivenItem> _repository;
        public async Task<BandwithResellerGivenItemCommandVM> Handle(Commands.BandwithResellerGivenItem.Update request, CancellationToken cancellationToken)
        {
            var response = new BandwithResellerGivenItemCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateBandwithResellerGivenItem(request.ItemName, request.MeasureUnit, request.PerUnitCommonPrice);

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
