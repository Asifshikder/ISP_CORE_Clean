using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.MeasurementUnit.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.MeasurementUnit.Update, MeasurementUnitCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.MeasurementUnit> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.MeasurementUnit> _repository;
        public async Task<MeasurementUnitCommandVM> Handle(Commands.MeasurementUnit.Update request, CancellationToken cancellationToken)
        {
            var response = new MeasurementUnitCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateMeasurementUnit(request.MeasurementUnitName);

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
