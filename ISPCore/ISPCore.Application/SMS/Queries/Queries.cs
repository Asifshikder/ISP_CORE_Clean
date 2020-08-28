using ISPCore.Application.SMS.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.SMS.Queries
{
    public static class Queries
    {
        public class GetSMSList : IRequest<List<SMSVM>>
        {
        }
        public class GetSMS : IRequest<SMSVM>
        {
            public int Id { get; set; }
        }
    }
}
