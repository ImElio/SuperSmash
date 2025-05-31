using HarmonyLib;
using Il2CppEmpyrean.HouseFlipper2;
using Unity.Mathematics;
using SmashRangeMod;

namespace SmashRangeMod.Patches
{
    // Expand the computed Bounds by user-configurable amount
    [HarmonyPatch(typeof(SmashInfo), nameof(SmashInfo.Bounds), MethodType.Getter)]
    static class Patch_SmashInfo_GetBounds
    {
        static void Postfix(ref int3Bounds __result)
        {
            int n = Preferences.BoundsExpansion;
            __result.min -= new int3(n, n, n);
            __result.max += new int3(n, n, n);
        }
    }
}
