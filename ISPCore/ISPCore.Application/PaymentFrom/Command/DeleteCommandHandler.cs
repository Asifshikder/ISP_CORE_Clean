using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentFrom.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.PaymentFrom.MarkAsDelete, PaymentFromCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.PaymentFrom> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.PaymentFrom> _repository;
        public async Task<PaymentFromCommandVM> Handle(Commands.PaymentFrom.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new PaymentFromCommandVM
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
