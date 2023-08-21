using SFS.Input;
using SFS.World.Maps;
using UnityEngine;

namespace SFS.World
{
    public class Flag : Player
    {
        public Transform holder;
        public MapIcon mapIcon;
        public WorldLoader loader;
        public int direction;

        public Flag() { }

        public override bool CanTimewarp(I_MsgLogger logger, bool showSpeed) { return true; }
        public override void ClampTrackingOffset(ref Vector2 trackingOffset, float cameraDistance) { }
        public override float GetSizeRadius() { return 0; }
        public override bool OnInputEnd_AsPlayer(OnInputEndData data) { return true; }
        public void ShowPlantAnimation() { }
        public override float TryWorldSelect(TouchPosition data) { return 0; }
    }
}