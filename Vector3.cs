using System;

namespace Raytracer
{
    public class Vector3
    {
        public double X;
        public double Y;
        public double Z;
        public Vector3() { }

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3(double x, double y)
        {
            X = x;
            Y = y;
            Z = 0d;
        }

        public Vector3(double value)
        {
            X = value;
            Y = value;
            Z = value;
        }

        public Vector3(Vector3 vector)
        {
            X = vector.X;
            Y = vector.Y;
            Z = vector.Z;
        }

        public static readonly Vector3 Zero = new(0d);
        
        public static readonly Vector3 One = new(1d);
        
        public static readonly Vector3 Up = new(0d, 1d, 0d);
        
        public static readonly Vector3 Down = new(0d, -1d, 0d);
        
        public static readonly Vector3 Right = new(1d, 0d, 0d);
        
        public static readonly Vector3 Left = new(-1d, 0d, 0d);
        
        public static readonly Vector3 Forward = new(0d, 0d, 1d);
        
        public static readonly Vector3 Back = new(0d, 0d, -1d);

        public Vector3 Sum(Vector3 other)
        {
            return new Vector3(X + other.X, Y + other.Y, Z + other.Z);
        }

        public Vector3 Add(double value)
        {
            return new Vector3(X + value, Y + value, Z + value);
        }

        public Vector3 Diff(Vector3 other)
        {
            return new Vector3(X - other.X, Y - other.Y, Z - other.Z);
        }

        public Vector3 Sub(double value)
        {
            return new Vector3(X - value, Y - value, Z - value);
        }

        public Vector3 Hadamard(Vector3 other)
        {
            return new Vector3(X * other.X, Y * other.Y, Z * other.Z);
        }

        public Vector3 Mult(double value)
        {
            return new Vector3(X * value, Y * value, Z * value);
        }

        public Vector3 Div(Vector3 other)
        {
            return new Vector3(X / other.X, Y / other.Y, Z / other.Z);
        }

        public Vector3 Div(double value)
        {
            return new Vector3(X / value, Y / value, Z / value);
        }

        public Vector3 Sqrt()
        {
            return new Vector3(Math.Sqrt(X), Math.Sqrt(Y), Math.Sqrt(Z));
        }

        public double LengthSquared => X * X + Y * Y + Z * Z;

        public double Magnitude => Math.Sqrt(LengthSquared);

        public double Dot(Vector3 other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }

        public Vector3 Cross(Vector3 other)
        {
            return new Vector3
            {
                X = Y * other.Z - Z * other.Y,
                Y = Z * other.X - X * other.Z,
                Z = X * other.Y - Y * other.X
            };
        }

        public Vector3 Normalized => Div(Magnitude);

        public Vector3 Negate()
        {
            return new Vector3(-X, -Y, -Z);
        }

        public static Vector3 Random()
        {
            return new Vector3(Global.RandomDouble(), Global.RandomDouble(), Global.RandomDouble());
        }

        public static Vector3 Random(double min, double max)
        {
            double range = max - min;
            return new Vector3
            (
                range * Global.RandomDouble() + min,
                range * Global.RandomDouble() + min,
                range * Global.RandomDouble() + min
            );
        }

        public static Vector3 RandomInUnitSphere()
        {
            while (true)
            {
                Vector3 point = Random(-1d, 1d);
                if (point.LengthSquared < 1d)
                    return point;
            }
        }

        public static Vector3 RandomUnit()
        {
            return RandomInUnitSphere().Normalized;
        }

        public static Vector3 RandomInUnitCircle()
        {
            while (true)
            {
                Vector3 point = Random(-1d, 1d);
                point.Z = 0d;
                if (point.LengthSquared < 1d)
                    return point;
            }
        }

        public Vector3 Reflected(Vector3 normal)
        {
            return Diff(normal.Mult(2d * Dot(normal)));
        }

        public Vector3 Refracted(Vector3 n, double refractiveIndexFraction)
        {
            double cos = System.Math.Min(Negate().Dot(n), 1d);
            Vector3 perpendicular = Sum(n.Mult(cos)).Mult(refractiveIndexFraction);
            Vector3 parallel = n.Mult(-Math.Sqrt(1d - perpendicular.LengthSquared));
            return perpendicular.Sum(parallel);
        }

        public static Vector3 operator *(Vector3 a, Vector3 b) => a.Hadamard(b);
        
        public static Vector3 operator *(Vector3 vector, double value) => vector.Mult(value);

        public static Vector3 operator +(Vector3 a, Vector3 b) => a.Sum(b);

        public static Vector3 operator -(Vector3 a, Vector3 b) => a.Diff(b);
    }
}