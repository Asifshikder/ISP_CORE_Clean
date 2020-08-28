using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableStock.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.CableStock.Create, CableStockCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.CableStock> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.CableStock> _repository;

        public async Task<CableStockCommandVM> Handle(Commands.CableStock.Create request, CancellationToken cancellationToken)
        {
            var response = new CableStockCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.CableStock(request.CableTypeID,request.BrandID,request.SupplierID,request.SupplierInvoice,request.FromReading,request.ToReading,request.CableUnitID,request.CableBoxName,request.CableQuantity,request.UsedQuantityFromThisBox,request.TotallyUsed,request.EmployeeID,request.IndicatorStatus);
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
