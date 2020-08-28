using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SMS.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.SMS.Update, SMSCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.SMS> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.SMS> _repository;
        public async Task<SMSCommandVM> Handle(Commands.SMS.Update request, CancellationToken cancellationToken)
        {
            var response = new SMSCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateSMS(request.SMSTitle, request.SendMessageText, request.SMSCode, request.Sender, request.SMSStatus, request.SMSCounter);

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
