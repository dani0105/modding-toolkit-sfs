// SFS.World.Trajectory
using System;
using System.Collections.Generic;
using System.Linq;
using SFS;
using SFS.World;

namespace SFS.World
{

    [Serializable]
    public class Trajectory
    {
        public List<I_Path> paths;

        public static Trajectory Empty => new Trajectory(new List<I_Path>());

        private int ConicSectionsCount => 0;

        public Trajectory(List<I_Path> paths)
        {
        }

        public Trajectory(I_Path path)
        {

        }

        public static Trajectory CreateTrajectory(Location location)
        {
            return null;
        }

        public static Trajectory CreateStationaryTrajectory(StaticWorldObject staticObject)
        {
            return null;
        }

        public static I_Path CreatePath(Location location)
        {
            return null;
        }

        public Location GetLocation(double time)
        {
            return null;
        }

        public double GetPathEndTime()
        {
            return 0;
        }

        public double GetStopTimewarpTime(double timeOld, double timeNew)
        {
            return 0;
        }

        public void CheckPathTransition(double time)
        {

        }

        public void CheckEncounters()
        {

        }

        public void EnterNextPath()
        {

        }

        private void CalculatePaths()
        {

        }

        private bool GetNextPath(out I_Path nextPath)
        {
            nextPath = null;
            return false;
        }
    }

}