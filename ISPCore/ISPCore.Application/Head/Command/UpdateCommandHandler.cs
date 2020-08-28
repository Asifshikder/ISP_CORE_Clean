using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Head.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Head.Update, HeadCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Head> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Head> _repository;
        public async Task<HeadCommandVM> Handle(Commands.Head.Update request, CancellationToken cancellationToken)
        {
            var response = new HeadCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateHead(request.HeadName,request.HeadTypeID,request.ResellerID);

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
