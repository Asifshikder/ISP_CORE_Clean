﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Asset.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Asset.MarkAsDelete, AssetCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Asset> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Asset> _repository;
        public async Task<AssetCommandVM> Handle(Commands.Asset.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new AssetCommandVM
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
