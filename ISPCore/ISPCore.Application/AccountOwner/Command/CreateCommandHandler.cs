using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountOwner.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.AccountOwner.Create, AccountOwnerCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.AccountOwner> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AccountOwner> _repository;

        public async Task<AccountOwnerCommandVM> Handle(Commands.AccountOwner.Create request, CancellationToken cancellationToken)
        {
            var response = new AccountOwnerCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.AccountOwner(request.AccountOwnerName);
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
