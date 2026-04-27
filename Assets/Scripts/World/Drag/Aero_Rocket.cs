using System.Collections.Generic;
using SFS.Parts;
using SFS.Parts.Modules;
using SFS.World;
using SFS.World.Drag;
using UnityEngine;

namespace SFS.World.Drag
{
    public class Aero_Rocket : AeroModule
    {
        [Space]
        public Rocket rocket;

        protected override bool PhysicsMode => true;

        protected override Location GetLocation()
        {
            return rocket.location.Value;
        }

        protected override List<Surface> GetDragSurfaces(Matrix2x2 rotate)
        {
            return GetDragSurfaces(rocket.partHolder, rotate);
        }

        public static List<Surface> GetDragSurfaces(PartHolder partsHolder, Matrix2x2 rotate)
        {
            return null;
        }

        public void ApplyParachuteDrag(ref float force, ref Vector2 centerOfDrag_World)
        {
        }

        protected override void AddForceAtPosition(Vector2 force, Vector2 position)
        {

        }

        protected override float GetMass()
        {
            return 0; 
        }
    }
}