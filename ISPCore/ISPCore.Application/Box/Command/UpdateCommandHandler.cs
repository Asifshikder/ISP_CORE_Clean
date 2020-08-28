using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Box.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Box.Update, BoxCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Box> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Box> _repository;
        public async Task<BoxCommandVM> Handle(Commands.Box.Update request, CancellationToken cancellationToken)
        {
            var response = new BoxCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateBox(request.BoxName, request.ResellerID, request.BoxLocation);

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
