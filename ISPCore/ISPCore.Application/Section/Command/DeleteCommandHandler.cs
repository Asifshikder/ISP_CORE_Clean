﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Section.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Section.MarkAsDelete, SectionCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Section> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Section> _repository;
        public async Task<SectionCommandVM> Handle(Commands.Section.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new SectionCommandVM
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
