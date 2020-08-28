using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Expense.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Expense.Create, ExpenseCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Expense> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Expense> _repository;

        public async Task<ExpenseCommandVM> Handle(Commands.Expense.Create request, CancellationToken cancellationToken)
        {
            var response = new ExpenseCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Expense(request.Descriptions,request.DescriptionFileByte,request.DescriptionFilePath,request.HeadID,request.Amount,request.PaymentDate,request.CompanyID,request.AccountListID,request.PayerID,request.PaymentByID,request.ExpenseStatus,request.References,request.ResellerID);
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
