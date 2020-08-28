using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.MacResellerVSUserPaymentDeductionDetails.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.MacResellerVSUserPaymentDeductionDetails.Update, MacResellerVSUserPaymentDeductionDetailsCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.MacResellerVSUserPaymentDeductionDetails> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.MacResellerVSUserPaymentDeductionDetails> _repository;
        public async Task<MacResellerVSUserPaymentDeductionDetailsCommandVM> Handle(Commands.MacResellerVSUserPaymentDeductionDetails.Update request, CancellationToken cancellationToken)
        {
            var response = new MacResellerVSUserPaymentDeductionDetailsCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateMacResellerVSUserPaymentDeductionDetails(request.ClientDetailsID, request.ResellerID, request.PaymentYear, request.PaymentMonth, request.PaymentAmount, request.PaymentTime, request.PaymentTimeResellerBalance);

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
