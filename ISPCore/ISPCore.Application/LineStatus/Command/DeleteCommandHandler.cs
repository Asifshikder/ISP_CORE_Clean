﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LineStatus.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.LineStatus.MarkAsDelete, LineStatusCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.LineStatus> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.LineStatus> _repository;
        public async Task<LineStatusCommandVM> Handle(Commands.LineStatus.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new LineStatusCommandVM
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
