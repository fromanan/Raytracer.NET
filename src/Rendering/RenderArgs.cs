using System.Drawing;

namespace Raytracer
{
    public record RenderArgs(Rectangle ViewingRect, Camera Camera)
    {
        public Rectangle ViewingRect { get; } = ViewingRect;
        public Camera Camera { get; } = Camera;
    }
}