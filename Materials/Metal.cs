using System;

namespace Raytracer.Materials
{
    public class Metal : IMaterial
    {
        private readonly Color _color;
        private readonly double _shininess;

        public Metal(Color color, double shininess)
        {
            _color = color;
            _shininess = Math.Clamp(shininess, 0d, 1d);
        }

        public Scattered Scatter(Ray ray, Hit hit)
        {
            Vector3 reflected = ray.Direction.Normalized.Reflected(hit.Normal);
            Vector3 direction = reflected.Sum(Vector3.RandomInUnitSphere().Mult(_shininess));
            
            return new Scattered
            (
                Ray: new Ray(hit.Point, direction),
                Attenuation: _color,
                DidScatter: direction.Dot(hit.Normal) > 0d
            );
        }
    }
}