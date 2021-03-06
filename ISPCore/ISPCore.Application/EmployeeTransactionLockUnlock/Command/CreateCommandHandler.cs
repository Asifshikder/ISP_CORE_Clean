﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.EmployeeTransactionLockUnlock.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.EmployeeTransactionLockUnlock.Create, EmployeeTransactionLockUnlockCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.EmployeeTransactionLockUnlock> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.EmployeeTransactionLockUnlock> _repository;

        public async Task<EmployeeTransactionLockUnlockCommandVM> Handle(Commands.EmployeeTransactionLockUnlock.Create request, CancellationToken cancellationToken)
        {
            var response = new EmployeeTransactionLockUnlockCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.EmployeeTransactionLockUnlock(request.TransactionID,request.PackageID,request.Amount,request.AmountForReseller,request.FromDate,request.ToDate,request.LockOrUnlockDate,request.EmployeeID,request.ResellerID);
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
