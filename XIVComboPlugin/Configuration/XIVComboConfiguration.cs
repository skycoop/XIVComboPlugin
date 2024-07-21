using Dalamud.Configuration;
using System;
using System.Collections.Generic;

namespace XIVComboPlugin
{
    [Serializable]
    public class XIVComboConfiguration : IPluginConfiguration
    {

        public CustomComboPreset ComboPresets { get; set; } = new();
        public int Version { get; set; }

        public List<bool> HiddenActions;

    }
}
