using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum DRKFlags : short
    {
        None = 0,

        [CustomComboInfo("Souleater Combo", "Replace Souleater with its combo chain", 32)]
        SouleaterCombo = 1 << 0,

        [CustomComboInfo("Stalwart Soul Combo", "Replace Stalwart Soul with its combo chain", 32)]
        StalwartSoulCombo = 1 << 1,
    }
}
