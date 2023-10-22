using System;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Raytracer
{
    public struct UserSettings
    {
        public int RenderWidth;
        public int SamplesPerPixel;
        public int MaxReflections;
        public PixelFormat PixelFormat;
        public InterpolationMode InterpolationMode;
        public float FocalDistance;
        public float FieldOfView;
        public float Aperture;
        
        // ReSharper disable once SwitchExpressionHandlesSomeKnownEnumValuesWithExceptionInDefault
        public byte BitsPerPixel => PixelFormat switch
        {
            PixelFormat.Format24bppRgb => 24,
            PixelFormat.Format32bppRgb => 32,
            PixelFormat.Format48bppRgb => 48,
            _                          => throw new ArgumentException()
        };
    }
}