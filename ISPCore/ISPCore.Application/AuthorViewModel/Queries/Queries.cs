using ISPCore.Application.AuthorViewModel.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AuthorViewModel.Queries
{
    public static class Queries
    {
        public class GetAuthorViewModelList : IRequest<List<AuthorViewModelVM>>
        {
        }
        public class GetAuthorViewModel : IRequest<AuthorViewModelVM>
        {
            public int Id { get; set; }
        }
    }
}
