using Sirenix.OdinInspector;
using System;

namespace SFS.Variables
{
    //
    [Serializable]
    public class Double2_Local : Obs<Double2>
    {
        protected override bool IsEqual(Double2 a, Double2 b) => a == b;
    }
    [Serializable]
    public class Double3_Local : Obs<Double3>
    {
        protected override bool IsEqual(Double3 a, Double3 b) => a == b;
    }
}