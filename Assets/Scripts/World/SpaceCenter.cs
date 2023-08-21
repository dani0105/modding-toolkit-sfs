// SFS.World.SpaceCenter
using System;
using SFS;
using SFS.Parts.Modules;
using SFS.World;
using SFS.WorldBase;
using UnityEngine;

namespace SFS.World
{
    public class SpaceCenter : MonoBehaviour
    {
        [Serializable]
        public class Building
        {
            public StaticWorldObject building;
        }

        public Building vab;

        public Building launchPad;

        public ModelSetup buildings;

    }
}