using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountList.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.AccountList.Create, AccountListCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.AccountList> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AccountList> _repository;

        public async Task<AccountListCommandVM> Handle(Commands.AccountList.Create request, CancellationToken cancellationToken)
        {
            var response = new AccountListCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.AccountList(request.AccountTitle,request.Description,request.InitialBalance,request.AccountNumber,request.ContactPerson,request.Phone,request.BankURL,request.OwnerID);
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
