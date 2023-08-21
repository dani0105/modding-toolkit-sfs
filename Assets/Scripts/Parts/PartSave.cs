using System.Collections.Generic;
using Newtonsoft.Json;
using SFS.Parts.Modules;
using UnityEngine;

namespace SFS.Parts
{
    //[global::Beebyte.Obfuscator.SkipAttribute]
    public class PartSave
    {
        [JsonProperty("n")]
        public string name;
        [JsonProperty("p")]
        public Vector2 position;
        [JsonProperty("o")]
        public Orientation orientation;
        [JsonProperty("t")]
        public float temperature;
        [JsonProperty("N")]
        public Dictionary<string, double> NUMBER_VARIABLES;
        [JsonProperty("B")]
        public Dictionary<string, bool> TOGGLE_VARIABLES;
        [JsonProperty("T")]
        public Dictionary<string, string> TEXT_VARIABLES;
        public BurnMark.BurnSave burns;

        public PartSave() { }
        public PartSave(Part part) { }
        public PartSave(string name, Vector2 position, Orientation orientation, Dictionary<string, double> NUMBER_VARIABLES, Dictionary<string, bool> TOGGLE_VARIABLES, Dictionary<string, string> TEXT_VARIABLES) { }

        public static PartSave[] CreateSaves(Part[] parts) { 
            return null;
        }
    }
}