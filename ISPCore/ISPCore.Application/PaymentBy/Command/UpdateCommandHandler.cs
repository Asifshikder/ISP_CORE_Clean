using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentBy.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.PaymentBy.Update, PaymentByCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.PaymentBy> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PaymentBy> _repository;
        public async Task<PaymentByCommandVM> Handle(Commands.PaymentBy.Update request, CancellationToken cancellationToken)
        {
            var response = new PaymentByCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdatePaymentBy(request.PaymentByName);

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
