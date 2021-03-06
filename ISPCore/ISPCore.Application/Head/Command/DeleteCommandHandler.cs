﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Head.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Head.MarkAsDelete, HeadCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Head> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Head> _repository;
        public async Task<HeadCommandVM> Handle(Commands.Head.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new HeadCommandVM
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
