using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientDueBills.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ClientDueBills.MarkAsDelete, ClientDueBillsCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ClientDueBills> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ClientDueBills> _repository;
        public async Task<ClientDueBillsCommandVM> Handle(Commands.ClientDueBills.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ClientDueBillsCommandVM
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
