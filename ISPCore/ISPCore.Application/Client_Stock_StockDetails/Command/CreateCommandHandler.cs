using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Client_Stock_StockDetails.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Client_Stock_StockDetails.Create, Client_Stock_StockDetailsCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Client_Stock_StockDetails> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Client_Stock_StockDetails> _repository;

        public async Task<Client_Stock_StockDetailsCommandVM> Handle(Commands.Client_Stock_StockDetails.Create request, CancellationToken cancellationToken)
        {
            var response = new Client_Stock_StockDetailsCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Client_Stock_StockDetails(request.StockID,request.StockDetailsID,request.ItemID,request.ItemName,request.BrandID,request.BrandName,request.SupplierID,request.SupplierName,request.SupplierInvoice,request.Serial,request.WarrentyProduct);
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
