using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CompanyVsPayer.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.CompanyVsPayer.Update, CompanyVsPayerCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.CompanyVsPayer> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.CompanyVsPayer> _repository;
        public async Task<CompanyVsPayerCommandVM> Handle(Commands.CompanyVsPayer.Update request, CancellationToken cancellationToken)
        {
            var response = new CompanyVsPayerCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateComapnyVsPayer(request.CompanyVsPayerName,request.CompanyID);

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
