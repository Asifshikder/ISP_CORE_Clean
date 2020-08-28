using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountListVsAmmountTransfer.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.AccountListVsAmmountTransfer.MarkAsDelete, AccountListVsAmmountTransferCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.AccountListVsAmmountTransfer> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.AccountListVsAmmountTransfer> _repository;
        public async Task<AccountListVsAmmountTransferCommandVM> Handle(Commands.AccountListVsAmmountTransfer.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new AccountListVsAmmountTransferCommandVM
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
