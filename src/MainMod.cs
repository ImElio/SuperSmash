using MelonLoader;
using HarmonyLib;
using SmashRangeMod;
using System.Reflection;

[assembly: MelonInfo(typeof(MainMod), "SmashRangeMod", "1.0.0", "Elio")]
[assembly: MelonGame(null, null)]

public class MainMod : MelonMod
{
    private HarmonyLib.Harmony _harmony;

    public override void OnApplicationStart()
    {
        // Load user preferences first
        Preferences.Init();
        MelonLogger.Msg("SmashRangeMod preferences loaded.");

        // Create a dedicated Harmony instance
        _harmony = new HarmonyLib.Harmony("com.elio.smashrangemod");
        _harmony.PatchAll(); // apply all [HarmonyPatch] in /Patches

        // Manually patch the managed wrapper SmashBuilding()
        var smashBuilding = AccessTools.Method(
            typeof(Il2CppEmpyrean.HouseFlipper2.WallSmashingHelper),
            nameof(Il2CppEmpyrean.HouseFlipper2.WallSmashingHelper.SmashBuilding),
            new[] { typeof(Il2CppEmpyrean.HouseFlipper2.SmashInfo), typeof(int) }
        );
        var prefix = new HarmonyMethod(typeof(MainMod)
            .GetMethod(nameof(SmashBuilding_Prefix), BindingFlags.Static | BindingFlags.NonPublic)
        );
        _harmony.Patch(smashBuilding, prefix: prefix);

        MelonLogger.Msg("SmashRangeMod patches applied.");
    }

    // Prefix on SmashBuilding to scale smash reach by user multiplier
    static void SmashBuilding_Prefix(ref Il2CppEmpyrean.HouseFlipper2.SmashInfo smash, int playerID)
    {
        smash.reach.x = (int)(smash.reach.x * Preferences.SmashReachMultiplier);
        smash.reach.y = (int)(smash.reach.y * Preferences.SmashReachMultiplier);
        smash.reach.z = (int)(smash.reach.z * Preferences.SmashReachMultiplier);
    }
}
