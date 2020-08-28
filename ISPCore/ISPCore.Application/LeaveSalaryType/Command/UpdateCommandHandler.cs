using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LeaveSalaryType.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.LeaveSalaryType.Update, LeaveSalaryTypeCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.LeaveSalaryType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.LeaveSalaryType> _repository;
        public async Task<LeaveSalaryTypeCommandVM> Handle(Commands.LeaveSalaryType.Update request, CancellationToken cancellationToken)
        {
            var response = new LeaveSalaryTypeCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateLeaveSalaryType(request.LeaveSalaryTypeName,request.Percentage);

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
