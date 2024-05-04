using RimWorld;
using System.Collections.Generic;
using System.Linq;
using Verse;

namespace RFL
{
    public class RoomRoleWorker_Library : RoomRoleWorker
    {
        public override float GetScore(Room room)
        {
            List<Thing> containedAndAdjacentThings = room.ContainedAndAdjacentThings;

            int num = 0;

            for(int i=0; i< containedAndAdjacentThings.Count(); i++)
            {
                Thing thing = containedAndAdjacentThings[i];

                if (thing.def.IsBed && thing.def.building.bed_humanlike)
                {
                    return 0f;
                }

                if (thing.def == RFL_ThingDefOf.Bookcase || thing.def == RFL_ThingDefOf.BookcaseSmall)
                {
                    num++;
                }
            }

            return (float)num * 8f;
            
        }
    }
}
