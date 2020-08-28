using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeLeaveHistory.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.EmployeeLeaveHistory.Create, EmployeeLeaveHistoryCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.EmployeeLeaveHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.EmployeeLeaveHistory> _repository;

        public async Task<EmployeeLeaveHistoryCommandVM> Handle(Commands.EmployeeLeaveHistory.Create request, CancellationToken cancellationToken)
        {
            var response = new EmployeeLeaveHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.EmployeeLeaveHistory(request.EmployeeID,request.Reason,request.LeaveSalaryTypeID,request.StartDate,request.EndDate);
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
