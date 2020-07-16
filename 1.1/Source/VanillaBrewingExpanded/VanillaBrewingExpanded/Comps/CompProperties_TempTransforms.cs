using RimWorld;
using Verse;

namespace VanillaBrewingExpanded
{
    public class CompProperties_TempTransforms : CompProperties
    {
        public CompProperties_TempTransforms()
        {
            this.compClass = typeof(CompTempTransforms);
        }

        public float minSafeTemperature;

        public float maxSafeTemperature = 400f;

        public float progressPerDegreePerTick = 1E-05f;

        public string thingToTransformInto = "";
    }
}
