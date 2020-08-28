using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ProfilePercentageFields.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ProfilePercentageFields.MarkAsDelete, ProfilePercentageFieldsCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ProfilePercentageFields> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ProfilePercentageFields> _repository;
        public async Task<ProfilePercentageFieldsCommandVM> Handle(Commands.ProfilePercentageFields.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ProfilePercentageFieldsCommandVM
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
