using System;
using Raytracer.Materials;

namespace Raytracer.Objects
{
    public class Sphere : IObject
    {
        public readonly Vector3 Center;
        public readonly double Radius;
        public readonly IMaterial Material;

        public Sphere(Vector3 center, double radius, IMaterial material)
        {
            Center = center;
            Radius = radius;
            Material = material;
        }

        public Hit? Hit(Ray ray, double minimumDistance, double maximumDistance)
        {
            Vector3 offset = ray.Origin.Diff(Center);

            double a = ray.Direction.LengthSquared;
            double b = offset.Dot(ray.Direction);
            double c = offset.LengthSquared - Radius * Radius;

            double discriminant = b * b - a * c;
            if (discriminant < 0d)
                return null;

            double sqrtd = Math.Sqrt(discriminant);

            double root = (-b - sqrtd) / a;
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
            
            hit.SetFaceNormal(ray, rayAtRoot.Diff(Center).Div(Radius));

            return hit;
        }
    }
}