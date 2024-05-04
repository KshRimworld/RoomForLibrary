using RimWorld;
using Verse;

namespace RFL
{
    [DefOf]
    internal static class RFL_ThingDefOf
    {
        public static ThingDef Bookcase;

        public static ThingDef BookcaseSmall;

        static RFL_ThingDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(RFL_ThingDefOf));
        }
    }
}
