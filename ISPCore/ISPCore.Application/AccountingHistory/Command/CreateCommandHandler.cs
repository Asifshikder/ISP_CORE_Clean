using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountingHistory.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.AccountingHistory.Create, AccountingHistoryCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.AccountingHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AccountingHistory> _repository;

        public async Task<AccountingHistoryCommandVM> Handle(Commands.AccountingHistory.Create request, CancellationToken cancellationToken)
        {
            var response = new AccountingHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.AccountingHistory(request.AccountListID,request.PurchaseID,request.SalesID,request.DepositID,request.ExpenseID,request.ActionTypeID,request.DRCRTypeID,request.Amount,request.Year,request.Month,request.Day,request.Date,request.Description);
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
