// SFS.UI.ModGUI.Button
using System;
using UnityEngine;

namespace SFS.UI.ModGUI
{
    public class Button : SFS.UI.ModGUI.GUIElement
    {
        private ButtonPC _button;

        private Action _onClick;

        //private TextAdapter _textAdapter;

        public string Text
        {
            get; set;
        }

        public Color TextColor
        {
            get; set;
        }

        public float TextOpacity
        {
            get; set;
        }

        public Action OnClick
        {
            get; set;
        }

        public override void Init(GameObject self, Transform parent)
        {

        }
    }
}
