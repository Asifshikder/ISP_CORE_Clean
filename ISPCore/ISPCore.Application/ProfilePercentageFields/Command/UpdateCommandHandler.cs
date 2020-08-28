using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ProfilePercentageFields.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ProfilePercentageFields.Update, ProfilePercentageFieldsCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ProfilePercentageFields> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ProfilePercentageFields> _repository;
        public async Task<ProfilePercentageFieldsCommandVM> Handle(Commands.ProfilePercentageFields.Update request, CancellationToken cancellationToken)
        {
            var response = new ProfilePercentageFieldsCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateProfilePercentageFields(request.FieldsName, request.TableName, request.MappingField);

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
