using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Reseller.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Reseller.Create, ResellerCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Reseller> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Reseller> _repository;

        public async Task<ResellerCommandVM> Handle(Commands.Reseller.Create request, CancellationToken cancellationToken)
        {
            var response = new ResellerCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Reseller(request.ResellerName,request.ResellerLoginName,request.ResellerBusinessName,request.ResellerPassword,request.ResellerTypeListID,request.ResellerAddress,request.ResellerContact,
                    request.ResellerBillingCycleList,request.ResellerLogo,request.ResellerLogoPath,request.BandwithReselleItemGivenWithPrice,request.MacReselleGivenPackageWithPrice,request.ResellerBalance,request.RoleID,request.UserRightPermissionID,request.MacResellerAssignMikrotik);
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
