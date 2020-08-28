using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientStockAssign.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ClientStockAssign.Update, ClientStockAssignCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ClientStockAssign> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ClientStockAssign> _repository;
        public async Task<ClientStockAssignCommandVM> Handle(Commands.ClientStockAssign.Update request, CancellationToken cancellationToken)
        {
            var response = new ClientStockAssignCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateClientStockAssign(request.StockDetailsID,request.EmployeeID);

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
