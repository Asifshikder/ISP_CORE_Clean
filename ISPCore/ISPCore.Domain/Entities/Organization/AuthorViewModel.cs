using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class AuthorViewModel : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public bool IsAuthor { get; set; }
        public int Status { get; private set; }


        public AuthorViewModel() { }

        public AuthorViewModel(string name,bool isAuthor)
        {
            Name = name;
            IsAuthor = isAuthor;
        }

        public void UpdateAuthorViewModel(string name,bool isAuthor)
        {
            Name = name;
            IsAuthor = isAuthor;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
