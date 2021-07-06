using RimWorld;
using Verse;

namespace VanillaBrewingExpanded
{
    public class Hediff_CiderRemoveToxic : HediffWithComps
    {

        public override void PostAdd(DamageInfo? dinfo)
        {
            base.PostAdd(dinfo);
            Hediff hediff = this.pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ToxicBuildup, false);
            if (hediff != null)
            {
                hediff.Severity -= 0.2f;
                return;
            }

        }
    }
}
