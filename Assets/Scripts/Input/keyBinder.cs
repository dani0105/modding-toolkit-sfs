// SFS.Input.KeyBinder
using System;
using UnityEngine;

namespace SFS.Input
{
    public class KeyBinder : Screen_Base
    {
        private GameObject holder;

        private KeybindingsPC.Key key;

        private Action apply;

        private KeybindingsPC.Key defaultKey;

        public override bool PauseWhileOpen => true;

        public void Initialize(GameObject holder, KeybindingsPC.Key key, KeybindingsPC.Key defaultKey, Action apply)
        {

        }

        public override void OnOpen()
        {

        }

        public override void OnClose()
        {

        }

        public override void ProcessInput()
        {
        }

        private static string GetDisplayName(KeybindingsPC.Key k)
        {
            return "";
        }

        public void ResetToDefault()
        {

        }
    }
}
