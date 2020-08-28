using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.BillGenerateHistory.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.BillGenerateHistory.Create, BillGenerateHistoryCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.BillGenerateHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.BillGenerateHistory> _repository;

        public async Task<BillGenerateHistoryCommandVM> Handle(Commands.BillGenerateHistory.Create request, CancellationToken cancellationToken)
        {
            var response = new BillGenerateHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.BillGenerateHistory(request.Year,request.Month);
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
