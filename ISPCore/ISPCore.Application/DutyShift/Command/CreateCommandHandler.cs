using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DutyShift.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.DutyShift.Create, DutyShiftCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.DutyShift> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.DutyShift> _repository;

        public async Task<DutyShiftCommandVM> Handle(Commands.DutyShift.Create request, CancellationToken cancellationToken)
        {
            var response = new DutyShiftCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.DutyShift(request.StartHour,request.StartMinute,request.EndHour,request.EndMinute);
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
