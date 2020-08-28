using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountingHistory.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.AccountingHistory.MarkAsDelete, AccountingHistoryCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.AccountingHistory> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.AccountingHistory> _repository;
        public async Task<AccountingHistoryCommandVM> Handle(Commands.AccountingHistory.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new AccountingHistoryCommandVM
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
