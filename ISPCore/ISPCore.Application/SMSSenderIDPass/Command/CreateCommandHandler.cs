using ISPCore.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.SMSSenderIDPass.Command
{
    public class CreateCommandHandler : IRequestHandler<Commands.SMSSenderIDPass.Create, SMSSenderIDPassCommandVM>
    {
        public CreateCommandHandler(IAsyncRepository<Domain.Entities.SMSSenderIDPass> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Domain.Entities.SMSSenderIDPass> _repository;

        public async Task<SMSSenderIDPassCommandVM> Handle(Commands.SMSSenderIDPass.Create request, CancellationToken cancellationToken)
        {
            var response = new SMSSenderIDPassCommandVM
            {
                Status = false,
                Message = "error"
            };

            try
            {
                var entity = new Domain.Entities.SMSSenderIDPass(request.SenderID,request.Pass,request.Sender,request.CompanyName,request.HelpLine);
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
