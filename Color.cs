namespace Raytracer
{
    public class Color : Vector3
    {
        public Color() { }

        public Color(double r, double g, double b) : base(r, g, b) { }

        public Color(double value) : base(value) { }

        public Color(Vector3 vector) : base(vector) { }

        public double R => X;
        public double G => Y;
        public double B => Z;

        public static readonly Color White = new(1d);
        public static readonly Color Black = new(0d);
        public static readonly Color Red = new(1d,   0d, 0d);
        public static readonly Color Green = new(0d, 1d, 0d);
        public static readonly Color Blue = new(0d,  0d, 1d);

        public Color Sum(Color other) => new(base.Sum(other));

        public new Color Add(double value) => new(base.Add(value));

        public Color Diff(Color other) => new(base.Diff(other));

        public new Color Sub(double value) => new(base.Sub(value));

        public Color Hadamard(Color other) => new(base.Hadamard(other));

        public new Color Mult(double value) => new(base.Mult(value));

        public Color Div(Color other) => new(base.Div(other));

        public new Color Div(double value) => new(base.Div(value));
        
        public new Color Sqrt() => new(base.Sqrt());
        
        public new static Color Random() => new(Vector3.Random());

        public new static Color Random(double min, double max) => new(Vector3.Random(min, max));
        
        public static Color operator *(Color a, Color b) => a.Hadamard(b);
        
        public static Color operator *(Color vector, double value) => vector.Mult(value);

        public static Color operator +(Color a, Color b) => a.Sum(b);

        public static Color operator -(Color a, Color b) => a.Diff(b);
        
        public System.Drawing.Color SystemColor => System.Drawing.Color.FromArgb((byte)X, (byte)Y, (byte)Z);
    }
}