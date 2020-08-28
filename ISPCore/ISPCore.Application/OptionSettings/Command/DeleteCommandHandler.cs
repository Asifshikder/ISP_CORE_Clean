using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.OptionSettings.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.OptionSettings.MarkAsDelete, OptionSettingsCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.OptionSettings> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.OptionSettings> _repository;
        public async Task<OptionSettingsCommandVM> Handle(Commands.OptionSettings.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new OptionSettingsCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.MarkAsDelete();

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
