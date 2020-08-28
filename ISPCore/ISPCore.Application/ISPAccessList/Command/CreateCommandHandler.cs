using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ISPAccessList.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ISPAccessList.Create, ISPAccessListCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ISPAccessList> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ISPAccessList> _repository;

        public async Task<ISPAccessListCommandVM> Handle(Commands.ISPAccessList.Create request, CancellationToken cancellationToken)
        {
            var response = new ISPAccessListCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ISPAccessList(request.AccessName,request.AccessValue,request.IsGranted);
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
