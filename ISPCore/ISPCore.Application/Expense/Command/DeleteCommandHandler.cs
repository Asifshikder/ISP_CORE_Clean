﻿using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Expense.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Expense.MarkAsDelete, ExpenseCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Expense> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Expense> _repository;
        public async Task<ExpenseCommandVM> Handle(Commands.Expense.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ExpenseCommandVM
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
