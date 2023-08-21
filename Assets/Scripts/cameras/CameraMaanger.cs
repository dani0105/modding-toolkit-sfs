using UnityEngine;
using SFS.Variables;

namespace SFS.Cameras
{
    [RequireComponent(typeof(Camera))]
    public class CameraManager : ObservableMonoBehaviour
    {
        [HideInInspector]
        public Camera camera;
        public Vector2_Local position;
        public Float_Local distance;
        public Float_Local rotation;

        public CameraManager() { }

        public float CameraRotationRadians { get; }
        public float CameraRotationDegrees { get; }
        public float ViewSizeNormal { get; }

        public (Vector2, Vector2) GetFramingData()
        {
            return (Vector2.zero, Vector2.zero);
        }
    }
}