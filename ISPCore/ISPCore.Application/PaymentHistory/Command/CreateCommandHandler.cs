using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.PayementHistory.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.PayementHistory.Create, PayementHistoryCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.PayementHistory> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.PayementHistory> _repository;

        public async Task<PayementHistoryCommandVM> Handle(Commands.PayementHistory.Create request, CancellationToken cancellationToken)
        {
            var response = new PayementHistoryCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.PayementHistory(request.TransactionID,request.ClientDetailsID,request.EmployeeID,request.ResellerID,request.CollectByID,request.PaidAmount,request.ResetNo,request.AdvancePaymentID,request.PaymentByID,request.NormalPayment,request.DiscountPayment,request.PaymentFromWhichPage,request.BillAcceptBy,request.AcceptStatus);
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
