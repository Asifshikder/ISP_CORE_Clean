using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.Item.Command
{
    public static class Commands
    {
        public static class Item
        {
            public class Create : IRequest<ItemCommandVM>
            {
                public string ItemName { get; set; }

                public int? ItemFor { get; set; }
                public string ItemCode { get; set; }
            }

            public class Update : IRequest<ItemCommandVM>
            {
                public int Id { get; set; }
                public string ItemName { get; set; }

                public int? ItemFor { get; set; }
                public string ItemCode { get; set; }
            }

            public class MarkAsDelete : IRequest<ItemCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
