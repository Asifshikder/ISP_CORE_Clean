using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Distribution.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Distribution.Create, DistributionCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Distribution> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Distribution> _repository;

        public async Task<DistributionCommandVM> Handle(Commands.Distribution.Create request, CancellationToken cancellationToken)
        {
            var response = new DistributionCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Distribution(request.EmployeeID,request.StockDetailsID,request.PopID,request.BoxID,request.ClientDetailsID,request.DistributionReasonID,request.IndicatorStatus,request.Remarks);
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
