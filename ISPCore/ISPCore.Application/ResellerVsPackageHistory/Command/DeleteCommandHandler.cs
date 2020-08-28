using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerVsPackageHistory.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.ResellerVsPackageHistory.MarkAsDelete, ResellerVsPackageHistoryCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.ResellerVsPackageHistory> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.ResellerVsPackageHistory> _repository;
        public async Task<ResellerVsPackageHistoryCommandVM> Handle(Commands.ResellerVsPackageHistory.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new ResellerVsPackageHistoryCommandVM
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
