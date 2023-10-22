using System.Numerics;

namespace Raytracer.Rendering
{
    public record Scattered(Vector3 Attenuation, Ray Ray, bool DidScatter)
    {
        public Vector3 Attenuation { get; } = Attenuation;
        public Ray Ray { get; } = Ray;
        public bool DidScatter { get; } = DidScatter;
    }
}