// SFS.World.Maps.MapPlanet
using System.Linq;
using SFS.Translations;
using SFS.World;
using SFS.World.Maps;
using SFS.WorldBase;
using UnityEngine;

namespace SFS.World.Maps
{

    public class MapPlanet : SelectableObject
    {
        public Planet planet;

        public override Location Location => planet.GetLocation(0f);

        public override Trajectory Trajectory => planet.trajectory;

        public override string EncounterText => Loc.main.Encounter;

        public override int OrbitDepth => planet.orbitalDepth;

        public override int ClickDepth => planet.orbitalDepth;

        public override Vector3 Select_MenuPosition => planet.mapHolder.transform.position;

        public double FocusDistance
        {
            get;
        }

        public override string Select_DisplayName
        {
            get; set;
        }

        public override bool Select_CanNavigate => true;

        public override bool Select_CanFocus => true;

        public override bool Select_CanRename => false;

        public override bool Select_CanEndMission => false;

        public override string Select_EndMissionText => null;

        public override Sprite Select_EndMissionIcon => null;

        public override double Navigation_Tolerance => 0;

        public override bool Focus_FocusConditions(Double2 relativePosition, double viewDistance)
        {

            return false;
        }

        public override bool IsViewTarget()
        {

            return false;
        }
    }

}