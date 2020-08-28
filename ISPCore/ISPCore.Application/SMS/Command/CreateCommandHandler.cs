using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SMS.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.SMS.Create, SMSCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.SMS> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.SMS> _repository;

        public async Task<SMSCommandVM> Handle(Commands.SMS.Create request, CancellationToken cancellationToken)
        {
            var response = new SMSCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.SMS(request.SMSTitle,request.SendMessageText,request.SMSCode,request.Sender,request.SMSStatus,request.SMSCounter);
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
