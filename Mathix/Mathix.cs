using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathix
{
    public class Mathix
    {
        List<double> answer = new List<double>();
        public List<double> Descriminant(double a, double b, double c)
        {
            var D = b * b - 4 * (a * c);
            var x0 = (-b + Math.Sqrt(D)) / 2 * a;
            var x1 = (-b - Math.Sqrt(D)) / 2 * a;
            if (D == 0)
            {
                return new List<double> { x0 };
            }
            else if (D < 0)
            {
                return new List<double>();
            }
            else
            {
                return new List<double> { Math.Round(x0,2), Math.Round(x1,2) };
            }
        }

        public double getProcent(double target, double procent) => target * procent / 100;
    }
}
