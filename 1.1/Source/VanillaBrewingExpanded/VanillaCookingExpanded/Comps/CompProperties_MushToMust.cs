using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;
using RimWorld;

namespace VanillaBrewingExpanded
{
    public class CompProperties_MushToMust : CompProperties
    {
        public int TicksToRotStart
        {
            get
            {
                return Mathf.RoundToInt(this.daysToRotStart * 60000f);
            }
        }

        public int TicksToDessicated
        {
            get
            {
                return Mathf.RoundToInt(this.daysToDessicated * 60000f);
            }
        }

        public CompProperties_MushToMust()
        {
            this.compClass = typeof(CompMushToMust);
        }

        public CompProperties_MushToMust(float daysToRotStart)
        {
            this.daysToRotStart = daysToRotStart;
        }



        public float daysToRotStart = 2f;

        public bool rotDestroys;

        public float rotDamagePerDay = 40f;

        public float daysToDessicated = 999f;

        public float dessicatedDamagePerDay;

        public bool disableIfHatcher;
    }
}
