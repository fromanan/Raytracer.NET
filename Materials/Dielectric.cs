using System;

namespace Raytracer.Materials
{
    public class Dielectric : IMaterial
    {
        private readonly double _refractionIndex;

        public Dielectric(double refractionIndex)
        {
            _refractionIndex = refractionIndex;
        }

        public Scattered Scatter(Ray ray, Hit hit)
        {
            double refractionRatio = hit.IsFrontFace ? 1d / _refractionIndex : _refractionIndex;

            Vector3 unitDirection = ray.Direction.Normalized;
            double cos = Math.Min(unitDirection.Negate().Dot(hit.Normal), 1d);
            double sin = Math.Sqrt(1d - cos * cos);

            bool cannotRefract = refractionRatio * sin > 1d;
            Vector3 direction;
            if (cannotRefract || Reflectance(cos, refractionRatio) > Global.RandomDouble())
            {
                direction = unitDirection.Reflected(hit.Normal);
            }
            else
            {
                direction = unitDirection.Refracted(hit.Normal, refractionRatio);
            }
            
            return new Scattered
            (
                Attenuation: Color.White,
                Ray: new Ray(hit.Point, direction),
                DidScatter: true
            );
        }

        private static double Reflectance(double cos, double refIdx)
        {
            double r0 = (1d - refIdx) / (1d + refIdx);
            r0 *= r0;
            return r0 + (1d - r0) * Math.Pow(1d - cos, 5);
        }
    }
}