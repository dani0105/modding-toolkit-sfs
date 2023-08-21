// SFS.Logs.LogsModule
using System;
using SFS;
using SFS.Logs;
//using SFS.Stats;
using SFS.Translations;
using SFS.World;
using SFS.World.Maps;
using SFS.WorldBase;

namespace SFS.Logs
{
    [Serializable]
    public class LogsModule
    {
        public bool Landed = true;

        public bool Takeoff = true;

        public bool Atmosphere = true;

        public bool Orbit = true;

        public bool Crash = true;

        /*public static void Log_Dock(Action<LogId, double, string> logger, Planet planet, bool landed, StatsRecorder.Tracker.State_Orbit orbit)
        {

        }

        public static void Log_Orbit(Action<LogId, double, string> logger, Planet planet, StatsRecorder.Tracker.State_Orbit orbit, StatsRecorder.Tracker.State_Orbit orbit_Old, StatsRecorder.Tracker.State_Orbit orbit_Old_Old)
        {

        }*/

        public static void Log_Landed(Action<LogId, double, string> logger, bool landed, Planet planet, double angleDegrees, bool endMissionMenu)
        {

        }

        public static void Log_Planet(Action<LogId, double, string> logger, Planet planet, Planet planet_Old)
        {

        }

        public static void Log_Crash(Action<LogId, double, string> logger, Planet planet)
        {

        }

        /*public static void Log_LeftCapsule(Action<LogId, double, string> logger, Planet planet, bool landed, StatsRecorder.Tracker.State_Orbit orbit)
        {

        }*/

        public static void Log_Flag(Action<LogId, double, string> logger, Planet planet, double angleDegrees)
        {

        }

        public static void Log_CollectRock(Action<LogId, double, string> logger, Planet planet, double angleDegrees)
        {

        }

        /*public static void Log_Atmosphere(Action<LogId, double, string> logger, Planet planet, StatsRecorder.Tracker.State_Atmosphere state, StatsRecorder.Tracker.State_Atmosphere state_Old, bool hideEnteredAtmosphere)
        {

        }*/

        public static void Log_End(Action<LogId, double, string> logger, Location location, bool landed)
        {

        }

        public static void Log_ReachedHeight(Action<LogId, double, string> logger, double height)
        {

        }

        public static void Log_Reentry(Action<LogId, double, string> logger, Planet planet, float temperature)
        {

        }
    }
}