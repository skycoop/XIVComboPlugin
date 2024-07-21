using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum DNCFlags : ushort
    {
        None = 0,

        [CustomComboInfo("AoE GCD procs", "DNC AoE procs turn into their normal abilities when not procced", 38)]
        AoeGcdFeature = 1 << 0,

        [CustomComboInfo("Fan Dance Combos", "Change Fan Dance and Fan Dance 2 into Fan Dance 3 while flourishing", 38)]
        FanDanceCombo = 1 << 1,

        [CustomComboInfo("Fan Dance IV", "Change Flourish into Fan Dance IV while flourishing", 38)]
        FanDance4Combo = 1 << 2,

        [CustomComboInfo("Devilment into Starfall", "Change Devilment into Starfall Dance while under the effect of Flourishing Starfall", 38)]
        DevilmentCombo = 1 << 3,

        [CustomComboInfo("Standard Last Dance", "Change Standard Step into Last Dance when ready", 38)]
        LastDanceCombo = 1 << 4,
    }
}
