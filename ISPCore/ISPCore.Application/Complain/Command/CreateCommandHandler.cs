using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Complain.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Complain.Create, ComplainCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Complain> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Complain> _repository;

        public async Task<ComplainCommandVM> Handle(Commands.Complain.Create request, CancellationToken cancellationToken)
        {
            var response = new ComplainCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Complain(request.ClientDetailsID,request.TokenNo,request.MonthlySerialNo,request.ComplainDetails,request.EmployeeID,request.ResellerID,request.LineStatusID,request.ComplainTypeID,request.WhichOrWhere,request.ComplainOpenBy,request.ComplainTime,request.OnRequest);
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
