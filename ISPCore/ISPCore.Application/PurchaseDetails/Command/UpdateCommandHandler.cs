﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PurchaseDetails.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.PurchaseDetails.Update, PurchaseDetailsCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.PurchaseDetails> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PurchaseDetails> _repository;
        public async Task<PurchaseDetailsCommandVM> Handle(Commands.PurchaseDetails.Update request, CancellationToken cancellationToken)
        {
            var response = new PurchaseDetailsCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdatePurchaseDetails(request.PurchaseID, request.ItemID, request.Quantity, request.Price, request.Tax, request.HasWarrenty, request.WarrentyStart, request.WarrentyEnd, request.Serial);

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
