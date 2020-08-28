using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PayementHistory.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.PayementHistory.MarkAsDelete, PayementHistoryCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.PayementHistory> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.PayementHistory> _repository;
        public async Task<PayementHistoryCommandVM> Handle(Commands.PayementHistory.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new PayementHistoryCommandVM
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
