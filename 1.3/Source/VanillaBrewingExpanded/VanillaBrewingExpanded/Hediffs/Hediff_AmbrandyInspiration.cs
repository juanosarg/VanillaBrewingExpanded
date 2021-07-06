using RimWorld;
using Verse;
using System.Linq;

namespace VanillaBrewingExpanded
{
    public class Hediff_AmbrandyInspiration : HediffWithComps
    {

       
        public override void PostAdd(DamageInfo? dinfo)
        {
            base.PostAdd(dinfo);
            
            this.pawn.mindState.inspirationHandler.TryStartInspiration(InspirationDefOf.Inspired_Creativity);
            
        }

        
    }
}