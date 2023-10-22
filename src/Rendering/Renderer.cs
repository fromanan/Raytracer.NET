using System.Drawing;
using System.Numerics;

namespace Raytracer
{
    public static class Renderer
    {
        private static int MaxReflections => RendererForm.UserSettings.MaxReflections;
        
        private static int SamplesPerPixel => RendererForm.UserSettings.SamplesPerPixel;
        
        public static readonly Scene Scene = new();

        private static IObject World => Scene.World;

        private static Vector3 RayColorIterative(Ray ray, int reflections)
        {
            Vector3 color = Color.White;
            Hit? hit = World.Hit(ray);
            while (hit is { IsHit: true })
            {
                Scattered scattered = hit.Material.Scatter(ray, hit);
                if (reflections <= 0 || !scattered.DidScatter)
                    return Color.Black;

                color = color * scattered.Attenuation;
                ray = scattered.Ray;
                hit = World.Hit(ray);
                --reflections;
            }

            float t = 0.5f * (ray.Direction.Normalized().Y + 1f);
            Vector3 color1 = Color.White; // White
            Vector3 color2 = new(0.5f, 0.7f, 1f);
            return color * (color1 * (1f - t) + (color2 * (t)));
        }

        private static Vector3 RayColor(Ray ray, int reflections)
        {
            if (reflections <= 0)
                return Color.Black;

            Hit? hit = World.Hit(ray);
            if (hit is { IsHit: true })
            {
                Scattered scattered = hit.Material.Scatter(ray, hit);
                return scattered.DidScatter 
                    ? scattered.Attenuation * RayColor(scattered.Ray, reflections - 1)
                    : Color.Black;
            }

            float t = 0.5f * (ray.Direction.Normalized().Y + 1f);
            Vector3 color1 = Color.White;
            Vector3 color2 = new(0.5f, 0.7f, 1f);
            return color1 * (1f - t) + color2 * t;
        }

        public static Vector3 Raycast(Camera camera, Rectangle rect)
        {
            Vector3 color = Color.Black;

            for (int s = 0; s < SamplesPerPixel; ++s)
            {
                float flippedY = rect.Height - rect.Y - 1;
                float u = (rect.X + Global.RandomFloat()) / (rect.Width - 1);
                float v = (flippedY + Global.RandomFloat()) / (rect.Height - 1);

                Ray ray = camera.GetRay(u, v);

                color += RayColor(ray, MaxReflections);
            }
            
            return (color / SamplesPerPixel).Sqrt() * 255f;
        }
    }
}