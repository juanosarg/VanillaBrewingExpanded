using RimWorld;
using Verse;
using System.Linq;

namespace VanillaBrewingExpanded
{
    public class Hediff_ConsumedCocktail : HediffWithComps
    {

        private System.Random rand = new System.Random();

        public override void PostAdd(DamageInfo? dinfo)
        {
            base.PostAdd(dinfo);
            if (rand.NextDouble() > 0.95f)
            {
                this.pawn.mindState.inspirationHandler.TryStartInspiration(GetRandomAvailableInspirationDef());
            }
        }

        private InspirationDef GetRandomAvailableInspirationDef()
        {
            return (from x in DefDatabase<InspirationDef>.AllDefsListForReading
                    where x.Worker.InspirationCanOccur(this.pawn)
                    select x).RandomElementByWeightWithFallback((InspirationDef x) => x.Worker.CommonalityFor(this.pawn), null);
        }
    }
}