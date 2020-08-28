using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableStock.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.CableStock.Update, CableStockCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.CableStock> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.CableStock> _repository;
        public async Task<CableStockCommandVM> Handle(Commands.CableStock.Update request, CancellationToken cancellationToken)
        {
            var response = new CableStockCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateCableStock(request.CableTypeID, request.BrandID, request.SupplierID, request.SupplierInvoice, request.FromReading, request.ToReading, request.CableUnitID, request.CableBoxName, request.CableQuantity, request.UsedQuantityFromThisBox, request.TotallyUsed, request.EmployeeID, request.IndicatorStatus);

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
