using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.GivenPaymentType.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.GivenPaymentType.Create, GivenPaymentTypeCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.GivenPaymentType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.GivenPaymentType> _repository;

        public async Task<GivenPaymentTypeCommandVM> Handle(Commands.GivenPaymentType.Create request, CancellationToken cancellationToken)
        {
            var response = new GivenPaymentTypeCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.GivenPaymentType(request.GivenPaymentTypeName);
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
