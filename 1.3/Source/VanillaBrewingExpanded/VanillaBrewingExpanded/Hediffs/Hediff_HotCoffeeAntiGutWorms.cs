using RimWorld;
using Verse;

namespace VanillaBrewingExpanded
{
    public class Hediff_HotCoffeeAntiGutWorms : Hediff_High
    {

        public override void PostAdd(DamageInfo? dinfo)
        {
            base.PostAdd(dinfo);
            Hediff hediff = this.pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.Hypothermia, false);
            if (hediff != null)
            {
                hediff.Severity -= 0.2f;
                
            }
            Hediff hediff2 = this.pawn.health.hediffSet.GetFirstHediffOfDef(HediffDef.Named("GutWorms"), false);
            if (hediff2 != null)
            {
                
                    hediff2.Tended(1f, 1f);
                

            }

        }
    }
}

