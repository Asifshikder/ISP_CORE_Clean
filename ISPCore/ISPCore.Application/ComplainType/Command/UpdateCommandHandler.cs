using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ComplainType.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ComplainType.Update, ComplainTypeCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ComplainType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ComplainType> _repository;
        public async Task<ComplainTypeCommandVM> Handle(Commands.ComplainType.Update request, CancellationToken cancellationToken)
        {
            var response = new ComplainTypeCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateComplainType(request.ComplainTypeName,request.ShowMessageBox);

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
