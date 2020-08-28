using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Company.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.Company.MarkAsDelete, CompanyCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.Company> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.Company> _repository;
        public async Task<CompanyCommandVM> Handle(Commands.Company.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new CompanyCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.MarkAsDelete();

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
