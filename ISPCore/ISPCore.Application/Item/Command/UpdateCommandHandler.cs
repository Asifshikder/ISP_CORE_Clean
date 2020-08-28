using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Item.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Item.Update, ItemCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Item> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Item> _repository;
        public async Task<ItemCommandVM> Handle(Commands.Item.Update request, CancellationToken cancellationToken)
        {
            var response = new ItemCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateItem(request.ItemName, request.ItemFor, request.ItemCode);

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
