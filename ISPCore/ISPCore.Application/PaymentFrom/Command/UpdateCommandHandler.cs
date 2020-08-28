﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PaymentFrom.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.PaymentFrom.Update, PaymentFromCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.PaymentFrom> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PaymentFrom> _repository;
        public async Task<PaymentFromCommandVM> Handle(Commands.PaymentFrom.Update request, CancellationToken cancellationToken)
        {
            var response = new PaymentFromCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdatePaymentFrom(request.PaymentFromName);

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
