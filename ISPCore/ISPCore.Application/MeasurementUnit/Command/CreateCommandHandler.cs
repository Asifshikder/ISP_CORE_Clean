using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.MeasurementUnit.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.MeasurementUnit.Create, MeasurementUnitCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.MeasurementUnit> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.MeasurementUnit> _repository;

        public async Task<MeasurementUnitCommandVM> Handle(Commands.MeasurementUnit.Create request, CancellationToken cancellationToken)
        {
            var response = new MeasurementUnitCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.MeasurementUnit(request.MeasurementUnitName);
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
