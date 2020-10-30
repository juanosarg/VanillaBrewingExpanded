using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using UnityEngine;
using Verse;

namespace VanillaBrewingExpanded
{
    public class Plant_AutoProduce : Plant
    {

        public override void Tick()
        {
            base.Tick();
            if (this.IsHashIntervalTick(60000) && this.Growth>0.7) {
                System.Random random = new System.Random();
                if (random.NextDouble() > 0.4) {
                    Thing thing = ThingMaker.MakeThing(this.def.plant.harvestedThingDef, null);
                    if (random.NextDouble() < 0.4)
                    {
                        thing.stackCount = 1;
                    } else {
                        thing.stackCount = 2;
                    }                       
                    GenPlace.TryPlaceThing(thing, this.Position+IntVec3.South, this.Map, ThingPlaceMode.Near, null, null, default(Rot4));
                }
                

            }
        }
    }
}
