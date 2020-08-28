using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Reseller.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Reseller.Update, ResellerCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Reseller> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Reseller> _repository;
        public async Task<ResellerCommandVM> Handle(Commands.Reseller.Update request, CancellationToken cancellationToken)
        {
            var response = new ResellerCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateReseller(request.ResellerName, request.ResellerLoginName, request.ResellerBusinessName, request.ResellerPassword, request.ResellerTypeListID, request.ResellerAddress, request.ResellerContact,
                    request.ResellerBillingCycleList, request.ResellerLogo, request.ResellerLogoPath, request.BandwithReselleItemGivenWithPrice, request.MacReselleGivenPackageWithPrice, request.ResellerBalance, request.RoleID, request.UserRightPermissionID, request.MacResellerAssignMikrotik);

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
