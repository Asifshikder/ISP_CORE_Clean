using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeVsWorkSchedule.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.EmployeeVsWorkSchedule.MarkAsDelete, EmployeeVsWorkScheduleCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.EmployeeVsWorkSchedule> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.EmployeeVsWorkSchedule> _repository;
        public async Task<EmployeeVsWorkScheduleCommandVM> Handle(Commands.EmployeeVsWorkSchedule.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new EmployeeVsWorkScheduleCommandVM
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
