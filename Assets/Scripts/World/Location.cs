using SFS.WorldBase;
using System;

namespace SFS.World
{

    [Serializable]
    public class Location
    {
        public double time;
        public Planet planet;
        public Double2 position;
        public Double2 velocity;

        public Location(Planet planet, Double2 position, Double2 velocity = default) { }
        public Location(double time, Planet planet, Double2 position, Double2 velocity) { }
        public double Radius { get; }
        public double Height { get; }
        public double TerrainHeight { get; }
        public double VerticalVelocity { get; }

        public Double2 GetSolarSystemPosition(double time)
        {
            return new Double2();
        }

        public static Location operator +(Location a, Location b)
        {
            return new Location(b.time, b.planet, a.position + b.position, a.velocity + b.velocity);
        }
    }

}