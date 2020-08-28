using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeTransactionLockUnlock.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.EmployeeTransactionLockUnlock.Update, EmployeeTransactionLockUnlockCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.EmployeeTransactionLockUnlock> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.EmployeeTransactionLockUnlock> _repository;
        public async Task<EmployeeTransactionLockUnlockCommandVM> Handle(Commands.EmployeeTransactionLockUnlock.Update request, CancellationToken cancellationToken)
        {
            var response = new EmployeeTransactionLockUnlockCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateEmployeeTransactionLockUnlock(request.TransactionID, request.PackageID, request.Amount, request.AmountForReseller, request.FromDate, request.ToDate, request.LockOrUnlockDate, request.EmployeeID, request.ResellerID);

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
