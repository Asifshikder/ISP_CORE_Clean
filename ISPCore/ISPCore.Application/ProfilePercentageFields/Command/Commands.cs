using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ProfilePercentageFields.Command
{
    public static class Commands
    {
        public static class ProfilePercentageFields
        {
            public class Create : IRequest<ProfilePercentageFieldsCommandVM>
            {
                public string FieldsName { get; set; }
                public string TableName { get; set; }
                public string MappingField { get; set; }
            }

            public class Update : IRequest<ProfilePercentageFieldsCommandVM>
            {
                public int Id { get; set; }
                public string FieldsName { get; set; }
                public string TableName { get; set; }
                public string MappingField { get; set; }
            }

            public class MarkAsDelete : IRequest<ProfilePercentageFieldsCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
