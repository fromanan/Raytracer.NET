using System;
using System.Numerics;

namespace Raytracer
{
    public static class VectorExtensions
    {
        public static Vector3 Normalized(this Vector3 vector)
        {
            return vector / vector.Length();
        }

        public static float Magnitude(this Vector3 vector)
        {
            return MathF.Sqrt(vector.LengthSquared());
        }

        public static Vector3 Sqrt(this Vector3 vector)
        {
            return Vector3.SquareRoot(vector);
        }
        
        public static Vector3 Negate(this Vector3 vector)
        {
            return Vector3.Negate(vector);
        }

        public static Vector3 Cross(this Vector3 vector, Vector3 other)
        {
            return Vector3.Cross(vector, other);
        }

        public static float Dot(this Vector3 vector, Vector3 other)
        {
            return Vector3.Dot(vector, other);
        }
        
        public static Vector3 Reflected(this Vector3 vector, Vector3 normal)
        {
            return vector - normal * (2f * vector.Dot(normal));
        }

        public static Vector3 Refracted(this Vector3 vector, Vector3 normal, float refractiveIndexFraction)
        {
            float cos = MathF.Min(vector.Negate().Dot(normal), 1f);
            Vector3 perpendicular = (vector + normal * cos) * refractiveIndexFraction;
            Vector3 parallel = normal * -MathF.Sqrt(1f - perpendicular.LengthSquared());
            return perpendicular + parallel;
        }
    }
}