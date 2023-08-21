// SFS.World.WorldLocation
using SFS.Variables;
using SFS.World;
using UnityEngine;

namespace SFS.World
{
    public class WorldLocation : MonoBehaviour
    {
        public Planet_Local planet = new Planet_Local();

        public Double2_Local position = new Double2_Local();

        public Double2_Local velocity = new Double2_Local();

        public Location Value
        {
            get; set;
        }
    }
}