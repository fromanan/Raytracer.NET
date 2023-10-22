using System;
using System.Numerics;
using Raytracer.Rendering;

namespace Raytracer.Materials
{
    public class Metal : IMaterial
    {
        private readonly Vector3 _color;
        private readonly float _shininess;

        public Metal(Vector3 color, float shininess)
        {
            _color = color;
            _shininess = Math.Clamp(shininess, 0f, 1f);
        }

        public Scattered Scatter(Ray ray, Hit hit)
        {
            Vector3 reflected = ray.Direction.Normalized().Reflected(hit.Normal);
            Vector3 direction = reflected + VectorUtils.RandomInUnitSphere() * _shininess;
            
            return new Scattered
            (
                Ray: new Ray(hit.Point, direction),
                Attenuation: _color,
                DidScatter: direction.Dot(hit.Normal) > 0
            );
        }
    }
}