using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Purchase.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Purchase.Create, PurchaseCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Purchase> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Purchase> _repository;

        public async Task<PurchaseCommandVM> Handle(Commands.Purchase.Create request, CancellationToken cancellationToken)
        {
            var response = new PurchaseCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Purchase(request.Subject,request.SupplierID,request.PublishStatus,request.InvoicePrefix,request.InvoiceID,request.IssuedAt,request.SupplierNoted,request.SubTotal,request.DiscountType,request.DiscountPercentOrFixedAmount,request.DiscountAmount,request.Discount,request.Tax,request.Total,request.PurchasePayment,request.ResellerID,request.PurchaseStatus);
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
