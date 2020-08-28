using ISPCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Domain.Entities
{
    public class OptionSettings : BaseEntity, IHasId<int>, IAggregateRoot
    {
        public int Id { get; private set; }
        public string OptionSettingsName { get; private set; }

        public int Status { get; private set; }


        public OptionSettings() { }

        public OptionSettings(string optionSettingsName)
        {
            OptionSettingsName = optionSettingsName;
        }

        public void UpdateOptionSettings(string optionSettingsName)
        {
            OptionSettingsName = optionSettingsName;
        }

        public void MarkAsDelete()
        {
            Status = 3;
        }
    }
}
