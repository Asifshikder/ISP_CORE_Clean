using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Zone.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Zone.Create, ZoneCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Zone> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Zone> _repository;

        public async Task<ZoneCommandVM> Handle(Commands.Zone.Create request, CancellationToken cancellationToken)
        {
            var response = new ZoneCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Zone(request.ZoneName,request.ResellerID);
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
