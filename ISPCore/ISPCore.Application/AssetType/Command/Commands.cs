using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.AssetType.Command
{
    public static class Commands
    {
        public static class AssetType
        {
            public class Create : IRequest<AssetTypeCommandVM>
            {
                public string AssetTypeName { get; set; }
            }

            public class Update : IRequest<AssetTypeCommandVM>
            {
                public int Id { get; set; }
                public string AssetTypeName { get; set; }
            }

            public class MarkAsDelete : IRequest<AssetTypeCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
