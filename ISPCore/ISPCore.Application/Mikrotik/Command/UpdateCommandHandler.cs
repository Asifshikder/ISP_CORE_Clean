using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Mikrotik.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Mikrotik.Update, MikrotikCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Mikrotik> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Mikrotik> _repository;
        public async Task<MikrotikCommandVM> Handle(Commands.Mikrotik.Update request, CancellationToken cancellationToken)
        {
            var response = new MikrotikCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateMikrotik(request.MikrotikName, request.RealIP, request.MikUserName, request.MikPassword, request.APIPort, request.WebPort);

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
