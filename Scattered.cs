namespace Raytracer
{
    public record Scattered(Color Attenuation, Ray Ray, bool DidScatter)
    {
        public Color Attenuation { get; } = Attenuation;
        public Ray Ray { get; } = Ray;
        public bool DidScatter { get; } = DidScatter;
    }
}