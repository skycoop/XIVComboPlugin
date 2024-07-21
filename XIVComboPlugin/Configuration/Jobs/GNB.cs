using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum GNBFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Solid Barrel Combo", "Replace Solid Barrel with its combo chain", 37)]
        SolidBarrelCombo = 1 << 0,

        [CustomComboInfo("Gnashing Fang Continuation", "Put Continuation moves on Gnashing Fang when appropriate", 37)]
        GnashingFangCont = 1 << 1,

        [CustomComboInfo("Burst Strike Continuation", "Put Continuation moves on Burst Strike when appropriate", 37)]
        BurstStrikeCont = 1 << 2,

        [CustomComboInfo("Demon Slaughter Combo", "Replace Demon Slaughter with its combo chain", 37)]
        DemonSlaughterCombo = 1 << 3,

        [CustomComboInfo("Fated Circle Continuation", "Put Continuation moves on Fated Circle when appropriate", 37)]
        FatedCircleCont = 1 << 4,
    }
}
