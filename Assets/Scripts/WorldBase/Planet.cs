// SFS.WorldBase.Planet
using System;
using System.Collections.Generic;
using System.Linq;
using SFS;
using SFS.Translations;
using SFS.World;
using SFS.World.Maps;
using SFS.World.PlanetModules;
using SFS.WorldBase;
using UnityEngine;
namespace SFS.WorldBase
{
    public class Planet : MonoBehaviour
    {
        public string codeName;

        public Transform mapHolder;

        public MapPlanet mapPlanet;

        public Landmark[] landmarks;

        public Trajectory trajectory;

        public Orbit orbit;

        public Planet parentBody;

        public Planet[] satellites;

        public double mass;

        public double SOI;

        public double maxTerrainHeight;

        public Texture2D planetTexture;

        public Material terrainMaterial;

        public Material atmosphereMaterial;

        public int orbitalDepth;

        public int satelliteIndex;

        public PlanetData data;

        public double Radius => data.basics.radius;

        public double SurfaceArea => Radius * (Math.PI * 2.0);

        public double AtmosphereHeightPhysics
        {
            get;
        }

        public double TimewarpRadius_Ascend => 0;

        public double TimewarpRadius_Descend => 0;

        public double OrbitRadius => 0;

        public bool HasParent => false;

        public bool HasAtmospherePhysics => false;

        public bool HasAtmosphereVisuals => false;

        public double RewardMultiplier => 1.0;

        public Field DisplayName { get; private set; }

        public double GetGravity(double radius)
        {
            return 0;
        }

        public Double2 GetGravity(Double2 position)
        {
            return new Double2();
        }

        public double GetEscapeVelocity(double radius)
        {
            return Math.Sqrt(2.0 * mass / radius);
        }

        public Location GetLocation(double time)
        {
            return new Location(0, null, new Double2(),new Double2());
        }

        public Double2 GetSolarSystemPosition()
        {
            return new Double2();
        }

        public Double2 GetSolarSystemPosition(double time)
        {
            return new Double2();
        }

        public int GetVerticeCount(double size_Angular, double verticeSize)
        {
            return 0;
        }

        public int GetMaxLOD()
        {
            return 0;
        }

        public bool IsInsideTerrain(Double2 position, double threshold)
        {
            return true;
        }

        public Double2 GetTerrainNormal(Double2 globalPosition)
        {
            return new Double2();
        }

        public double GetTerrainHeightAtAngle(double angleRadians)
        {
            return 0;
        }

        public float[] GetTerrainNormals(params double[] angles_Radians)
        {
            return null;
        }

        public double[] GetTerrainHeightAtAngles(params double[] angleRadians)
        {
            return null;
        }

        public bool IsInsideAtmosphere(Double2 position)
        {
            return true;
        }

        public double GetAtmosphericDensity(double height)
        {
            return 0;
        }

        public bool IsOutsideSOI(Double2 position)
        {
            return false;
        }

        public bool IsInsideSOI(Double2 positionToParent)
        {
            return false;
        }

        public static double GetTimewarpRadius_AscendDescend(Location location)
        {
            return 0;
        }

        public void SetupData(string codeName, PlanetData data, Shader terrainShader, Shader atmosphereShader, I_MsgLogger log)
        {

        }


        public void SetupInteractions(Dictionary<string, Planet> planets)
        {

        }

        public Color GetTerrainColor(Double2 position)
        {
            return Color.red;
        }
    }

}