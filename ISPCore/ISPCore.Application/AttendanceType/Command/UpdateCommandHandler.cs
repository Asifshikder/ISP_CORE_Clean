using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AttendanceType.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.AttendanceType.Update, AttendanceTypeCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.AttendanceType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AttendanceType> _repository;
        public async Task<AttendanceTypeCommandVM> Handle(Commands.AttendanceType.Update request, CancellationToken cancellationToken)
        {
            var response = new AttendanceTypeCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateAttendanceType(request.AttendanceTypeName);

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
