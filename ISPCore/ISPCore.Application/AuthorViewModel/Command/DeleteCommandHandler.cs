using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.AuthorViewModel.Command
{
    public class DeleteCommandHandler : IRequestHandler<Commands.AuthorViewModel.MarkAsDelete, AuthorViewModelCommandVM>
    {
        public DeleteCommandHandler(IAsyncRepository<Domain.Entities.AuthorViewModel> repository)
        {
            _repository = repository;
        }
        public IAsyncRepository<Domain.Entities.AuthorViewModel> _repository;
        public async Task<AuthorViewModelCommandVM> Handle(Commands.AuthorViewModel.MarkAsDelete request, CancellationToken cancellationToken)
        {
            var response = new AuthorViewModelCommandVM
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
