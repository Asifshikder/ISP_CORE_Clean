using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.MacResellerVSUserPaymentDeductionDetails.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.MacResellerVSUserPaymentDeductionDetails.MarkAsDelete, MacResellerVSUserPaymentDeductionDetailsCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.MacResellerVSUserPaymentDeductionDetails> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.MacResellerVSUserPaymentDeductionDetails> _repository;
        public async Task<MacResellerVSUserPaymentDeductionDetailsCommandVM> Handle(Commands.MacResellerVSUserPaymentDeductionDetails.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new MacResellerVSUserPaymentDeductionDetailsCommandVM
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
