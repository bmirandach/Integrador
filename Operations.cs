using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
  internal class Operations
  {
    //los mismos de la práctica anterior pero en inglés
    //tambien tiene las conversiones y el cálculo de la factura (para  no tenerlo en main)
    public static double Add(double a, double b)
    {
      return a + b;
    }

    public static double Subtract(double a, double b)
    {
      return a - b;
    }

    public static double Multiply(double a, double b)
    {
      return a * b;
    }

    public static double Divide(double a, double b)
    {
      if (b != 0)
      {
        return a / b;
      }
      else
      {
        return double.NaN;
      }
    }

    public static double Modulo(double a, double b)
    {
      return a % b;
    }

    public static double Power(double a, double b)
    {
      return Math.Pow(a, b);
    }

    public static double GetAverage3(double a, double b, double c)
    {
      return (a + b + c) / 3;
    }

    public static double GetAverage4(double a, double b, double c, double d)
    {
      return (a + b + c + d) / 4;
    }

    public static double GetAreaTriangle(double b, double h)
    {
      return (b * h) / 2;
    }

    public static double GetPerimeterCicle(double r)
    {
      return 2 * Math.PI * r;
    }

    public static double ConvertToFahrenheit(double c)
    {
      return c * 9 / 5 + 32;
    }

    public static double ConvertToInches(double cm)
    {
      return cm / 2.54;
    }

    public static double ConvertToDollar(double pesos, double c)
    {
      return pesos / c;
    }

    //función que solo sirve para ese restaurant que tiene ese menu
    public static double GetTotalBill(double qHotDogs, double qFrenchFries, double qSodas)
    {
      var total = qHotDogs * 2 + qFrenchFries * 1 + qSodas * 0.85;
      return total * 1.1;
    }
  }
}
