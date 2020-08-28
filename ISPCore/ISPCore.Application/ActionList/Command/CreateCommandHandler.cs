using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ActionList.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ActionList.Create, ActionListCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ActionList> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ActionList> _repository;

        public async Task<ActionListCommandVM> Handle(Commands.ActionList.Create request, CancellationToken cancellationToken)
        {
            var response = new ActionListCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ActionList(request.FormID,request.ActionName,request.ActionValue,request.ActionDescription);
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
