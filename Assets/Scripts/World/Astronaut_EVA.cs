
using SFS.Parts.Modules;
using UnityEngine;
using SFS.World.Maps;
using SFS.Input;

namespace SFS.World
{
    public class Astronaut_EVA : Player, I_Physics
    {
        public EVA_Resources resources;
        public float ragdollTime;
        public bool ragdoll;
        public float airtime;
        public int facingDirection;
        [Space]
        public WorldSave.Astronauts.Data astronaut;
        public Rigidbody2D rb2d;
        [Space]
        public LayerMask collisions;
        public MoveModule thruster_Down_Right;
        public MoveModule thruster_Down_Left;
        public MoveModule thruster_Up_Right;
        public MoveModule thruster_Up_Left;
        public Transform sprite;
        public MoveModule thruster_Left;
        public MoveModule thruster_Right;
        //public Arrowkeys arrowkeys;
        //public AeroModule aero;
        public MapIcon mapIcon;
        //public StatsRecorder stats;
        public Physics physics;
        public AnimationCurve maxSpeed;
        public AnimationCurve runAcceleration;
        public AnimationCurve stopAcceleration;
        [Space]
        public AnimationCurve jumpVelocity;

        public Astronaut_EVA(){}

        public bool CanPickItselfUp { get; }
        public Vector2 LocalPosition { get; set; }
        public bool PhysicsMode { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Vector2 LocalVelocity { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public static void GetGroundRadius(Location location, out double groundAngleRadians, out double groundRadius)
        {
            groundAngleRadians = 0;
            groundRadius = 0;
        }
        public static float GetTargetAngle(Location loc)
        {
            return 0f;
        }
        public override bool CanTimewarp(I_MsgLogger logger, bool showSpeed)
        {
            showSpeed = false;
            return true;
        }
        public override void ClampTrackingOffset(ref Vector2 trackingOffset, float cameraDistance) { }
        public override float GetSizeRadius()
        {
            return 0;
        }

        public void OnCrashIntoPlanet()
        {
            throw new System.NotImplementedException();
        }

        public void OnFixedUpdate(Vector2 gravity)
        {
            throw new System.NotImplementedException();
        }

        public override bool OnInputEnd_AsPlayer(OnInputEndData data)
        {
            return true;
        }
        public void SetRagdoll(bool enabled) { }
        public override float TryWorldSelect(TouchPosition data)
        {
            return 0;
        }
    }
}