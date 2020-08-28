using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ProfilePercentageFields.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.ProfilePercentageFields.Create, ProfilePercentageFieldsCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.ProfilePercentageFields> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ProfilePercentageFields> _repository;

        public async Task<ProfilePercentageFieldsCommandVM> Handle(Commands.ProfilePercentageFields.Create request, CancellationToken cancellationToken)
        {
            var response = new ProfilePercentageFieldsCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.ProfilePercentageFields(request.FieldsName,request.TableName,request.MappingField);
                var data = await _repository.AddAsync(entity);

                response.Status = true;
                response.Message = "entity created successfully.";
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
