using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using SFS.Parts;
using SFS.Parts.Modules;
using SFS.Translations;
using SFS.Input;
using SFS.Variables;
using UnityEngine;

namespace SFS.World
{

    public class Rocket : Player, I_Physics
    {


        public void EnableCollisionImmunity(float duration)
        {

        }

        public float GetRotation()
        {
            return 0f;
        }

        public void SetJointGroup(JointGroup jointsGroup)
        {

        }

        public void SetParts(Part[] newParts)
        {

        }

        public override float GetSizeRadius()
        {
            return 0f;
        }

        public override void ClampTrackingOffset(ref Vector2 trackingOffset, float cameraDistance)
        {

        }

        public override bool OnInputEnd_AsPlayer(OnInputEndData data)
        {
            return true;
        }

        public override float TryWorldSelect(TouchPosition data)
        {
            return 0f;
        }

        public override bool CanTimewarp(I_MsgLogger logger, bool showSpeed)
        {
            return true;
        }


        public static UsePartData[] UseParts(bool fromStaging, params ValueTuple<Part, PolygonData>[] regions)
        {
            return null;
        }

        public static void SetPlayerToBestControllable(params Rocket[] rockets)
        {
        }

        void OnFixedUpdate(Vector2 gravity)
        {

        }

        void I_Physics.OnFixedUpdate(Vector2 gravity)
        {
            throw new NotImplementedException();
        }

        public void OnCrashIntoPlanet()
        {
            throw new NotImplementedException();
        }

        public Rigidbody2D rb2d;

        public Resources resources;

        public GameObject timeManager;

        public GameObject partManager;

        public string rocketName;

        public JointGroup jointsGroup;

        public float collisionImmunity;

        public Float_Local output_TurnAxisTorque;

        public Float_Local output_TurnAxisWheels;

        public Vector2_Local output_DirectionalAxis;

        public Physics physics;

        public bool PhysicsMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Vector2 LocalPosition { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Vector2 LocalVelocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public interface INJ_Rocket
        {
            Rocket Rocket { set; }
        }

        public interface INJ_IsPlayer
        {
            bool IsPlayer { set; }
        }

        public interface INJ_HasControl
        {
            bool HasControl { set; }
        }

        public interface INJ_ThrottleOn
        {
            bool ThrottleOn { set; }
        }

        public interface INJ_Throttle
        {
            float Throttle { set; }
        }

        public interface INJ_TurnAxisTorque
        {
            float TurnAxis { set; }
        }

        public interface INJ_TurnAxisWheels
        {
            float TurnAxis { set; }
        }

        public interface INJ_DirectionalAxis
        {
            Vector2 DirectionalAxis { set; }
        }

        public interface INJ_Physics
        {
            Rigidbody2D Rb2d { set; }
        }

        public interface INJ_Location
        {
            Location Location { set; }
        }

    }
}
