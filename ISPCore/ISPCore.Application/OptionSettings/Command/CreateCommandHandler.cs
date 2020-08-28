﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.OptionSettings.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.OptionSettings.Create, OptionSettingsCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.OptionSettings> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.OptionSettings> _repository;

        public async Task<OptionSettingsCommandVM> Handle(Commands.OptionSettings.Create request, CancellationToken cancellationToken)
        {
            var response = new OptionSettingsCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.OptionSettings(request.OptionSettingsName);
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
