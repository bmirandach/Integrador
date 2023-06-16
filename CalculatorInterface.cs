using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
  //clase que maneja la interaccion con el usuario
  internal class CalculatorInterface
  {
    private Calculator Calculator;

    public CalculatorInterface()
    {
      Calculator = new Calculator();
    }


    private void ShowMenu()
    {
      Console.WriteLine("Enter the corresponding option for the operation you wish to perform:");
      Console.WriteLine("1. Addition");
      Console.WriteLine("2. Subtraction");
      Console.WriteLine("3. Multiplication");
      Console.WriteLine("4. Division");
      Console.WriteLine("5. Exit");
    }

    private void ShowCurrentValue()
    {
      Console.WriteLine("Current value: " + Calculator.GetValue());
    }

    private double GetNewValue()
    {
      Console.WriteLine("Enter the value: ");
      //no valida que sea un numero
      return double.Parse(Console.ReadLine());
    }

    /// <summary>
    /// Seria el metodo que 'prende' la calculadora
    /// </summary>
    public void Activate()
    {
      const string Add = "1";
      const string Subtract = "2";
      const string Multiply = "3";
      const string Divide = "4";
      const string Quit = "5";
      bool quit = false; //true cuando el usuario dice que quiere salir
      var value = 0d; // aca se guarda el valor que ingresa el usuario, para no manejarlo desde GetNewValue()

      while (!quit)
      {
        ShowCurrentValue();
        ShowMenu();
        var input = Console.ReadLine();
        switch (input)
        {
          case Add:
            value = GetNewValue();
            Calculator.Add(value);
            break;
          case Subtract:
            value = GetNewValue();
            Calculator.Subtract(value);
            break;
          case Multiply:
            value = GetNewValue();
            Calculator.Multiply(value);
            break;
          case Divide:
            value = GetNewValue();
            Calculator.Divide(value);
            break;
          case Quit:
            quit = true;
            break;
          default:
            Console.WriteLine("Invalid option, try again.");
            break;
        }
        Console.Clear(); //comentar para que se vea el mensaje de default
      }
      Console.WriteLine("~THE END~");
    }
  }
}
