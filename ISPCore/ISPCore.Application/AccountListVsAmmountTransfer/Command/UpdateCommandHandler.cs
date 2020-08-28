using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountListVsAmmountTransfer.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.AccountListVsAmmountTransfer.Update, AccountListVsAmmountTransferCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.AccountListVsAmmountTransfer> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AccountListVsAmmountTransfer> _repository;
        public async Task<AccountListVsAmmountTransferCommandVM> Handle(Commands.AccountListVsAmmountTransfer.Update request, CancellationToken cancellationToken)
        {
            var response = new AccountListVsAmmountTransferCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateAccountListVsAmmountTransfer(request.FromAccountID, request.ToAccountID, request.TransferDate, request.CurrencyID, request.Amount, request.Description, request.Tags, request.PaymentByID, request.References, request.BreakDownAccountListID, request.TransferType);

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
