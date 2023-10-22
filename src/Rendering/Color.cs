using System.Numerics;

namespace Raytracer.Rendering
{
    public static class Color
    {
        public static readonly Vector3 White = new(1f);
        public static readonly Vector3 Black = new(0f);
        public static readonly Vector3 Red = new(1f,   0f, 0f);
        public static readonly Vector3 Green = new(0f, 1f, 0f);
        public static readonly Vector3 Blue = new(0f,  0f, 1f);
        
        public static System.Drawing.Color SystemColor(this Vector3 vector)
        {
            return System.Drawing.Color.FromArgb((byte)vector.X, (byte)vector.Y, (byte)vector.Z);
        }
    }
}