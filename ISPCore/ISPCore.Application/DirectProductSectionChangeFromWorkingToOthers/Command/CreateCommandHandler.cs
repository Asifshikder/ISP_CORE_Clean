using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DirectProductSectionChangeFromWorkingToOthers.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.DirectProductSectionChangeFromWorkingToOthers.Create, DirectProductSectionChangeFromWorkingToOthersCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.DirectProductSectionChangeFromWorkingToOthers> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.DirectProductSectionChangeFromWorkingToOthers> _repository;

        public async Task<DirectProductSectionChangeFromWorkingToOthersCommandVM> Handle(Commands.DirectProductSectionChangeFromWorkingToOthers.Create request, CancellationToken cancellationToken)
        {
            var response = new DirectProductSectionChangeFromWorkingToOthersCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.DirectProductSectionChangeFromWorkingToOthers(request.ClientName,request.TakenEmployee,request.StockDetailsID,request.FromSection,request.ToSection,request.WhoChanged,request.ChangeDateTime);
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
