using HarmonyLib;
using Il2CppEmpyrean.HouseFlipper2;
using SmashRangeMod;
using System.Reflection;

namespace SmashRangeMod.Patches
{
    // Hooking the managed SmashBuilding wrapper as fallback
    [HarmonyPatch]
    static class Patch_WallSmashingHelper_SmashBuilding
    {
        static MethodBase TargetMethod()
        {
            return AccessTools.Method(
                typeof(WallSmashingHelper),
                nameof(WallSmashingHelper.SmashBuilding),
                new[] { typeof(SmashInfo), typeof(int) }
            );
        }

        static void Prefix(ref SmashInfo smash, int playerID)
        {
            int m = (int)Preferences.SmashReachMultiplier;
            smash.reach.x = (int)(smash.reach.x * Preferences.SmashReachMultiplier);
            smash.reach.y = (int)(smash.reach.y * Preferences.SmashReachMultiplier);
            smash.reach.z = (int)(smash.reach.z * Preferences.SmashReachMultiplier);
        }
    }
}
