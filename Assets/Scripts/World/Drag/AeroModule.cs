using System;
using System.Collections.Generic;
using System.Linq;
using SFS.Parts.Modules;
using SFS.World;
using SFS.World.Drag;
using UnityEngine;
namespace SFS.World.Drag
{
    public abstract class AeroModule : MonoBehaviour
    {

        protected abstract bool PhysicsMode { get; }


        public static void GetTemperatureAndShockwave(Location location, out float Q, out float shockOpacity, out float temperature)
        {
            Q = 0 ;
            temperature = 0;
            shockOpacity = 0;
        }

        public static float GetIntensity(float value, float halfPoint)
        {
            return value / (value + halfPoint);
        }

        public static float GetHeatTolerance(HeatTolerance a)
        {
            return a switch
            {
                HeatTolerance.High => 6000,
                HeatTolerance.Mid => 1000,
                HeatTolerance.Low => 400,
                _ => 0,
            };
        }

        public static List<Surface> GetExposedSurfaces(List<Surface> surfacesList)
        {
            return null;
        }

        public static Surface[] Sort(List<Surface> list)
        {
            return null;
        }


        public static Line2[] RotateSurfaces(List<Surface> surfaces, Matrix2x2 localToWorld)
        {
            return null;
        }

        public static bool IsInsideAtmosphereAndIsMoving(Location location)
        {
            return false;
        }

        protected abstract Location GetLocation();

        protected abstract List<Surface> GetDragSurfaces(Matrix2x2 rotate);

        protected abstract void AddForceAtPosition(Vector2 force, Vector2 position);

        protected abstract float GetMass();
    }
}