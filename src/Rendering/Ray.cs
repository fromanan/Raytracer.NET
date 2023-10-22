using System.Numerics;

namespace Raytracer
{
    public readonly struct Ray
    {
        public readonly Vector3 Origin;
        public readonly Vector3 Direction;

        public Ray(Vector3 origin, Vector3 direction)
        {
            Origin = origin;
            Direction = direction;
        }

        public Vector3 At(float distance)
        {
            return Origin + Direction * distance;
        }
    }
}