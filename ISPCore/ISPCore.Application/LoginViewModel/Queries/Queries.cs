using ISPCore.Application.LoginViewModel.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.LoginViewModel.Queries
{
    public static class Queries
    {
        public class GetLoginViewModelList : IRequest<List<LoginViewModelVM>>
        {
        }
        public class GetLoginViewModel : IRequest<LoginViewModelVM>
        {
            public int Id { get; set; }
        }
    }
}
