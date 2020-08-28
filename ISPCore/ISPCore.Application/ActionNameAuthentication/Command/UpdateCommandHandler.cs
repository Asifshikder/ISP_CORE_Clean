using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ActionNameAuthentication.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ActionNameAuthentication.Update, ActionNameAuthenticationCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ActionNameAuthentication> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ActionNameAuthentication> _repository;
        public async Task<ActionNameAuthenticationCommandVM> Handle(Commands.ActionNameAuthentication.Update request, CancellationToken cancellationToken)
        {
            var response = new ActionNameAuthenticationCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateActionNameAuthentication(request.ActionName,request.IsGranted,request.ID,request.Text,request.Checked);

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
