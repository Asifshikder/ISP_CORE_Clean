using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountOwner.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.AccountOwner.Update, AccountOwnerCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.AccountOwner> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AccountOwner> _repository;
        public async Task<AccountOwnerCommandVM> Handle(Commands.AccountOwner.Update request, CancellationToken cancellationToken)
        {
            var response = new AccountOwnerCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateAccountOwner(request.AccountOwnerName);

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
