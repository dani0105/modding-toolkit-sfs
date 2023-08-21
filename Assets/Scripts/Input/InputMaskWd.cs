
// SFS.Input.InputMask2D
using SFS.UI;
using UnityEngine;

namespace SFS.Input
{
    [RequireComponent(typeof(RectTransform))]
    public class InputMask2D : MonoBehaviour
    {
        private RectTransform rectTransform;

        public bool Pointcast(Vector2 canvasPosition)
        {
            return false;
        }

    }
}
