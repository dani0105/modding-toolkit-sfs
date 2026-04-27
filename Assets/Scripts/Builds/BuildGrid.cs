
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using SFS;
using SFS.Builds;
using SFS.Parts;
using SFS.Parts.Modules;
using SFS.World;

namespace SFS.Builds
{
    public class BuildGrid : MonoBehaviour
    {
        public class PartCollider
        {
            public PolygonData module;
            public ConvexPolygon[] colliders;

            public void UpdateColliders()
            {
            }
        }

        public PartGrid activeGrid;
        //public PartGrid inactiveGrid;

        //[Space]
//        public GridSize gridSize;

        //[Space]
        //public BuildSelector selector;

        [Space]
        public Transform gridTransform;

        public List<PartCollider> buildColliders = new List<PartCollider>();

        public void Duplicate()
        {
        }

        public void ApplyOrientationChange_BuildGrid(Orientation change, Vector2 round)
        {
        }

        public Part[] GetSelectedParts()
        {
            return new Part[0];
        }

        public Part[] GetMirrorParts(params Part[] parts)
        {
            return new Part[0];
        }

        public bool RaycastParts(Vector2 worldPoint, out PartHit hit)
        {
            hit = null;
            return false;
        }

        public void AddParts(bool active, bool clamp, bool applyUndo, params Part[] parts)
        {
        }

        public void RemoveParts(bool enableNonIntersecting, bool applyUndo, params Part[] parts)
        {
        }
    }
}