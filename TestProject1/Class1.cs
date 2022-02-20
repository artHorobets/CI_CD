using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class Class1
    {
      static public double GetPerimetrT(double _side1, double _side2, double _side3)
        {
            double perimetr = _side1 + _side2 + _side3;
            return perimetr;
            Console.WriteLine("Hello!");
        }

       static public double GetAreaT(double _side1, double _side2, double _side3)
        {
            double half = GetPerimetrT(_side1, _side2, _side3) / 2;
            double area = Math.Sqrt(half * (half - _side1) * (half - _side2) * (half - _side3));
            return area;
        }

    }
}
