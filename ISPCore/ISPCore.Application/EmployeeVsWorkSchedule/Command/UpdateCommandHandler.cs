using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeVsWorkSchedule.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.EmployeeVsWorkSchedule.Update, EmployeeVsWorkScheduleCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.EmployeeVsWorkSchedule> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.EmployeeVsWorkSchedule> _repository;
        public async Task<EmployeeVsWorkScheduleCommandVM> Handle(Commands.EmployeeVsWorkSchedule.Update request, CancellationToken cancellationToken)
        {
            var response = new EmployeeVsWorkScheduleCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateEmployeeVsWorkSchedule(request.DayID, request.StartHour, request.StartMinute, request.RunHour, request.RunMinute, request.BreakStartHour, request.BreakStartMinute, request.BreakEndHour, request.BreakEndMinute, request.EmployeeID);

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
