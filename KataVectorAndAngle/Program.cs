using System;
using Operations;

namespace KataVectorAndAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VECTOR AND ANGLE APPLICATION");
            Console.WriteLine("-_______________________________");
            Console.WriteLine("Write a vector1: ");
            double vector1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Write a vector2: ");
            double vector2 = double.Parse(Console.ReadLine());
            Coordenate vector = new Coordenate(vector1,vector2);
            Coordenate.Magnitude(vector1, vector2);
           
        }
    }
}
