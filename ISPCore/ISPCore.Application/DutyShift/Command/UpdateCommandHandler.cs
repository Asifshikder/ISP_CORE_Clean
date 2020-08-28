using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DutyShift.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.DutyShift.Update, DutyShiftCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.DutyShift> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.DutyShift> _repository;
        public async Task<DutyShiftCommandVM> Handle(Commands.DutyShift.Update request, CancellationToken cancellationToken)
        {
            var response = new DutyShiftCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateDutyShift(request.StartHour,request.StartMinute,request.EndHour,request.EndMinute);

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
