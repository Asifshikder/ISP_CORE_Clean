﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentType.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.PaymentType.Update, PaymentTypeCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.PaymentType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PaymentType> _repository;
        public async Task<PaymentTypeCommandVM> Handle(Commands.PaymentType.Update request, CancellationToken cancellationToken)
        {
            var response = new PaymentTypeCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdatePaymentType(request.PaymentTypeName);

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
