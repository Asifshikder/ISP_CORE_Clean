using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Distribution_Transaction.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Distribution_Transaction.Update, Distribution_TransactionCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Distribution_Transaction> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Distribution_Transaction> _repository;
        public async Task<Distribution_TransactionCommandVM> Handle(Commands.Distribution_Transaction.Update request, CancellationToken cancellationToken)
        {
            var response = new Distribution_TransactionCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateDistribution_Transaction(request.StockDetailsID, request.SectionID, request.ProductStatusID, request.ItemName, request.BrandName, request.Serial, request.ClientName, request.EmployeeName, request.SectionName, request.ProductStatus);

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
