using System;
using SFS.UI;
using SFS.UI.ModGUI;
using UnityEngine;
using UnityEngine.UI;
namespace SFS.UI.ModGUI
{
    public class Window : SFS.UI.ModGUI.GUIElement
    {
        public int ID;

       // private global::TranslucentImage.TranslucentImage backTranslucentImage;

        //private DraggableWindowModule draggableWindowModule;

        //private TextAdapter titleTextAdapter;

        private Transform childrenHolder;

        public string Title
        {
            get; set;
        }

        public Color TitleColor
        {
            get; set;
        }

        public float TitleOpacity
        {
            get; set;
        }

        public Color WindowColor
        {
            get; set;
        }

        public float WindowOpacity
        {
            get; set;
        }

        public bool Draggable
        {
            get; set;
        }

        public Transform ChildrenHolder => childrenHolder ?? (childrenHolder = gameObject.transform.Find("Mask").Find("Children Holder"));

        public override void Init(GameObject self, Transform parent)
        {

        }

        public HorizontalOrVerticalLayoutGroup CreateLayoutGroup(SFS.UI.ModGUI.Type type, TextAnchor childAlignment = TextAnchor.MiddleCenter, float spacing = 20f, RectOffset padding = null, bool disableChildSizeControl = true)
        {
            return null;
        }

        public void EnableScrolling(SFS.UI.ModGUI.Type type)
        {

        }
    }
}