using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableType.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.CableType.Update, CableTypeCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.CableType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.CableType> _repository;
        public async Task<CableTypeCommandVM> Handle(Commands.CableType.Update request, CancellationToken cancellationToken)
        {
            var response = new CableTypeCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateCableType(request.CableTypeName);

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
