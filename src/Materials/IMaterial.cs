using Raytracer.Rendering;

namespace Raytracer.Materials
{
    public interface IMaterial
    {
        Scattered Scatter(Ray ray, Hit hit);
    }
}