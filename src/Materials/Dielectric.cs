using System;
using System.Numerics;

namespace Raytracer.Materials
{
    public class Dielectric : IMaterial
    {
        private readonly float _refractionIndex;

        public Dielectric(float refractionIndex)
        {
            _refractionIndex = refractionIndex;
        }

        public Scattered Scatter(Ray ray, Hit hit)
        {
            float refractionRatio = hit.IsFrontFace ? 1f / _refractionIndex : _refractionIndex;

            Vector3 unitDirection = ray.Direction.Normalized();
            float cos = MathF.Min(unitDirection.Negate().Dot(hit.Normal), 1f);
            float sin = MathF.Sqrt(1f - cos * cos);

            bool cannotRefract = refractionRatio * sin > 1f;
            Vector3 direction;
            if (cannotRefract || Reflectance(cos, refractionRatio) > Global.RandomFloat())
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

        private static float Reflectance(float cos, float refIdx)
        {
            float r0 = (1f - refIdx) / (1f + refIdx);
            r0 *= r0;
            return r0 + (1f - r0) * MathF.Pow(1f - cos, 5);
        }
    }
}