using SFS.World.PlanetModules;
using UnityEngine;

namespace SFS
{
    public class PostProcessing : MonoBehaviour
    {
        public Material postProcessingMaterial;
        public Material starsMaterial;
        //public Stars stars;
        public Material[] reentryMaterials;

        public PostProcessing(){}

        public void SetAmbient(PostProcessingModule.Key ambient, float maxStarIntensity = 1){}
    }
}