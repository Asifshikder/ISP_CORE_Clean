using ISPCore.Application.ProfilePercentageFields.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.ProfilePercentageFields.Queries
{
    public static class Queries
    {
        public class GetProfilePercentageFieldsList : IRequest<List<ProfilePercentageFieldsVM>>
        {
        }
        public class GetProfilePercentageFields : IRequest<ProfilePercentageFieldsVM>
        {
            public int Id { get; set; }
        }
    }
}
