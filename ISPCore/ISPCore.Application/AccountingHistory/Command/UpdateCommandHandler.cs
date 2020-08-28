using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountingHistory.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.AccountingHistory.Update, AccountingHistoryCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.AccountingHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AccountingHistory> _repository;
        public async Task<AccountingHistoryCommandVM> Handle(Commands.AccountingHistory.Update request, CancellationToken cancellationToken)
        {
            var response = new AccountingHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateAccountingHistory(request.AccountListID, request.PurchaseID, request.SalesID, request.DepositID, request.ExpenseID, request.ActionTypeID, request.DRCRTypeID, request.Amount, request.Year, request.Month, request.Day, request.Date, request.Description);

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
