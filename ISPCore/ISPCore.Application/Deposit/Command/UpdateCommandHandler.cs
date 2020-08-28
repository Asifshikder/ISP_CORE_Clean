using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Deposit.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Deposit.Update, DepositCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Deposit> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Deposit> _repository;
        public async Task<DepositCommandVM> Handle(Commands.Deposit.Update request, CancellationToken cancellationToken)
        {
            var response = new DepositCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateDeposit(request.Descriptions, request.DescriptionFileByte, request.DescriptionFilePath, request.HeadID, request.Amount, request.PaymentDate, request.CompanyID, request.AccountListID, request.PayerID, request.PaymentByID, request.DepositStatus, request.References, request.ResellerID);

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
