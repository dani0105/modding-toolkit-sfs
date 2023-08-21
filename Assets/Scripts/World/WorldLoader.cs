
using System;
using UnityEngine;

namespace SFS.World
{
    public class WorldLoader : MonoBehaviour
    {
        public WorldLocation location;
        public GameObject holder;
        public double loadDistance;

        public WorldLoader() { }

        public bool Loaded { get; }

        public event Action<bool, bool> onLoadedChange_Before;
        public event Action<bool, bool> onLoadedChange_After;
    }
}