using System;
using XIVCombo.Configuration.Jobs;

namespace XIVComboPlugin
{
    public class CustomComboPreset
    {
        public ASTFlags AST { get; set; }
        public BLMFlags BLM { get; set; }
        public BRDFlags BRD { get; set; }
        public DNCFlags DNC { get; set; }
        public DRGFlags DRG { get; set; }
        public DRKFlags DRK { get; set; }
        public GNBFlags GNB { get; set; }
        public MCHFlags MCH { get; set; }
        public MNKFlags MNK { get; set; }
        public NINFlags NIN { get; set; }
        public PCTFlags PCT { get; set; }
        public PLDFlags PLD { get; set; }
        public RDMFlags RDM { get; set; }
        public RPRFlags RPR { get; set; }
        public SAMFlags SAM { get; set; }
        public SCHFlags SCH { get; set; }
        public SMNFlags SMN { get; set; }
        public VPRFlags VPR { get; set; }
        public WARFlags WAR { get; set; }
        public WHMFlags WHM { get; set; }
    }

    public class CustomComboInfoAttribute : Attribute
    {
        internal CustomComboInfoAttribute(string fancyName, string description, byte classJob)
        {
            FancyName = fancyName;
            Description = description;
            ClassJob = classJob;
        }

        public string FancyName { get; }
        public string Description { get; }
        public byte ClassJob { get; }

    }
}
