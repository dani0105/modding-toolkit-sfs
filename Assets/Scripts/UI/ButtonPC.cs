
// SFS.UI.ButtonPC

using System;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Serialization;

namespace SFS.UI
{
    public class ButtonPC : SFS.UI.Button
    {
        [FormerlySerializedAs("buttonBackOver")]
        public Image ButtonBackOver;


        [FormerlySerializedAs("buttonIcon")]
        public Image ButtonIcon;

        [FormerlySerializedAs("buttonOverIcon")]
        public Image ButtonOverIcon;

        [FormerlySerializedAs("color")]
        public Color Color;

        [FormerlySerializedAs("overColor")]
        public Color OverColor;

        [NonSerialized]
        public bool useLongClick;

        private bool selected;

        private bool over;

        private bool isDestroy;

        public void SetSelected(bool selected)
        {
            this.selected = selected;
            SetState(over, 0f);
        }

        public override void SetEnabled(bool enabled)
        {
            if (!(this == null))
            {
                base.SetEnabled(enabled);
                SetState(over, 0f);
            }
        }

        private void Awake()
        {
            SetState(over: false, 0f);
        }

        public override void OnMouseEnter()
        {
            SetState(over: true);
        }

        public override void OnMouseExit()
        {
            SetState(over: false);
        }

        private void SetState(bool over, float fadeDuration = 0.1f)
        {

        }



        private void KillTween()
        {

        }
    }
}
