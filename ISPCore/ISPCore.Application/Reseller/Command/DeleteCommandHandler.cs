using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Reseller.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Reseller.MarkAsDelete, ResellerCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Reseller> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Reseller> _repository;
        public async Task<ResellerCommandVM> Handle(Commands.Reseller.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ResellerCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.MarkAsDelete();

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
