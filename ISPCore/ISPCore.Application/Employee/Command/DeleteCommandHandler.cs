using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Employee.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Employee.MarkAsDelete, EmployeeCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Employee> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Employee> _repository;
        public async Task<EmployeeCommandVM> Handle(Commands.Employee.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new EmployeeCommandVM
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
