using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentBy.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.PaymentBy.Create, PaymentByCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.PaymentBy> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PaymentBy> _repository;

        public async Task<PaymentByCommandVM> Handle(Commands.PaymentBy.Create request, CancellationToken cancellationToken)
        {
            var response = new PaymentByCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.PaymentBy(request.PaymentByName);
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
