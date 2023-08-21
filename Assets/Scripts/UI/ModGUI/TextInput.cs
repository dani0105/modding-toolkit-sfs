using UnityEngine;
using UnityEngine.Events;

namespace SFS.UI.ModGUI
{
    public class TextInput : GUIElement
    {
        //public global::TMPro.TMP_InputField field;

        public TextInput() { }

        public Color FieldColor { get; set; }
        public float FieldOpacity { get; set; }
        public string Text { get; set; }
        public UnityAction<string> OnChange { get; set; }

        public override void Init(GameObject self, Transform parent) { }
    }
}