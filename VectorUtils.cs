using System.Numerics;

namespace Raytracer
{
    public static class VectorUtils
    {
        public static Vector3 Random()
        {
            return new Vector3(Global.RandomFloat(), Global.RandomFloat(), Global.RandomFloat());
        }

        public static Vector3 Random(float min, float max)
        {
            float range = max - min;
            return new Vector3
            (
                range * Global.RandomFloat() + min,
                range * Global.RandomFloat() + min,
                range * Global.RandomFloat() + min
            );
        }

        public static Vector3 RandomInUnitSphere()
        {
            while (true)
            {
                Vector3 point = Random(-1f, 1f);
                if (point.LengthSquared() < 1f)
                    return point;
            }
        }

        public static Vector3 RandomUnit()
        {
            return RandomInUnitSphere().Normalized();
        }

        public static Vector3 RandomInUnitCircle()
        {
            while (true)
            {
                Vector3 point = Random(-1f, 1f);
                point.Z = 0f;
                if (point.LengthSquared() < 1f)
                    return point;
            }
        }
    }
}