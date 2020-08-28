using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Complain.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Complain.MarkAsDelete, ComplainCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Complain> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Complain> _repository;
        public async Task<ComplainCommandVM> Handle(Commands.Complain.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ComplainCommandVM
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
