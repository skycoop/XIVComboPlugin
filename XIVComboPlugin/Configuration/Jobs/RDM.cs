using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum RDMFlags : ushort
    {
        None = 0,

        [CustomComboInfo("AoE Combo", "Replaces Veraero / thunder 2 with Impact when Dualcast or Swiftcast are active", 35)]
        AoECombo = 1 << 0,

        [CustomComboInfo("Redoublement combo", "Replaces Redoublement with its combo chain, following enchantment rules", 35)]
        MeleeCombo = 1 << 1,

        [CustomComboInfo("Verproc into Jolt", "Replaces Verstone/Verfire with Jolt/Scorch when no proc is available", 35)]
        VerprocCombo = 1 << 2,
    }
}
