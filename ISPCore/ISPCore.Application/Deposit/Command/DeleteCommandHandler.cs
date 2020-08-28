using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Deposit.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Deposit.MarkAsDelete, DepositCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Deposit> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Deposit> _repository;
        public async Task<DepositCommandVM> Handle(Commands.Deposit.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new DepositCommandVM
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
