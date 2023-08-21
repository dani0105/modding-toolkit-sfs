
// SFS.Input.KeybindingsPC
using System;
using System.Collections.Generic;
using SFS.IO;
using UnityEngine;

namespace SFS.Input
{
    public class KeybindingsPC : SettingsBase<KeybindingsPC.Data>
    {
        public class Data
        {
            public Key Close_Menu = KeyCode.Escape;

            public Key[] SaveLoad = new Key[2]
            {
            KeyCode.F5,
            KeyCode.F9
            };

            public Key Select_All = Key.Ctrl_(KeyCode.A);

            public Key[] CopyPaste = new Key[2]
            {
            Key.Ctrl_(KeyCode.C),
            Key.Ctrl_(KeyCode.V)
            };

            public Key Duplicate = Key.Ctrl_(KeyCode.D);

            public Key Delete = KeyCode.Delete;

            public Key Undo = Key.Ctrl_(KeyCode.Z);

            public Key Redo = Key.Ctrl_(KeyCode.Y);

            public Key[] Rotate_Part = new Key[2]
            {
            KeyCode.Q,
            KeyCode.E
            };

            public Key[] Flip_Part = new Key[4]
            {
            KeyCode.W,
            KeyCode.A,
            KeyCode.S,
            KeyCode.D
            };

            public Key Toggle_Ignition = KeyCode.Space;

            public Key[] Throttle = new Key[2]
            {
            KeyCode.LeftControl,
            KeyCode.LeftShift
            };

            public Key[] MinMax_Throttle = new Key[2]
            {
            KeyCode.X,
            KeyCode.Z
            };

            public Key Toggle_RCS = KeyCode.R;

            public Key[] Turn_Rocket = new Key[2]
            {
            KeyCode.Q,
            KeyCode.E
            };

            public Key[] Move_Rocket_Using_RCS = new Key[4]
            {
            KeyCode.W,
            KeyCode.A,
            KeyCode.S,
            KeyCode.D
            };

            public Key Activate_Stage = KeyCode.Return;

            public Key Toggle_Map = KeyCode.M;

            public Key[] Timewarp = new Key[2]
            {
            KeyCode.Comma,
            KeyCode.Period
            };

            public Key[] Switch_Rocket = new Key[2]
            {
            KeyCode.LeftBracket,
            KeyCode.RightBracket
            };

            public Key Toggle_Console = KeyCode.F1;
        }

        [Serializable]
        public class Key : I_Key
        {
            public bool ctrl;

            public KeyCode key;


            public static Key Ctrl_(KeyCode key)
            {
                return new Key
                {
                    key = key,
                    ctrl = true
                };
            }

            public static implicit operator Key(KeyCode key)
            {
                return new Key
                {
                    key = key,
                    ctrl = false
                };
            }

            bool I_Key.IsKeyDown()
            {
                return false;
            }

            bool I_Key.IsKeyStay()
            {
                return false;
            }

            bool I_Key.IsKeyUp()
            {
                return false;
            }
        }

        public static KeybindingsPC main;

        public static Data keys = new Data();

        public GameObject keybindingPrefab;

        public GameObject spacePrefab;

        public GameObject textPrefab;

        public Transform keybindingsHolder;

        private List<KeyBinder> elements = new List<KeyBinder>();

        protected override string FileName => "Keybindings";

        public void CreateText(string text)
        {

        }

        public void CreateSpace()
        {

        }

        public void ResetKeybindings()
        {

        }

        protected override void OnLoad()
        {

        }
    }
}