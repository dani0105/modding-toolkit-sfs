
using System;
using UnityEngine;

namespace SFS.UI.ModGUI
{
    public class Toggle : GUIElement
    {
        public ToggleButton toggleButton;

        public Toggle() { }

        [Obsolete("Size change not recommended for toggle. Please use scaling.")]
        public override Vector2 Size { get; set; }

        public override void Init(GameObject self, Transform parent) { }
    }
}