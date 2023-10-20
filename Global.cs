using System;

namespace Raytracer
{
    public static class Global
    {
        public static readonly Random Random = new();

        public static double RandomDouble() => Random.NextDouble();
    }
}