using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.GivenPaymentType.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.GivenPaymentType.Update, GivenPaymentTypeCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.GivenPaymentType> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.GivenPaymentType> _repository;
        public async Task<GivenPaymentTypeCommandVM> Handle(Commands.GivenPaymentType.Update request, CancellationToken cancellationToken)
        {
            var response = new GivenPaymentTypeCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateGivenPaymentType(request.GivenPaymentTypeName);

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
