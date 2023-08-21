
// SFS.World.MapPlayer
using System;
using SFS.World;
using SFS.World.Maps;
using UnityEngine;

namespace SFS.World
{
    public abstract class MapPlayer : SelectableObject
    {
        public MapIcon mapIcon;

        public override Location Location => Player.location.Value;

        public override int OrbitDepth => Player.location.planet.Value.orbitalDepth + 1;

        public override int ClickDepth => Player.location.planet.Value.orbitalDepth + 1;

        public abstract Player Player { get; }

        public abstract override Trajectory Trajectory { get; }


        private void OnPlayerChange()
        {

        }

        public override bool Focus_FocusConditions(Double2 relativePosition, double viewDistance)
        {
            return false;
        }

        public virtual void OnEndMission()
        {

        }
    }
}