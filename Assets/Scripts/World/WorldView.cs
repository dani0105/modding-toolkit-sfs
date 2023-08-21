
using SFS.Variables;
using UnityEngine;
using System;
using SFS.Cameras;

namespace SFS.World
{
    public class WorldView : MonoBehaviour
    {
        public const float ScaledSpaceScale = 10000;
        public static WorldView main;
        public PostProcessing[] postProcessing;
        public Action onUpdate;
        public RectTransform mapTransform;
        public Action<Vector2> onVelocityOffset;
        public Action<Location, Location> onViewLocationChange_After;
        public Action<Location, Location> onViewLocationChange_Before;
        public UnityEngine.AudioListener audioListener;
        public Action<Vector2> onPositionOffset;
        public Double2_Local velocityOffset;
        [Space]
        public Double2_Local positionOffset;
        public Bool_Local canVelocityOffset;
        [Space]
        public Bool_Local scaledSpace;
        public Float_Local viewDistance;
        public Vector2_Local framing;
        public CameraManager worldCamera;

        public WorldView() { }

        public Location ViewLocation { get; }

        public static Double2 GetOffset(Double2 a, double b) { return new Double2(); }
        public static Double2 ToGlobalPosition(Vector2 localPosition) { return new Double2(); }
        public static Double2 ToGlobalVelocity(Vector2 localVelocity) { return new Double2(); }
        public static Vector2 ToLocalPosition(Double2 globalPosition) { return new Double2(); }
        public static Vector2 ToLocalVelocity(Double2 globalVelocity) { return new Double2(); }
        public void SetViewLocation(Location newValue) { }
    }
}