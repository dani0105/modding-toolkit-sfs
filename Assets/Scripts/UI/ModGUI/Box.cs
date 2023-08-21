using UnityEngine;
using UnityEngine.UI;

namespace SFS.UI.ModGUI
{
    public class Box : GUIElement
    {
        public Box(){

        }

        public Color Color { get; set; }
        public float Opacity { get; set; }

        public HorizontalOrVerticalLayoutGroup CreateLayoutGroup(Type type, TextAnchor childAlignment = TextAnchor.MiddleCenter, float spacing = 20, RectOffset padding = null, bool disableChildSizeControl = true)
        {
            return null;
        }
        public override void Init(GameObject self, Transform parent)
        {

        }
    }
}