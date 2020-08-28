using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SMSSenderIDPass.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.SMSSenderIDPass.Update, SMSSenderIDPassCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.SMSSenderIDPass> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.SMSSenderIDPass> _repository;
        public async Task<SMSSenderIDPassCommandVM> Handle(Commands.SMSSenderIDPass.Update request, CancellationToken cancellationToken)
        {
            var response = new SMSSenderIDPassCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateSMSSenderIDPass(request.SenderID, request.Pass, request.Sender, request.CompanyName, request.HelpLine);

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
