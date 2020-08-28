using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.CompanyVsPayer.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.CompanyVsPayer.Create, CompanyVsPayerCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.CompanyVsPayer> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.CompanyVsPayer> _repository;

        public async Task<CompanyVsPayerCommandVM> Handle(Commands.CompanyVsPayer.Create request, CancellationToken cancellationToken)
        {
            var response = new CompanyVsPayerCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.CompanyVsPayer(request.CompanyVsPayerName,request.CompanyID);
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
