using System;
using System.Numerics;
namespace Operations
{
    public class Coordenate
    {
        double x;
        double y;

        public Coordenate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Magnitude(double x, double y)
        {
            Vector<double> vector1 = new Vector<double>(x);
            Vector<double> vector2 = new Vector<double>(y);
            //double result = Math.Sqrt(vector1 * vector1 + vector1 * vector1);
        }
        public double DotProduct(double x, double y)
        {
            int n = 0;
            double product = 0;
            for (int i = 0; i < n; i++)
            {
                product = product + x * y;
                return product;
            }
            return product;
        }

        public double AngleBetween(Vector2 x, Vector2 y)
        {
            double angle = Math.Atan2(y.Y, y.X) - Math.Atan2(x.Y, x.X);
            return angle;
        }
    }

}
