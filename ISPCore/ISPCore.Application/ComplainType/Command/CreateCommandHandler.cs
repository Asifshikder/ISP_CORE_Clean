using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ComplainType.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ComplainType.Create, ComplainTypeCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ComplainType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ComplainType> _repository;

        public async Task<ComplainTypeCommandVM> Handle(Commands.ComplainType.Create request, CancellationToken cancellationToken)
        {
            var response = new ComplainTypeCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ComplainType(request.ComplainTypeName,request.ShowMessageBox);
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
