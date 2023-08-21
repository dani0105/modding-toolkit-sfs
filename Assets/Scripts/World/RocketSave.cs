using Newtonsoft.Json;
using SFS.Parts;

namespace SFS.World
{
    [JsonConverter(typeof(WorldSave.LocationData.LocationConverter))]
    public class RocketSave
    {
        public string rocketName;
        public WorldSave.LocationData location;
        public float rotation;
        public float angularVelocity;
        public bool throttleOn;
        public float throttlePercent;
        public bool RCS;
        public PartSave[] parts;
        //public JointSave[] joints;
        //public StageSave[] stages;
        public bool staging_EditMode;
        public int branch;

        public RocketSave(){}
        public RocketSave(Rocket rocket){}
    }
}