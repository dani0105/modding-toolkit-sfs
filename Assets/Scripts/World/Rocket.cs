using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using SFS.Parts;
using SFS.Parts.Modules;
using SFS.World.Drag;
using SFS.Translations;
using SFS.Input;
using SFS.Variables;
using UnityEngine;

namespace SFS.World
{
	public class Rocket : Player, I_Physics
	{
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

		public Mass_Calculator mass;

		public Rigidbody2D rb2d;

		public PartHolder partHolder;

		//public MapIcon mapIcon;

		//public Arrowkeys arrowkeys;

		//public Throttle throttle;

		//public Staging staging;

		public SFS.World.Resources resources;

		public Aero_Rocket aero;

		//public StatsRecorder stats;

		public GameObject timeManager;

		public GameObject partManager;

		public string rocketName;

		public JointGroup jointsGroup;

		public float collisionImmunity;

		public bool floating;

		public Float_Local output_TurnAxisTorque;

		public Float_Local output_TurnAxisWheels;

		public Vector2_Local output_DirectionalAxis;

		public Physics physics;

		bool I_Physics.PhysicsMode
		{
			get
			{
				if (rb2d != null)
				{
					return rb2d.simulated;
				}
				return false;
			}
			set
			{
				rb2d.simulated = value;
				Collider2D[] componentsInChildren = partHolder.GetComponentsInChildren<Collider2D>(includeInactive: true);
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					componentsInChildren[i].enabled = value;
				}
				if (!rb2d.simulated)
				{
					rb2d.angularVelocity = 0f;
				}
			}
		}

		Vector2 I_Physics.LocalPosition
		{
			get
			{
				return (Vector2)rb2d.transform.position + (Vector2)rb2d.transform.TransformVector(mass.GetCenterOfMass());
			}
			set
			{
				Transform obj = rb2d.transform;
				Vector2 vector2 = (rb2d.position = value - (Vector2)rb2d.transform.TransformVector(mass.GetCenterOfMass()));
				obj.position = vector2;
			}
		}

        public Vector2 LocalVelocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void EnableCollisionImmunity(float duration)
		{
			collisionImmunity = Time.time + duration;
		}

		public float GetRotation()
		{
			Vector3 zero = Vector3.zero;
			Vector3 zero2 = Vector3.zero;
			EngineModule[] modules = partHolder.GetModules<EngineModule>();
			foreach (EngineModule engineModule in modules)
			{
				if (engineModule.engineOn.Value)
				{
					zero += engineModule.transform.TransformVector(engineModule.thrustNormal.Value * engineModule.thrust.Value);
				}
				else
				{
					zero2 += engineModule.transform.TransformVector(engineModule.thrustNormal.Value * engineModule.thrust.Value);
				}
			}
			if (zero != Vector3.zero)
			{
				return Mathf.Atan2(zero.y, zero.x) * 57.29578f;
			}
			if (zero2 != Vector3.zero)
			{
				return Mathf.Atan2(zero2.y, zero2.x) * 57.29578f;
			}
			ControlModule[] modules2 = partHolder.GetModules<ControlModule>();
			int i = 0;
			if (i < modules2.Length)
			{
				return modules2[i].transform.eulerAngles.z + 90f;
			}
			return base.transform.eulerAngles.z;
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
			return false;
		}

		public override float TryWorldSelect(TouchPosition data)
		{
			return float.PositiveInfinity;
		}

		public override bool CanTimewarp(I_MsgLogger logger, bool showSpeed)
		{
			return false;
		}

		public static UsePartData[] UseParts(bool fromStaging, params (Part, PolygonData)[] regions)
		{
			return new UsePartData[0];
		}

		public static void SetPlayerToBestControllable(params Rocket[] rockets)
		{
		}

		void I_Physics.OnCrashIntoPlanet()
		{
		}

		void I_Physics.OnFixedUpdate(Vector2 gravity)
		{
		}
	}
}
