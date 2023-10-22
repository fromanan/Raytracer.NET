using System.Numerics;
using Raytracer.Materials;

namespace Raytracer.Rendering
{
    public record Hit
    {
        public Hit(Vector3 point, Vector3 normal, IMaterial material, float nearest, bool isFrontFace, bool isHit)
        {
            Point = point;
            Normal = normal;
            Material = material;
            Nearest = nearest;
            IsFrontFace = isFrontFace;
            IsHit = isHit;
        }

        public Hit() { }

        public void SetFaceNormal(Ray ray, Vector3 normal)
        {
            IsFrontFace = ray.Direction.Dot(normal) < 0;
            Normal = IsFrontFace ? normal : normal.Negate();
        }

        public Vector3 Point { get; init; } = Vector3.Zero;
        public Vector3 Normal { get; private set; } = Vector3.Zero;
        public IMaterial Material { get; init; } = null!;
        public float Nearest { get; init; }
        public bool IsFrontFace { get; private set; }
        public bool IsHit { get; init; }
    }
}