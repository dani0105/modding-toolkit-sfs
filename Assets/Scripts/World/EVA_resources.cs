
using SFS.Variables;
using SFS.World.Drag;

namespace SFS.World
{
    public class EVA_Resources : HeatModuleBase
    {
        public const double Fuel_DeltaV = 200;
        public Astronaut_EVA astronaut;
        public Double_Reference fuelPercent;
        public Float_Reference temperature;

        public EVA_Resources() { }

        public override string Name { get; }
        public override bool IsHeatShield { get; }
        public override float Temperature { get; set; }
        public override int LastAppliedIndex { get; set; }
        public override float ExposedSurface { get; set; }
        public override float HeatTolerance { get; }

        public void ConsumeFuel(double amount) { }
        public override void OnOverheat(bool _) { }
    }
}