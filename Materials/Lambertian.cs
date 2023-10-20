namespace Raytracer.Materials
{
    public class Lambertian : IMaterial
    {
        public readonly Color Color;

        public Lambertian(Color color)
        {
            Color = color;
        }

        // TODO: Implement near zero correction
        public Scattered Scatter(Ray ray, Hit hit)
        {
            Vector3 direction = hit.Normal.Sum(Vector3.RandomUnit());
            
            return new Scattered
            (
                Ray: new Ray(hit.Point, direction),
                Attenuation: Color,
                DidScatter: true
            );
        }
    }
}