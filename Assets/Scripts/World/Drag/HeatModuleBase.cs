using UnityEngine;

namespace SFS.World.Drag
{
    public abstract class HeatModuleBase : MonoBehaviour
    {
        //public Valid valid;

        protected HeatModuleBase() { }

        public abstract string Name { get; }
        public abstract bool IsHeatShield { get; }
        public abstract float Temperature { get; set; }
        public abstract int LastAppliedIndex { get; set; }
        public abstract float ExposedSurface { get; set; }
        public abstract float HeatTolerance { get; }

        public abstract void OnOverheat(bool breakup);
    }
}