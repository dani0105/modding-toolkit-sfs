// SFS.World.Orbit
using System;
using SFS.Translations;
using SFS.World;
using SFS.WorldBase;
using UnityEngine;

[Serializable]
public class Orbit : I_Path
{
    private const double StationaryThreshold = 0.1;

    private const double Margin = 0.1;

    public double sma;

    public double semiMinorAxis;

    public double slr;

    public double arg;

    //public Matrix2x2_Double arg_Matrix;

    public double periapsis;

    public double apoapsis;

    public double ecc;

    public double meanMotion;

    public int direction;

    public double period;

    public double periapsisPassageTime;

    [Space]
    public PathType pathType;

    private Planet nextPlanet;

    [Space]
    public double orbitStartTime;

    public double orbitEndTime;

    [Space]
    public Func<string> encounterText;

    private Location location_Out;

    private double trueAnomaly_Out;

    public PathType PathType => pathType;

    public double PathStartTime => orbitStartTime;

    public double PathEndTime => orbitEndTime;

    public Planet Planet => location_Out.planet;

    public Planet NextPlanet => nextPlanet;

    public static Orbit TryCreateOrbit(Location location, bool calculateTimeParameters, bool calculateEncounters, out bool success)
    {
        success= false;
        return null;
    }

    public Orbit(Location location, bool calculateTimeParameters, bool calculateEncounters)
    {
    }

    public Orbit(double sma, double ecc, double arg, int direction, Planet planet, PathType pathType, Planet nextPlanet)
    {
    }

    private void SetOrbitType(PathType orbitType, Planet nextPlanet, double orbitEndTime)
    {
    }

    public void SetEncounter(Planet nextPlanet, double orbitEndTime, Func<string> encounterText)
    {
    }

    public Vector3[] GetPoints(double fromTrueAnomaly, double toTrueAnomaly, int resolution, double scaleMultiplier)
    {
        return null;
    }

    public Vector3[] GetPoints_Ellipse(double fromTrueAnomaly, double toTrueAnomaly, int resolution, double scaleMultiplier)
    {
        return null;
    }

    public Double2[] GetEllipseArray(int resolution)
    {
        return  new Double2[0];
    }

    public Double2 GetPositionFromEccentricAnomaly(double eccentricAnomaly)
    {
        return new Double2();
    }

    public Double2 GetPositionAtAngle(double angleRadians)
    {
        return new Double2();
    }

    public Double2 GetPositionAtTrueAnomaly(double trueAnomaly)
    {
        return new Double2();
    }

    public Double2 GetVelocityAtAngle(double angleRadians)
    {
        return new Double2();
    }

    public Double2 GetVelocityAtTrueAnomaly(double trueAnomaly)
    {
        return new Double2();
    }

    public Location GetLocation(double time)
    {
        return new Location(0,null, new Double2(),new Double2());
    }

    public double GetStopTimewarpTime(double timeOld, double timeNew)
    {
        return 0;
    }

    public double GetTrueAnomaly(double time)
    {
        return 0;
    }

    private void UpdateLocation(double newTime)
    {
    }

    public double GetNextAnglePassTime(double time, double angleRadians)
    {
        return 0;
    }

    public double GetLastAnglePassTime(double time, double angleRadians)
    {
        return 0;
    }

    public double GetNextTrueAnomalyPassTime(double time, double trueAnomaly)
    {
        return 0;
    }

    public double GetLastTrueAnomalyPassTime(double time, double trueAnomaly)
    {
        return 0;
    }

    public bool UpdateEncounters()
    {
        return true;
    }

    private bool FindEncounters(double window_Start, double window_End)
    {
        return true;
    }

    private bool ProcessEncounters(Planet satellite, double window_Start, double window_End)
    {
        return true;
    }

    private bool GetFastestPossibleArrivalTime(ref double time, Planet satellite, double maxAcceleration)
    {
        return true;
    }

    private double GetFallTime(double verticalVelocity, double startHeight, double gravity)
    {
        return 0;
    }
}
