using UnityEngine;

namespace SFS.Parts.Modules
{
    public class BurnMark : MonoBehaviour
    {
        public Burn burn;

        public BurnMark() { }

        public void ApplyEverything() { }
        public float GetAngleRadWorld() { return 0f; }
        public void Initialize() { }
        public void SetBurn(Vector2 velocityDirection, Transform positionContext, float intensity, Line2[] topSurfaces_World, Line2[] bottomSurfaces_World, float opacity) { }
        public void SetOpacity(float opacity, bool forceApply) { }

        public class Burn
        {
            public float angle;
            public float intensity;
            public float x;
            public Line2[] topSurfaces;
            public Line2[] bottomSurfaces;

            public Burn() { }

            public Burn GetCopy()
            {
                return new Burn();
            }
        }
        public class BurnSave
        {
            public float angle;
            public float intensity;
            public float x;
            public string top;
            public string bottom;

            public BurnSave() { }
            public BurnSave(Burn burn) { }

            public Burn FromSave()
            {
                return new Burn();
            }
        }
    }
}