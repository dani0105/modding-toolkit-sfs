using UnityEngine;
using UnityEngine.UI;

namespace SFS.UI.ModGUI
{
    public class Container : GUIElement
    {
        public Container(){}

        public HorizontalOrVerticalLayoutGroup CreateLayoutGroup(Type type, TextAnchor childAlignment = TextAnchor.MiddleCenter, float spacing = 20, RectOffset padding = null, bool disableChildSizeControl = true)
        {
            return null;
        }
        public override void Init(GameObject self, Transform parent)
        {

        }
    }
}