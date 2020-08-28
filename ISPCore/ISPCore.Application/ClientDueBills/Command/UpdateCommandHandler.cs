using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientDueBills.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ClientDueBills.Update, ClientDueBillsCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ClientDueBills> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ClientDueBills> _repository;
        public async Task<ClientDueBillsCommandVM> Handle(Commands.ClientDueBills.Update request, CancellationToken cancellationToken)
        {
            var response = new ClientDueBillsCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateClientDueBills(request.ClientDetailsID, request.DueAmount, request.Year, request.Month);

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
