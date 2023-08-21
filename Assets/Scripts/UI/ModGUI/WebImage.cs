using UnityEngine;

namespace SFS.UI.ModGUI
{
    public class WebImage : GUIElement
    {
        public WebImage() { }

        public string ImageLink { get; set; }
        //public SDWebImage.LoadingIndicatorType LoadingIndicatorType { get; set; }
        public Color LoadingIndicatorColor { get; set; }
        public bool PreserveAspect { get; set; }
        public bool UseMask { get; set; }

        public override void Init(GameObject self, Transform parent) { }
    }
}