using UnityEngine;

namespace SFS.Input
{
    public class DragData
    {
        public readonly Vector2 deltaPixel;

        public DragData(Vector2 deltaPixel)
        {
            this.deltaPixel = deltaPixel;
        }

        public Vector2 DeltaWorld(float positionZ)
        {
            return Vector2.zero;
        }
    }
}
