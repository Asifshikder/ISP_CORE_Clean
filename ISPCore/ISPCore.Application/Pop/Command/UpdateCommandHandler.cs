using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Pop.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Pop.Update, PopCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Pop> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Pop> _repository;
        public async Task<PopCommandVM> Handle(Commands.Pop.Update request, CancellationToken cancellationToken)
        {
            var response = new PopCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdatePop(request.PopName,request.PopLocation);

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
