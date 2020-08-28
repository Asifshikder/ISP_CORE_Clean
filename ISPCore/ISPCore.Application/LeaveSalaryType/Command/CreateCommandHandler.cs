using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LeaveSalaryType.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.LeaveSalaryType.Create, LeaveSalaryTypeCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.LeaveSalaryType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.LeaveSalaryType> _repository;

        public async Task<LeaveSalaryTypeCommandVM> Handle(Commands.LeaveSalaryType.Create request, CancellationToken cancellationToken)
        {
            var response = new LeaveSalaryTypeCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.LeaveSalaryType(request.LeaveSalaryTypeName, request.Percentage);
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
