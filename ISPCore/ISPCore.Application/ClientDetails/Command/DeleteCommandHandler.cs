﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ClientDetails.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ClientDetails.MarkAsDelete, ClientDetailsCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ClientDetails> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ClientDetails> _repository;
        public async Task<ClientDetailsCommandVM> Handle(Commands.ClientDetails.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ClientDetailsCommandVM
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
