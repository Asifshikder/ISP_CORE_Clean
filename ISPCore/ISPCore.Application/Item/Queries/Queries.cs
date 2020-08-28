using ISPCore.Application.Item.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Item.Queries
{
    public static class Queries
    {
        public class GetItemList : IRequest<List<ItemVM>>
        {
        }
        public class GetItem : IRequest<ItemVM>
        {
            public int Id { get; set; }
        }
    }
}
