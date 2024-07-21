using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum WARFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Storms Path Combo", "Replace Storms Path with its combo chain", 21)]
        StormsPathCombo = 1 << 0,

        [CustomComboInfo("Storms Eye Combo", "Replace Storms Eye with its combo chain", 21)]
        StormsEyeCombo = 1 << 1,

        [CustomComboInfo("Mythril Tempest Combo", "Replace Mythril Tempest with its combo chain", 21)]
        MythrilTempestCombo = 1 << 2,
    }
}