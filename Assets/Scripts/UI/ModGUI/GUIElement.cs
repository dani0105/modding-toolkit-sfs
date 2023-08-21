// SFS.UI.ModGUI.GUIElement
using SFS.UI.ModGUI;
using UnityEngine;

namespace SFS.UI.ModGUI
{
    public abstract class GUIElement
    {
        public GameObject gameObject;

        public RectTransform rectTransform;

        public virtual Vector2 Size
        {
            get; set;
        }

        public virtual Vector2 Position
        {
            get; set;
        }

        public virtual bool Active
        {
            get; set;
        }

        public abstract void Init(GameObject self, Transform parent);

        public static implicit operator Transform(SFS.UI.ModGUI.GUIElement element)
        {
            return null;
        }
    }
}