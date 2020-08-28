using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeLeaveHistory.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.EmployeeLeaveHistory.MarkAsDelete, EmployeeLeaveHistoryCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.EmployeeLeaveHistory> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.EmployeeLeaveHistory> _repository;
        public async Task<EmployeeLeaveHistoryCommandVM> Handle(Commands.EmployeeLeaveHistory.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new EmployeeLeaveHistoryCommandVM
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
