using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.BillGenerateHistory.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.BillGenerateHistory.Update, BillGenerateHistoryCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.BillGenerateHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.BillGenerateHistory> _repository;
        public async Task<BillGenerateHistoryCommandVM> Handle(Commands.BillGenerateHistory.Update request, CancellationToken cancellationToken)
        {
            var response = new BillGenerateHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateBillGenerateHistory(request.Year,request.Month);

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
