using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.MacResellerVSUserPaymentDeductionDetails.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.MacResellerVSUserPaymentDeductionDetails.Create, MacResellerVSUserPaymentDeductionDetailsCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.MacResellerVSUserPaymentDeductionDetails> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.MacResellerVSUserPaymentDeductionDetails> _repository;

        public async Task<MacResellerVSUserPaymentDeductionDetailsCommandVM> Handle(Commands.MacResellerVSUserPaymentDeductionDetails.Create request, CancellationToken cancellationToken)
        {
            var response = new MacResellerVSUserPaymentDeductionDetailsCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.MacResellerVSUserPaymentDeductionDetails(request.ClientDetailsID,request.ResellerID,request.PaymentYear,request.PaymentMonth,request.PaymentAmount,request.PaymentTime,request.PaymentTimeResellerBalance);
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
