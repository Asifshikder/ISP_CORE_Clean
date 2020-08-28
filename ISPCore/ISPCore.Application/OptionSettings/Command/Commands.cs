using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Application.OptionSettings.Command
{
    public static class Commands
    {
        public static class OptionSettings
        {
            public class Create : IRequest<OptionSettingsCommandVM>
            {
                public string OptionSettingsName { get; set; }
            }

            public class Update : IRequest<OptionSettingsCommandVM>
            {
                public int Id { get; set; }
                public string OptionSettingsName { get; set; }
            }

            public class MarkAsDelete : IRequest<OptionSettingsCommandVM>
            {
                public int Id { get; set; }
            }
        }
    }
}
