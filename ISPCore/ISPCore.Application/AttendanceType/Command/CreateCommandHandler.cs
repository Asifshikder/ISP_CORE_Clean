using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AttendanceType.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.AttendanceType.Create, AttendanceTypeCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.AttendanceType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AttendanceType> _repository;

        public async Task<AttendanceTypeCommandVM> Handle(Commands.AttendanceType.Create request, CancellationToken cancellationToken)
        {
            var response = new AttendanceTypeCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.AttendanceType(request.AttendanceTypeName);
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
