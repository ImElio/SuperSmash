using MelonLoader;

namespace SmashRangeMod
{
    // Centralized user settings via MelonPreferences
    public static class Preferences
    {
        private static MelonPreferences_Entry<float> _smashReachMultiplier;
        private static MelonPreferences_Entry<int> _boundsExpansion;
        private static MelonPreferences_Entry<int> _fragmentsExpansion;

        // Public getters
        public static float SmashReachMultiplier => _smashReachMultiplier.Value;
        public static int BoundsExpansion => _boundsExpansion.Value;
        public static int FragmentsExpansion => _fragmentsExpansion.Value;

        // Initialize all preference entries on startup
        public static void Init()
        {
            var cat = MelonPreferences.CreateCategory("SmashRangeMod");

            _smashReachMultiplier = cat.CreateEntry(
                "SmashReachMultiplier",
                2.0f,
                description: "Multiplier for smash reach (default 2.0)"
            );

            _boundsExpansion = cat.CreateEntry(
                "BoundsExpansion",
                1,
                description: "Extra blocks to expand SmashInfo.Bounds (default 1)"
            );

            _fragmentsExpansion = cat.CreateEntry(
                "FragmentsExpansion",
                2,
                description: "Extra blocks to expand DestroyFragmentsInBounds (default 2)"
            );
        }
    }
}
