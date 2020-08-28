using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SecurityQuestion.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.SecurityQuestion.Create, SecurityQuestionCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.SecurityQuestion> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.SecurityQuestion> _repository;

        public async Task<SecurityQuestionCommandVM> Handle(Commands.SecurityQuestion.Create request, CancellationToken cancellationToken)
        {
            var response = new SecurityQuestionCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.SecurityQuestion(request.SecurityQuestionName);
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
