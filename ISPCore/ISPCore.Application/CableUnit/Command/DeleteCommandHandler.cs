﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CableUnit.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.CableUnit.MarkAsDelete, CableUnitCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.CableUnit> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.CableUnit> _repository;
        public async Task<CableUnitCommandVM> Handle(Commands.CableUnit.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new CableUnitCommandVM
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
