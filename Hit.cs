using Raytracer.Materials;

namespace Raytracer
{
    public record Hit
    {
        public Hit(Vector3 point, Vector3 normal, IMaterial material, double nearest, bool isFrontFace, bool isHit)
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
            IsFrontFace = ray.Direction.Dot(normal) < 0d;
            Normal = IsFrontFace ? normal : normal.Negate();
        }

        public Vector3 Point { get; set; } = Vector3.Zero;
        public Vector3 Normal { get; private set; } = Vector3.Zero;
        public IMaterial Material { get; set; } = null!;
        public double Nearest { get; set; }
        public bool IsFrontFace { get; private set; }
        public bool IsHit { get; set; }
    }
}