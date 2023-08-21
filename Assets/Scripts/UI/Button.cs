
// SFS.UI.ButtonPC
using System;
using SFS.Input;
using SFS.Variables;
using UnityEngine;
using System.Collections.Generic;

namespace SFS.UI
{

    [ExecuteAlways]
    public class Button : MonoBehaviour, I_Key, I_Touchable, I_Raycastable
    {
        public bool advancedBorder;

        public float border;

        public float top;

        public float bottom;

        public float left;

        public float right;

        public bool skipRaycast;

        public int layoutPriority;

        public bool noClickSound;

        [HideInInspector]
        public Bool_Local onKeyDown;

        [HideInInspector]
        public Bool_Local onKey;

        [HideInInspector]
        public Bool_Local onKeyUp;

        protected bool buttonEnabled = true;

        private Vector2 initialIconScale;

        private InputMask2D[] inputMasks;

        bool I_Raycastable.SkipRaycast => skipRaycast;

        private void OnKeyChange()
        {

        }


        public virtual void SetEnabled(bool enabled)
        {

        }

        private Vector3 GetIconScale()
        {
            return Vector3.zero;
        }

        private void SetIconScale(Vector3 newIconScale)
        {

        }


        RectTransform I_Raycastable.GetRect()
        {
            return GetComponent<RectTransform>();
        }


        public virtual void OnMouseEnter()
        {
        }

        public virtual void OnMouseExit()
        {
        }

        public bool IsKeyDown()
        {
            throw new NotImplementedException();
        }

        public bool IsKeyStay()
        {
            throw new NotImplementedException();
        }

        public bool IsKeyUp()
        {
            throw new NotImplementedException();
        }

        public List<int> GetPriority()
        {
            throw new NotImplementedException();
        }

        public bool PointcastElement(TouchPosition position)
        {
            throw new NotImplementedException();
        }

        public void OnInputStart(OnInputStartData data)
        {
            throw new NotImplementedException();
        }

        public void OnInputStay(OnInputStayData data)
        {
            throw new NotImplementedException();
        }

        public void OnInputEnd(OnInputEndData data)
        {
            throw new NotImplementedException();
        }

        public void OnTouchLongClick(OnTouchLongClickData data)
        {
            throw new NotImplementedException();
        }

        public void OnNotStationary(OnNotStationary data)
        {
            throw new NotImplementedException();
        }

        public void OnDrag(DragData data)
        {
            throw new NotImplementedException();
        }

        public void OnZoom(ZoomData data)
        {
            throw new NotImplementedException();
        }
    }

}
