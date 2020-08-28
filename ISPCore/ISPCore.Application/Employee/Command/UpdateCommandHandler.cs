using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Employee.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Employee.Update, EmployeeCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Employee> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Employee> _repository;
        public async Task<EmployeeCommandVM> Handle(Commands.Employee.Update request, CancellationToken cancellationToken)
        {
            var response = new EmployeeCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateEmployee(request.Name, request.LoginName, request.Password, request.Phone, request.Address, request.Email, request.DepartmentID, request.RoleID, request.UserRightPermissionID,
                    request.DOB, request.DeviceID, request.DutyShiftID, request.Salary, request.EmployeeID, request.BreakHour, request.BreakMinute, request.DutyShiftCombined, request.EmployeeOwnImageBytes, request.EmployeeOwnImageBytesPaths,
                    request.EmployeeNIDImageBytes, request.EmployeeNIDImageBytesPaths, request.ResellerID);

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
