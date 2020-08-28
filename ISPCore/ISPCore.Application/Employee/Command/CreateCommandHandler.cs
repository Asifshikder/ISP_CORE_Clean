using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Employee.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Employee.Create, EmployeeCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Employee> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Employee> _repository;

        public async Task<EmployeeCommandVM> Handle(Commands.Employee.Create request, CancellationToken cancellationToken)
        {
            var response = new EmployeeCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Employee(request.Name,request.LoginName,request.Password,request.Phone,request.Address,request.Email,request.DepartmentID,request.RoleID,request.UserRightPermissionID,
                    request.DOB,request.DeviceID,request.DutyShiftID,request.Salary,request.EmployeeID,request.BreakHour,request.BreakMinute,request.DutyShiftCombined,request.EmployeeOwnImageBytes,request.EmployeeOwnImageBytesPaths,
                    request.EmployeeNIDImageBytes,request.EmployeeNIDImageBytesPaths,request.ResellerID
                   );
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
