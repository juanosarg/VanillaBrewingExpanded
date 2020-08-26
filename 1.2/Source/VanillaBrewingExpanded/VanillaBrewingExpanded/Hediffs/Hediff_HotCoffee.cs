using RimWorld;
using Verse;

namespace VanillaBrewingExpanded
{
    public class Hediff_HotCoffee : Hediff_High
    {

        public override void PostAdd(DamageInfo? dinfo)
        {
            base.PostAdd(dinfo);
            Hediff hediff = this.pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.Hypothermia, false);
            if (hediff != null)
            {
                hediff.Severity -= 0.2f;
                return;
            }
            
        }
    }
}

