using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Section.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.Section.Create, SectionCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.Section> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.Section> _repository;

        public async Task<SectionCommandVM> Handle(Commands.Section.Create request, CancellationToken cancellationToken)
        {
            var response = new SectionCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.Section(request.SectionName);
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
