using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Item.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Item.Create, ItemCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Item> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Item> _repository;

        public async Task<ItemCommandVM> Handle(Commands.Item.Create request, CancellationToken cancellationToken)
        {
            var response = new ItemCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Item(request.ItemName, request.ItemFor,request.ItemCode);
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
