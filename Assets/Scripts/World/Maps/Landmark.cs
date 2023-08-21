// SFS.World.Maps.Landmark
using System;
using SFS.Translations;
using SFS.World.Maps;
using SFS.WorldBase;
using UnityEngine;

namespace SFS.World.Maps
{
    public class Landmark : MonoBehaviour
    {
        public LandmarkData data;

        public Double2 position;

        public Field displayName;

        public void Initialize(LandmarkData data, Planet planet)
        {
        }


        private void UpdateName()
        {

        }

        private static Field GetDisplayName(string codeName)
        {
            return null;
        }
    }
}