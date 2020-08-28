using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.MeasurementUnit.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.MeasurementUnit.MarkAsDelete, MeasurementUnitCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.MeasurementUnit> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.MeasurementUnit> _repository;
        public async Task<MeasurementUnitCommandVM> Handle(Commands.MeasurementUnit.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new MeasurementUnitCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.MarkAsDelete();

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
