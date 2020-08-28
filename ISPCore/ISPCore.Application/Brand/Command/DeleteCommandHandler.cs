using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Brand.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Brand.MarkAsDelete, BrandCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Brand> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Brand> _repository;
        public async Task<BrandCommandVM> Handle(Commands.Brand.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new BrandCommandVM
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
