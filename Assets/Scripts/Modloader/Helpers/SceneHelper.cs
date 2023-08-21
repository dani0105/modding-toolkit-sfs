using UnityEngine.SceneManagement;

namespace ModLoader.Helpers
{
    public static class SceneHelper
    {
        public static OptionalDelegate<Scene> OnHomeSceneLoaded;
        public static OptionalDelegate<Scene> OnHomeSceneUnloaded;
        public static OptionalDelegate<Scene> OnHubSceneLoaded;
        public static OptionalDelegate<Scene> OnHubSceneUnloaded;
        public static OptionalDelegate<Scene> OnBuildSceneLoaded;
        public static OptionalDelegate<Scene> OnBuildSceneUnloaded;
        public static OptionalDelegate<Scene> OnWorldSceneLoaded;
        public static OptionalDelegate<Scene> OnWorldSceneUnloaded;
        public static OptionalDelegate<Scene> OnSceneLoaded;
        public static OptionalDelegate<Scene> OnSceneUnloaded;
    }
}