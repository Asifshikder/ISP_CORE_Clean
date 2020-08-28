using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.DirectProductSectionChangeFromWorkingToOthers.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.DirectProductSectionChangeFromWorkingToOthers.Update, DirectProductSectionChangeFromWorkingToOthersCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.DirectProductSectionChangeFromWorkingToOthers> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.DirectProductSectionChangeFromWorkingToOthers> _repository;
        public async Task<DirectProductSectionChangeFromWorkingToOthersCommandVM> Handle(Commands.DirectProductSectionChangeFromWorkingToOthers.Update request, CancellationToken cancellationToken)
        {
            var response = new DirectProductSectionChangeFromWorkingToOthersCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateDirectProductSectionChangeFromWorkingToOthers(request.ClientName, request.TakenEmployee, request.StockDetailsID, request.FromSection, request.ToSection, request.WhoChanged, request.ChangeDateTime);

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
