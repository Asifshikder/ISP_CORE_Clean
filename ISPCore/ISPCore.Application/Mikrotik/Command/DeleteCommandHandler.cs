using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Mikrotik.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Mikrotik.MarkAsDelete, MikrotikCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Mikrotik> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Mikrotik> _repository;
        public async Task<MikrotikCommandVM> Handle(Commands.Mikrotik.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new MikrotikCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.MarkAsDelete();

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
