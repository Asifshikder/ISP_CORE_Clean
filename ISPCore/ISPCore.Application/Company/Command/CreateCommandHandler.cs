using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Company.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Company.Create, CompanyCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Company> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Company> _repository;

        public async Task<CompanyCommandVM> Handle(Commands.Company.Create request, CancellationToken cancellationToken)
        {
            var response = new CompanyCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Company(request.CompanyName, request.CompanyEmail,request.CompanyAddress,request.ContactPerson,request.Phone,request.CompanyLogo,request.CompanyLogoPath);
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
