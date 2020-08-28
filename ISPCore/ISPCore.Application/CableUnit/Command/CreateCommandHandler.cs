using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableUnit.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.CableUnit.Create, CableUnitCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.CableUnit> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.CableUnit> _repository;

        public async Task<CableUnitCommandVM> Handle(Commands.CableUnit.Create request, CancellationToken cancellationToken)
        {
            var response = new CableUnitCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.CableUnit(request.CableUnitName);
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
