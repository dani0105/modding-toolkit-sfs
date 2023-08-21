// SFS.Variables.Planet_Local
using System;
using SFS.Variables;
using SFS.WorldBase;

namespace SFS.Variables
{
    [Serializable]
    public class Planet_Local : Obs<Planet>
    {
        protected override bool IsEqual(Planet a, Planet b)
        {
            return a == b;
        }
    }
}