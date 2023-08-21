using System;
using SFS.Input;

namespace ModLoader
{
    public abstract class ModKeybindings
    {
        protected ModKeybindings() { }

        public static void AddOnKeyDown(I_Key key, Action onKeyDown) { }
        public static void AddOnKeyDown_Build(I_Key key, Action onKeyDown) { }
        public static void AddOnKeyDown_World(I_Key key, Action onKeyDown) { }
        protected static T SetupKeybindings<T>(Mod mod) where T : ModKeybindings, new() { 
            return null;
        }
        public abstract void CreateUI();
        public void CreateUI_Keybinding(KeybindingsPC.Key key, KeybindingsPC.Key defaultKey, string displayName) { }
        public void CreateUI_Keybinding(KeybindingsPC.Key[] keys, KeybindingsPC.Key[] defaultKeys, string displayName) { }
        public void CreateUI_Space() { }
        public void CreateUI_Text(string text) { }
    }
}