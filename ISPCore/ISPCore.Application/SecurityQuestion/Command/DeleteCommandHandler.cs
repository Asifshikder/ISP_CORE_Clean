﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SecurityQuestion.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.SecurityQuestion.MarkAsDelete, SecurityQuestionCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.SecurityQuestion> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.SecurityQuestion> _repository;
        public async Task<SecurityQuestionCommandVM> Handle(Commands.SecurityQuestion.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new SecurityQuestionCommandVM
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
