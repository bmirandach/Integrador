using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
  //clase que realiza SOLO las operaciones, si es posible
  internal class Calculator
  {
    private double Value;

    public Calculator()
    {
      Value = 0d;
    }

    public double GetValue()
    {
      return Value;
    }

    public void Add(double value)
    {
      Value += value;
    }

    public void Subtract(double value)
    {
      Value -= value;
    }

    public void Divide(double value)
    {
      if (value != 0)
      {
        Value /= value;
      }
      else
      {
        Console.WriteLine("Can't divide by zero!!");
      }
    }

    public void Multiply(double value)
    {
      Value *= value;
    }
  }
}
