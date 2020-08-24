using System;
using System.Text;
using VectorLibrary;

namespace VectorExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Vectors!");

            Vector3 a = new Vector3(10, 10, 10);
            Vector3 b = new Vector3(4, 5, 6);

            Vector3 c = VectorMath.Add(a, b);
            Console.WriteLine("The vector <" + c.X + "," + c.Y + "," + c.Z + ">");

            a.X = -10;
            
            c = VectorMath.Subtract(a, b);
            Console.WriteLine($"The vector <{c.X}, {c.Y}, {c.Z}>");
        }
    }
}
