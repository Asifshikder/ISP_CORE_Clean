using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AdvancePayment.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.AdvancePayment.Create, AdvancePaymentCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.AdvancePayment> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AdvancePayment> _repository;

        public async Task<AdvancePaymentCommandVM> Handle(Commands.AdvancePayment.Create request, CancellationToken cancellationToken)
        {
            var response = new AdvancePaymentCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.AdvancePayment(request.ClientDetailsID,request.AdvanceAmount,request.Remarks,request.CollectBy);
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
