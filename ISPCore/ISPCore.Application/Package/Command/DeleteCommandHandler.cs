using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Package.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Package.MarkAsDelete, PackageCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Package> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Package> _repository;
        public async Task<PackageCommandVM> Handle(Commands.Package.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new PackageCommandVM
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
