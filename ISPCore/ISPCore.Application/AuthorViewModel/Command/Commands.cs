using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AuthorViewModel.Command
{
    public static class Commands
    {
        public static class AuthorViewModel
        {
            public class Create : IRequest<AuthorViewModelCommandVM>
            {

                public string Name { get; set; }
                public bool IsAuthor { get; set; }
            }

            public class Update : IRequest<AuthorViewModelCommandVM>
            {
                public int Id { get; set; }

                public string Name { get; set; }
                public bool IsAuthor { get; set; }
            }

            public class MarkAsDelete : IRequest<AuthorViewModelCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
