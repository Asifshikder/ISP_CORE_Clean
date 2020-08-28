using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeLeaveHistory.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.EmployeeLeaveHistory.Update, EmployeeLeaveHistoryCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.EmployeeLeaveHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.EmployeeLeaveHistory> _repository;
        public async Task<EmployeeLeaveHistoryCommandVM> Handle(Commands.EmployeeLeaveHistory.Update request, CancellationToken cancellationToken)
        {
            var response = new EmployeeLeaveHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateEmployeeLeaveHistory(request.EmployeeID, request.Reason, request.LeaveSalaryTypeID, request.StartDate, request.EndDate);

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
