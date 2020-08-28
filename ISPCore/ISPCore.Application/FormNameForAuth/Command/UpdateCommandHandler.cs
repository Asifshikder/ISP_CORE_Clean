using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.FormNameForAuth.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.FormNameForAuth.Update, FormNameForAuthCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.FormNameForAuth> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.FormNameForAuth> _repository;
        public async Task<FormNameForAuthCommandVM> Handle(Commands.FormNameForAuth.Update request, CancellationToken cancellationToken)
        {
            var response = new FormNameForAuthCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateFormNameForAuth(request.FormName, request.IsGranted, request.ID, request.Text, request.@Checked);

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
