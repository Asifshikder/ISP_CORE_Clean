using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientStockAssign.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ClientStockAssign.Create, ClientStockAssignCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ClientStockAssign> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ClientStockAssign> _repository;

        public async Task<ClientStockAssignCommandVM> Handle(Commands.ClientStockAssign.Create request, CancellationToken cancellationToken)
        {
            var response = new ClientStockAssignCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ClientStockAssign(request.StockDetailsID,request.EmployeeID);
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
