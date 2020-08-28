using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AccountList.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.AccountList.MarkAsDelete, AccountListCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.AccountList> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.AccountList> _repository;
        public async Task<AccountListCommandVM> Handle(Commands.AccountList.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new AccountListCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.MarkAsDelete();

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
