using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableDistribution.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.CableDistribution.Create, CableDistributionCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.CableDistribution> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.CableDistribution> _repository;

        public async Task<CableDistributionCommandVM> Handle(Commands.CableDistribution.Create request, CancellationToken cancellationToken)
        {
            var response = new CableDistributionCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.CableDistribution(request.ClientDetailsID,request.EmployeeID,request.CableForEmployeeID,request.CableStockID,request.AmountOfCableUsed,request.Purpose,request.CableAssignFromWhere,request.CableIndicatorStatus,request.Remarks);
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
