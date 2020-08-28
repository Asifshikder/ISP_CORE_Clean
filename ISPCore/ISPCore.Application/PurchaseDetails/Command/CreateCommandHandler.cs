using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PurchaseDetails.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.PurchaseDetails.Create, PurchaseDetailsCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.PurchaseDetails> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PurchaseDetails> _repository;

        public async Task<PurchaseDetailsCommandVM> Handle(Commands.PurchaseDetails.Create request, CancellationToken cancellationToken)
        {
            var response = new PurchaseDetailsCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.PurchaseDetails(request.PurchaseID,request.ItemID,request.Quantity,request.Price,request.Tax,request.HasWarrenty,request.WarrentyStart,request.WarrentyEnd,request.Serial);
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
