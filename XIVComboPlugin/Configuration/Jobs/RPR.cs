using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum RPRFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Slice Combo", "Replace Slice with its combo chain", 39)]
        SliceCombo = 1 << 0,

        [CustomComboInfo("Scythe Combo", "Replace Spinning Scythe with its combo chain", 39)]
        ScytheCombo = 1 << 1,

        [CustomComboInfo("Double Regress", "Regress always replaces both Hell's Egress and Hell's Ingress", 39)]
        RegressFeature = 1 << 2,

        [CustomComboInfo("Enshroud Combo", "Replace Enshroud with Communio while you are Enshrouded", 39)]
        EnshroudCombo = 1 << 3,

        [CustomComboInfo("Arcane Circle Combo", "Replace Arcane Circle with Plentiful Harvest while you have Immortal Sacrifice", 39)]
        ArcaneFeature = 1 << 4,
    }
}
