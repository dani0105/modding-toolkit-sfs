namespace SFS.World.PlanetModules
{
    public class PostProcessingModule
    {
        public Key[] keys;

        public PostProcessingModule() { }

        public Key Evaluate(float height)
        {
            return null;
        }

        public class Key
        {
            public float height;
            public float shadowIntensity;
            public float starIntensity;
            public float hueShift;
            public float saturation;
            public float contrast;
            public float red;
            public float green;
            public float blue;

            public Key() { }
            public Key(float height, float shadowIntensity, float starIntensity, float hueShift, float saturation, float contrast, float red, float green, float blue)
            {

            }

            public static Key Lerp(Key a, Key b, float t)
            {
                return null;
            }
        }
    }
}