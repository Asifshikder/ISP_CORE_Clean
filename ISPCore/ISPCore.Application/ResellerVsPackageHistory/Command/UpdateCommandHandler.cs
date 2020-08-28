using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.ResellerVsPackageHistory.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.ResellerVsPackageHistory.Update, ResellerVsPackageHistoryCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.ResellerVsPackageHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.ResellerVsPackageHistory> _repository;
        public async Task<ResellerVsPackageHistoryCommandVM> Handle(Commands.ResellerVsPackageHistory.Update request, CancellationToken cancellationToken)
        {
            var response = new ResellerVsPackageHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateResellerVsPackageHistory(request.ResellerID, request.ResellerName, request.ResellerPackageID, request.PackageName, request.PackagePrice);

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
