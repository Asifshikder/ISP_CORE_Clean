using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Item.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Item.MarkAsDelete, ItemCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Item> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Item> _repository;
        public async Task<ItemCommandVM> Handle(Commands.Item.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ItemCommandVM
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
