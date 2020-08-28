using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Company.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Company.Update, CompanyCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Company> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Company> _repository;
        public async Task<CompanyCommandVM> Handle(Commands.Company.Update request, CancellationToken cancellationToken)
        {
            var response = new CompanyCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateCompany(request.CompanyName,request.CompanyEmail,request.CompanyAddress,request.ContactPerson,request.Phone,request.CompanyLogo,request.CompanyLogoPath);

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
