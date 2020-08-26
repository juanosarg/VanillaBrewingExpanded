using RimWorld;
using Verse;

namespace VanillaBrewingExpanded
{
    public class Hediff_EnergyDrink : Hediff_High
    {

       

        public override void PostRemoved()
        {
            base.PostRemoved();
            Hediff hediff = this.pawn.health.hediffSet.GetFirstHediffOfDef(HediffDef.Named("VBE_EnergyDrinkCrash"), false);
            if (hediff != null)
            {
                hediff.Severity = 1f;
                return;
            }
            hediff = HediffMaker.MakeHediff(HediffDef.Named("VBE_EnergyDrinkCrash"), this.pawn, null);
            hediff.Severity = 1f;
            this.pawn.health.AddHediff(hediff, null, null, null);
        }

        public override void PostAdd(DamageInfo? dinfo)
        {
            base.PostAdd(dinfo);
            this.pawn.needs.rest.CurLevel += 0.2f;
        }
    }
}

