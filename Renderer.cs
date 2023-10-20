using System.Drawing;

namespace Raytracer
{
    public static class Renderer
    {
        private static int MaxReflections => RendererForm.UserSettings.MaxReflections;
        
        private static int SamplesPerPixel => RendererForm.UserSettings.SamplesPerPixel;
        
        public static readonly Scene Scene = new();

        private static IObject World => Scene.World;

        private static Color RayColorIterative(Ray ray, int reflections)
        {
            Color color = Color.White;
            Hit? hit = World.Hit(ray);
            while (hit is { IsHit: true })
            {
                Scattered scattered = hit.Material.Scatter(ray, hit);
                if (reflections <= 0 || !scattered.DidScatter)
                    return Color.Black;

                color = color.Hadamard(scattered.Attenuation);
                ray = scattered.Ray;
                hit = World.Hit(ray);
                --reflections;
            }

            double t = 0.5d * (ray.Direction.Normalized.Y + 1d);
            Color color1 = Color.White; // White
            Color color2 = new(0.5d, 0.7d, 1d);
            return color.Hadamard(color1.Mult(1d - t).Sum(color2.Mult(t)));
        }

        private static Color RayColor(Ray ray, int reflections)
        {
            if (reflections <= 0)
                return Color.Black;

            Hit? hit = World.Hit(ray);
            if (hit is { IsHit: true })
            {
                Scattered scattered = hit.Material.Scatter(ray, hit);
                return scattered.DidScatter 
                    ? scattered.Attenuation.Hadamard(RayColor(scattered.Ray, reflections - 1))
                    : Color.Black;
            }

            double t = 0.5d * (ray.Direction.Normalized.Y + 1d);
            Color color1 = Color.White;
            Color color2 = new(0.5d, 0.7d, 1d);
            return color1.Mult(1d - t).Sum(color2.Mult(t));
        }

        public static Color Raycast(Camera camera, Rectangle rect)
        {
            Color color = Color.Black;

            for (int s = 0; s < SamplesPerPixel; ++s)
            {
                double flippedY = rect.Height - rect.Y - 1;
                double u = (rect.X + Global.RandomDouble()) / (rect.Width - 1);
                double v = (flippedY + Global.RandomDouble()) / (rect.Height - 1);

                Ray ray = camera.GetRay(u, v);

                color = color.Sum(RayColor(ray, MaxReflections));
            }
            
            return color.Div(SamplesPerPixel).Sqrt() * 255d;
        }
    }
}