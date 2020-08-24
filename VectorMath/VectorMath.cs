using System;
using System.Collections.Generic;
using System.Text;

namespace VectorLibrary
{
    public static class VectorMath
    {
        public static double Magnitude(Vector3 vector)
        {
            return Math.Sqrt(Math.Pow(vector.X, 2) + Math.Pow(vector.Y, 2) + Math.Pow(vector.Z, 2));
        }

        public static Vector3 Normalize(Vector3 vector)
        {
            var magnitude = Magnitude(vector);
            return new Vector3(vector.X / magnitude, vector.Y / magnitude, vector.Z / magnitude);
        }

        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector3 Subtract(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);       
        } 

        public static Vector3 Scale(Vector3 a, double s)
        {
            return new Vector3(s * a.X, s * a.Y, s * a.Z);
        }

        public static double DotProduct(Vector3 a, Vector3 b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        public static Vector3 CrossProduct(Vector3 a, Vector3 b)
        {
            return new Vector3(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
        }
    }
}
