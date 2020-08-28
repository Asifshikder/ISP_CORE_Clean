﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LoginViewModel.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.LoginViewModel.MarkAsDelete, LoginViewModelCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.LoginViewModel> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.LoginViewModel> _repository;
        public async Task<LoginViewModelCommandVM> Handle(Commands.LoginViewModel.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new LoginViewModelCommandVM
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
