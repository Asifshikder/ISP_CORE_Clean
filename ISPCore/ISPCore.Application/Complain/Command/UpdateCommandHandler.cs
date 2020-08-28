using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Complain.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Complain.Update, ComplainCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Complain> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Complain> _repository;
        public async Task<ComplainCommandVM> Handle(Commands.Complain.Update request, CancellationToken cancellationToken)
        {
            var response = new ComplainCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateComplain(request.ClientDetailsID, request.TokenNo, request.MonthlySerialNo, request.ComplainDetails, request.EmployeeID, request.ResellerID, request.LineStatusID, request.ComplainTypeID, request.WhichOrWhere, request.ComplainOpenBy, request.ComplainTime, request.OnRequest);

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
