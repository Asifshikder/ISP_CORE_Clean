using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentFrom.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.PaymentFrom.Create, PaymentFromCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.PaymentFrom> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PaymentFrom> _repository;

        public async Task<PaymentFromCommandVM> Handle(Commands.PaymentFrom.Create request, CancellationToken cancellationToken)
        {
            var response = new PaymentFromCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.PaymentFrom(request.PaymentFromName);
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
