using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Expense.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Expense.Update, ExpenseCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Expense> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Expense> _repository;
        public async Task<ExpenseCommandVM> Handle(Commands.Expense.Update request, CancellationToken cancellationToken)
        {
            var response = new ExpenseCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateExpense(request.Descriptions, request.DescriptionFileByte, request.DescriptionFilePath, request.HeadID, request.Amount, request.PaymentDate, request.CompanyID, request.AccountListID, request.PayerID, request.PaymentByID, request.ExpenseStatus, request.References, request.ResellerID);

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
