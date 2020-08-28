using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Departement.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Departement.Create, DepartementCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Department> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Department> _repository;

        public async Task<DepartementCommandVM> Handle(Commands.Departement.Create request, CancellationToken cancellationToken)
        {
            var response = new DepartementCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Department(request.DepartementName);
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
