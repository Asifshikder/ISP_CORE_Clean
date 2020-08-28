using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentType.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.PaymentType.Create, PaymentTypeCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.PaymentType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PaymentType> _repository;

        public async Task<PaymentTypeCommandVM> Handle(Commands.PaymentType.Create request, CancellationToken cancellationToken)
        {
            var response = new PaymentTypeCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.PaymentType(request.PaymentTypeName);
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
