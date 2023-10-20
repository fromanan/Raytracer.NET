using System;
using System.Numerics;
using Raytracer.Materials;

namespace Raytracer.Objects
{
    public class Sphere : IObject
    {
        public readonly Vector3 Center;
        public readonly float Radius;
        public readonly IMaterial Material;

        public Sphere(Vector3 center, float radius, IMaterial material)
        {
            Center = center;
            Radius = radius;
            Material = material;
        }

        public Hit? Hit(Ray ray, float minimumDistance, float maximumDistance)
        {
            Vector3 offset = ray.Origin - Center;

            float a = ray.Direction.LengthSquared();
            float b = offset.Dot(ray.Direction);
            float c = offset.LengthSquared() - Radius * Radius;

            float discriminant = b * b - a * c;
            if (discriminant < 0)
                return null;

            float sqrtd = MathF.Sqrt(discriminant);

            float root = (-b - sqrtd) / a;
            if (root < minimumDistance || root > maximumDistance)
            {
                root = (-b + sqrtd) / a;
                if (root < minimumDistance || root > maximumDistance)
                    return null;
            }

            Vector3 rayAtRoot = ray.At(root);

            Hit hit = new()
            {
                Nearest = root,
                Point = rayAtRoot,
                Material = Material,
                IsHit = true
            };
            
            hit.SetFaceNormal(ray, (rayAtRoot - Center) / Radius);

            return hit;
        }
    }
}