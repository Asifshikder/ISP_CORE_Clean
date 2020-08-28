using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Form.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Form.Create, FormCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Form> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Form> _repository;

        public async Task<FormCommandVM> Handle(Commands.Form.Create request, CancellationToken cancellationToken)
        {
            var response = new FormCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Form(request.FormName,request.ControllerNameID,request.FormValue,request.FormDescription,request.FormLocation);
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
