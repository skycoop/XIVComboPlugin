using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum SMNFlags : ushort
    {
        None = 0,

        [CustomComboInfo("ED Fester/Necrotize", "Change Fester/Necrotize into Energy Drain when out of Aetherflow stacks", 27)]
        EDFesterCombo = 1 << 0,

        [CustomComboInfo("ES Painflare", "Change Painflare into Energy Syphon when out of Aetherflow stacks", 27)]
        ESPainflareCombo = 1 << 1,

        [CustomComboInfo("Solar Bahamut Lux", "Change Summon Solar Bahamut into Lux Solaris after summoning", 27)]
        SolarBahamutLuxSolaris = 1 << 2,
    }
}
