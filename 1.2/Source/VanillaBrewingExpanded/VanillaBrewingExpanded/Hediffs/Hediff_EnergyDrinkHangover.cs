using RimWorld;
using Verse;

namespace VanillaBrewingExpanded
{
    public class Hediff_EnergyDrinkHangover : HediffWithComps
    {
        

        public override void PostAdd(DamageInfo? dinfo)
        {
            base.PostAdd(dinfo);
            this.pawn.needs.rest.CurLevel -= 0.2f;
        }
    }
}