using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientDueBills.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ClientDueBills.Create, ClientDueBillsCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ClientDueBills> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ClientDueBills> _repository;

        public async Task<ClientDueBillsCommandVM> Handle(Commands.ClientDueBills.Create request, CancellationToken cancellationToken)
        {
            var response = new ClientDueBillsCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ClientDueBills(request.ClientDetailsID,request.DueAmount,request.Year,request.Month);
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
