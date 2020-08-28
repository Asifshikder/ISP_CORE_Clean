using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Departement.Command
{
    public class UpdateCommandHandler : IRequestHandler<Commands.Departement.Update, DepartementCommandVM>
    {

        public UpdateCommandHandler(IAsyncRepository<Domain.Entities.Department> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Department> _repository;
        public async Task<DepartementCommandVM> Handle(Commands.Departement.Update request, CancellationToken cancellationToken)
        {
            var response = new DepartementCommandVM
            {
                Status = false,
                Message = "error"
            };
            try
            {
                var entity = await _repository.GetByIdAsync(request.Id);
                entity.UpdateDepartement(request.DepartementName);

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
