using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountListVsAmmountTransfer.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.AccountListVsAmmountTransfer.Create, AccountListVsAmmountTransferCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.AccountListVsAmmountTransfer> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AccountListVsAmmountTransfer> _repository;

        public async Task<AccountListVsAmmountTransferCommandVM> Handle(Commands.AccountListVsAmmountTransfer.Create request, CancellationToken cancellationToken)
        {
            var response = new AccountListVsAmmountTransferCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.AccountListVsAmmountTransfer(request.FromAccountID,request.ToAccountID,request.TransferDate,request.CurrencyID,request.Amount,request.Description,request.Tags,request.PaymentByID,request.References,request.BreakDownAccountListID,request.TransferType);
                var data = await _repository.AddAsync(entity);

                response.Status = true;
                response.Message = "entity created successfully.";
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
