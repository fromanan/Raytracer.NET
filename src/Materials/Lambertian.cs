using System.Numerics;
using Raytracer.Rendering;

namespace Raytracer.Materials
{
    public class Lambertian : IMaterial
    {
        public readonly Vector3 Color;

        public Lambertian(Vector3 color)
        {
            Color = color;
        }

        // TODO: Implement near zero correction
        public Scattered Scatter(Ray ray, Hit hit)
        {
            Vector3 direction = hit.Normal + VectorUtils.RandomUnit();
            
            return new Scattered
            (
                Ray: new Ray(hit.Point, direction),
                Attenuation: Color,
                DidScatter: true
            );
        }
    }
}