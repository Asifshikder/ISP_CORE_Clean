using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SecurityQuestion.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.SecurityQuestion.Update, SecurityQuestionCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.SecurityQuestion> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.SecurityQuestion> _repository;
        public async Task<SecurityQuestionCommandVM> Handle(Commands.SecurityQuestion.Update request, CancellationToken cancellationToken)
        {
            var response = new SecurityQuestionCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateSecurityQuestion(request.SecurityQuestionName);

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
