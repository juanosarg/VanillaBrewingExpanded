using RimWorld;
using Verse;

namespace VanillaBrewingExpanded
{
    public class Hediff_EnergyDrinkHangover : HediffWithComps
    {
        public override bool Visible
        {
            get
            {
                return !this.pawn.health.hediffSet.HasHediff(HediffDef.Named("VBE_EnergyDrinkCrash"), false) && base.Visible;
            }
        }

        public override void PostAdd(DamageInfo? dinfo)
        {
            base.PostAdd(dinfo);
            this.pawn.needs.rest.CurLevel -= 0.2f;
        }
    }
}