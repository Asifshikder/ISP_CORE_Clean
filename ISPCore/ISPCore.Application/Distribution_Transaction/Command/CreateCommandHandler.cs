using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Distribution_Transaction.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Distribution_Transaction.Create, Distribution_TransactionCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Distribution_Transaction> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Distribution_Transaction> _repository;

        public async Task<Distribution_TransactionCommandVM> Handle(Commands.Distribution_Transaction.Create request, CancellationToken cancellationToken)
        {
            var response = new Distribution_TransactionCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Distribution_Transaction(request.StockDetailsID,request.SectionID,request.ProductStatusID,request.ItemName,request.BrandName,request.Serial,request.ClientName,request.EmployeeName,request.SectionName,request.ProductStatus);
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
