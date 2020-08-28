using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeVsWorkSchedule.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.EmployeeVsWorkSchedule.Create, EmployeeVsWorkScheduleCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.EmployeeVsWorkSchedule> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.EmployeeVsWorkSchedule> _repository;

        public async Task<EmployeeVsWorkScheduleCommandVM> Handle(Commands.EmployeeVsWorkSchedule.Create request, CancellationToken cancellationToken)
        {
            var response = new EmployeeVsWorkScheduleCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.EmployeeVsWorkSchedule(request.DayID,request.StartHour,request.StartMinute,request.RunHour,request.RunMinute,request.BreakStartHour,request.BreakStartMinute,request.BreakEndHour,request.BreakEndMinute,request.EmployeeID);
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
