using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountList.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.AccountList.Update, AccountListCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.AccountList> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AccountList> _repository;
        public async Task<AccountListCommandVM> Handle(Commands.AccountList.Update request, CancellationToken cancellationToken)
        {
            var response = new AccountListCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateAccountList(request.AccountTitle, request.Description, request.InitialBalance, request.AccountNumber, request.ContactPerson, request.Phone, request.BankURL, request.OwnerID);

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
