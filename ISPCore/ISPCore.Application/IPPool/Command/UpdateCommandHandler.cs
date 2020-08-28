using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.IPPool.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.IPPool.Update, IPPoolCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.IPPool> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.IPPool> _repository;
        public async Task<IPPoolCommandVM> Handle(Commands.IPPool.Update request, CancellationToken cancellationToken)
        {
            var response = new IPPoolCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateIPPool(request.IPPoolName,request.StartRange,request.EndRange);

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
