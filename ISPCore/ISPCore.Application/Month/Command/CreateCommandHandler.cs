﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Month.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Month.Create, MonthCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Month> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Month> _repository;

        public async Task<MonthCommandVM> Handle(Commands.Month.Create request, CancellationToken cancellationToken)
        {
            var response = new MonthCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Month(request.MonthName);
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
