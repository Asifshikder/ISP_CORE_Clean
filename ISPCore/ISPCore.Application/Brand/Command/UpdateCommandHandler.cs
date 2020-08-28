using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Brand.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Brand.Update, BrandCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Brand> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Brand> _repository;
        public async Task<BrandCommandVM> Handle(Commands.Brand.Update request, CancellationToken cancellationToken)
        {
            var response = new BrandCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateBrand(request.BrandName);

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
