using ISPCore.Application.OptionSettings.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.OptionSettings.Queries
{
    public static class Queries
    {
        public class GetOptionSettingsList : IRequest<List<OptionSettingsVM>>
        {
        }
        public class GetOptionSettings : IRequest<OptionSettingsVM>
        {
            public int Id { get; set; }
        }
    }
}
