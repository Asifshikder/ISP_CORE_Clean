using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.BandwithResellerGivenItem.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.BandwithResellerGivenItem.Create, BandwithResellerGivenItemCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.BandwithResellerGivenItem> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.BandwithResellerGivenItem> _repository;

        public async Task<BandwithResellerGivenItemCommandVM> Handle(Commands.BandwithResellerGivenItem.Create request, CancellationToken cancellationToken)
        {
            var response = new BandwithResellerGivenItemCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.BandwithResellerGivenItem(request.ItemName,request.MeasureUnit,request.PerUnitCommonPrice);
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
