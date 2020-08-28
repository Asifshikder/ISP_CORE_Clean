using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.StockDetails.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.StockDetails.Update, StockDetailsCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.StockDetails> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.StockDetails> _repository;
        public async Task<StockDetailsCommandVM> Handle(Commands.StockDetails.Update request, CancellationToken cancellationToken)
        {
            var response = new StockDetailsCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateStockDetails(request.StockID, request.BrandID, request.SectionID, request.SupplierID, request.SupplierInvoice, request.Serial, request.BarCode, request.ProductStatusID, request.WarrentyProduct);

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
