using UnityEngine;
using System.Collections.Generic;
using SFS.IO;
using Newtonsoft.Json;
using UnityEngine.Scripting;
using System;

namespace SFS.World
{
    public class WorldSave
    {
        public string version;
        public CareerState career;
        public WorldState state;
        public Astronauts astronauts;
        public RocketSave[] rockets;
        //public Dictionary<int, Branch> branches;
        //public HashSet<LogId> completeLogs;
        public HashSet<string> completeChallenges;

        //public WorldSave(string version, CareerState career, Astronauts astronauts, WorldState state, RocketSave[] rockets, Dictionary<int, Branch> branches, HashSet<LogId> completeLogs, HashSet<string> completeChallenges) { }

        public static WorldSave CreateEmptyQuicksave(string version)
        {
            return null;
        }
        public static WorldState Load_WorldState(FolderPath path) { return null; }
        public static void Save(FolderPath path, bool saveRocketsAndBranches, WorldSave worldSave, bool isCareer) { }
        public static void Save_AstronautStates(FolderPath path, Astronauts astronautStates) { }
        public static void Save_CareerState(FolderPath path, CareerState careerState) { }
        public static bool TryLoad(FolderPath path, bool loadRocketsAndBranches, I_MsgLogger logger, out WorldSave worldSave)
        {
            worldSave = null;
            return true;
        }

        public class WorldState
        {
            public double worldTime;
            public int timewarpPhase;
            public bool mapView;
            public Double3 mapPosition;
            public string mapAddress;
            public string targetAddress;
            public string playerAddress;
            public float cameraDistance;

            public WorldState(double worldTime, int timewarpPhase, bool mapView, Double3 mapPosition, string mapAddress, string targetAddress, string playerAddress, float cameraDistance) { }

            public static WorldState StartState()
            {
                return null;
            }
        }
        public class Astronauts
        {
            public List<Data> astronauts;
            public List<Crew_World> crew_World;
            public List<EVA> eva;
            public List<Flag> flags;
            public Dictionary<string, HashSet<long>> collectedRocks;

            public Astronauts() { }
            public Astronauts(List<Data> astronauts, List<Crew_World> crew_World, List<EVA> eva, List<Flag> flags, Dictionary<string, HashSet<long>> collectedRocks) { }

            public class Data
            {
                public string astronautName;
                public bool alive;

                public Data() { }
                public Data(string astronautName, bool alive) { }
            }
            public class Crew_World
            {
                public string astronautName;

                public Crew_World() { }
                public Crew_World(string astronautName) { }
            }
            [JsonConverter(typeof(LocationData.LocationConverter))]
            public class EVA
            {
                public string astronautName;
                public LocationData location;
                public float rotation;
                public float angularVelocity;
                public double fuelPercent;
                public float temperature;
                public bool ragdoll;
                public int branch;

                public EVA() { }
                public EVA(Astronaut_EVA a) { }
            }
            [JsonConverter(typeof(LocationData.LocationConverter))]
            public class Flag
            {
                public LocationData location;
                public int direction;

                public Flag() { }
                public Flag(World.Flag flag) { }
            }
        }
        public class CareerState
        {
            public static (UnlockType, string) heatShieldFeature;
            public static (UnlockType, string) throttleFeature;
            public static (UnlockType, string) completedTree_1;
            public static (UnlockType, string) completedTree_2;
            public double funds;
            public List<string> unlocked_Parts;
            public List<string> unlocked_Upgrades;

            public CareerState() { }

            public enum UnlockType
            {
                Part = 0,
                Upgrade = 1
            }
        }
        public class LocationData
        {
            public string address;
            public Double2 position;
            public Double2 velocity;

            public LocationData() { }
            public LocationData(Location location) { }

            public Location GetSaveLocation(double time) { 
                return null;
            }

            [Preserve]
            public class LocationConverter : JsonConverter
            {
                public LocationConverter() { }

                public override bool CanConvert(Type objectType) { return true; }
                public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
                {
                    return true;
                }

                public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }
            }
        }
    }
}