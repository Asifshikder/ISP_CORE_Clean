using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AuthorViewModel.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.AuthorViewModel.Create, AuthorViewModelCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.AuthorViewModel> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.AuthorViewModel> _repository;

        public async Task<AuthorViewModelCommandVM> Handle(Commands.AuthorViewModel.Create request, CancellationToken cancellationToken)
        {
            var response = new AuthorViewModelCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.AuthorViewModel(request.Name,request.IsAuthor);
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
