using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ12
{
    internal class Circle
    {
        static public double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI * r * r;
        }
        static public string GetRadius(double r, double x, double x0, double y, double y0)
        {
            double deltaX = x - x0;
            double deltaY = y - y0;
            double deltaR = r*r -deltaX*deltaX-deltaY*deltaY;
            if (deltaR <= 0)
                return "Точка лежит в круге";
            else return "Точка лежит вне круга";
        }

    }
}
