using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum BRDFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Heavy Shot into Straight Shot", "Replaces Heavy Shot/Burst Shot with Straight Shot/Refulgent Arrow when procced", 23)]
        StraightShotUpgradeFeature = 1 << 0,

        [CustomComboInfo("Quick Nock into Shadowbite", "Replaces Quick Nock/Ladonsbite with Wide Volley/Shadowbite when procced", 23)]
        AoEUpgradeFeature = 1 << 1,
    }
}
