using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Mikrotik.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Mikrotik.Create, MikrotikCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Mikrotik> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Mikrotik> _repository;

        public async Task<MikrotikCommandVM> Handle(Commands.Mikrotik.Create request, CancellationToken cancellationToken)
        {
            var response = new MikrotikCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Mikrotik(request.MikrotikName,request.RealIP,request.MikUserName,request.MikPassword,request.APIPort,request.WebPort);
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
