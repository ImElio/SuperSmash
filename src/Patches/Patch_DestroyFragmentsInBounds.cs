using HarmonyLib;
using Il2CppEmpyrean.HouseFlipper2;
using Unity.Mathematics;
using SmashRangeMod;

namespace SmashRangeMod.Patches
{
    // Expand the fragment destruction bounds by user setting
    [HarmonyPatch(typeof(WallSmashingHelper), nameof(WallSmashingHelper.DestroyFragmentsInBounds))]
    static class Patch_DestroyFragmentsInBounds
    {
        static void Prefix(ref int3Bounds bounds)
        {
            int n = Preferences.FragmentsExpansion;
            bounds.min -= new int3(n, n, n);
            bounds.max += new int3(n, n, n);
        }
    }
}
