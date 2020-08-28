using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.LoginViewModel.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.LoginViewModel.Create, LoginViewModelCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.LoginViewModel> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.LoginViewModel> _repository;

        public async Task<LoginViewModelCommandVM> Handle(Commands.LoginViewModel.Create request, CancellationToken cancellationToken)
        {
            var response = new LoginViewModelCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.LoginViewModel(request.UserName,request.Password,request.RememberMe);
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
