using UnityEngine;

namespace SFS.UI.ModGUI
{
    public class Label : GUIElement
    {
        public Label(){

        }

        public string Text { get; set; }
        public Color Color { get; set; }
        public float Opacity { get; set; }
        //public global::TMPro.TextAlignmentOptions TextAlignment { get; set; }
        public bool AutoFontResize { get; set; }
        public float FontSize { get; set; }
        //public global::TMPro.FontStyles FontStyle { get; set; }

        public override void Init(GameObject self, Transform parent)
        {

        }
    }
}